using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBS.API.Filtering.Providers;
using OBS.BusinessLogic.Interfaces;
using OBS.Core.Interfaces;
using OBS.Types.Interfaces.Data.Filtering;
using OBS.Types.Models.Data;
using OBS.WebApi.Common.Controllers;
using OBS.WebApi.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;

namespace OBS.API.Controllers.Base
{
    public class BaseRestController<ILogic, TModel, Dtype> : BaseRestController<TModel>, IXwaController
        where ILogic : IBusinessLogic<TModel, Dtype>
        where TModel : EntityBase<Dtype>, new()
    {
        public const string FILTERPROVIDERTYPEPARAM = "FilterProvider";

        public const string DEFAULTFILTERPROVIDER = "xFilter";

        public const string FILTERPROVIDERGROUP = "RestFiltering";

        public const string PROVIDERPATH = "ProviderPath";

        /// <summary>
        /// The MEF container that will get all the providers
        /// </summary>
        protected CompositionContainer providerContainer;

        private IFilterProvider queryFilterProvider = null;

        /// <summary>
        /// Will return the name of the Filter provider to look for
        /// </summary>
        public string FilterProviderName
        {
            get
            {
                if (this.QueryParams.Any(p => p.Key.ToLower() == BaseRestController<ILogic, TModel, Dtype>.FILTERPROVIDERTYPEPARAM.ToLower()))
                {
                    return this.QueryParams.Where(p => p.Key.ToLower() == BaseRestController<ILogic, TModel, Dtype>.FILTERPROVIDERTYPEPARAM.ToLower()).First().Value;
                }

                return XFilterProvider.DEFAULTFILTERPROVIDER;
            }
        }

        public IFilterProvider FilterProvider
        {
            get
            {
                if (queryFilterProvider != null && queryFilterProvider.Name == this.FilterProviderName)
                {
                    return this.queryFilterProvider;
                }

                if (this.providerContainer == null || this.providers == null || this.providers.Count() <= 0)
                {
                    this.compose();
                }

                this.queryFilterProvider = this.providers.Where(p => p.Name == this.FilterProviderName).FirstOrDefault();
                return this.queryFilterProvider;
            }
        }

        public IXFilterCollection Filter
        {
            get
            {
                var provider = this.FilterProvider;
                if (provider == null)
                {
                    return null;
                }

                return provider.GetFilter(this.QueryParams);
            }
        }

        /// <summary>
        /// All the provider that are registered
        /// </summary>
        [ImportMany]
        private IEnumerable<IFilterProvider> providers { get; set; }

        protected ILogic logic { get; set; }

        protected bool CommitOnCompletion { get; set; }

        //protected IConfigurationLogic ConfigurationLogic { get; set; }
        public BaseRestController(ILogic logic, IHttpContextAccessor httpContextAccessor)
        {
            this.logic = logic;
            this.CommitOnCompletion = true;
            _httpContextAccessor = httpContextAccessor;
        }

        [NonAction]
        public virtual IActionResult Get()
         {
             try
             {
                 IEnumerable<TModel> emptyModel = null;
                 var data = this.logic.GetAll(this.Filter);
                 return base.Ok(new { error = "", data = data });
             }
             catch (System.Security.SecurityException sx)
             {
                 return new StatusCodeResult(StatusCodes.Status500InternalServerError);
             }
         }

        [NonAction]
        public virtual IActionResult Get(Dtype id)
         {
             try
             {
                 TModel model = this.logic.Get(id, this.Filter);
                 return this.CreateGetResponse(model: model);
             }
             catch (System.Security.SecurityException sx)
             {
                 return  new StatusCodeResult(StatusCodes.Status500InternalServerError);
             }
         }

        [NonAction]
        public virtual IActionResult Put(Dtype id, TModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState, model: model);
                }

                if (!id.Equals(model.Id))
                {
                    return BadRequest(ModelState, model, "Id's do not match");
                }

                this.logic.Update(model, this.CommitOnCompletion);
                return this.CreatePutResponse(model: model);
            }
            catch (System.Security.SecurityException sx)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [NonAction]
        public virtual IActionResult Post([FromBody] TModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState, model: model);
                }

                this.logic.Insert(model, this.CommitOnCompletion);
                return this.CreatePostResponse(model: model);
            }
            catch (System.Security.SecurityException sx)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [NonAction]
        public virtual IActionResult Delete(Dtype id)
        {
            try
            {
                this.logic.Delete(id, this.CommitOnCompletion);
                return this.CreateDeleteResponse();
            }
            catch (System.Security.SecurityException sx)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// This method will set the current/executing user on the IUnitOfWork
        /// </summary>
        /// <param name="username">The username of the user who is executing the action</param>
        [NonAction]
        public override void SetUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                ((IBusinessLogic<TModel, Dtype>)this.logic).SetExecutingUser(User.Identity.Name);
            }
            else
            {
                ((IBusinessLogic<TModel, Dtype>)this.logic).SetExecutingUser(username);
            }
        }

        /// <summary>
        /// This method will set the current/executing user on the IUnitOfWork
        /// </summary>
        [NonAction]
        public virtual void SetUsername()
        {
            string username = this.getCurrentUserName();
            if (!string.IsNullOrEmpty(username))
            {
                this.SetUsername(username);
            }
        }

        [NonAction]
        protected string getCurrentUserName()
        {
            return User.Identity.Name;
        }

        /// <summary>
        /// The MEF framework will actually go and find all the dll's that implement the IAdapter interface
        /// </summary>
        /// <returns>Bool</returns>
        protected virtual bool compose()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            //string providerPath = this.ConfigurationLogic.GetOrCreateConfiguration<string>(BaseRestController<ILogic, TModel, Dtype>.FILTERPROVIDERGROUP, BaseRestController<ILogic, TModel, Dtype>.PROVIDERPATH, null);
            //if (!string.IsNullOrEmpty(providerPath))
            //{
            //    catalog.Catalogs.Add(new DirectoryCatalog(System.Environment.ExpandEnvironmentVariables(providerPath)));
            //}

            this.providerContainer = new CompositionContainer(catalog);
            CompositionBatch batch = new CompositionBatch();
            batch.AddPart(this);
            this.providerContainer.Compose(batch);

            return true;
        }
    }
}
