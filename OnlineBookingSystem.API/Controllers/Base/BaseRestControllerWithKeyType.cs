using Microsoft.AspNetCore.Http;
using OBS.Core.Interfaces;
using OBS.Types.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Controllers.Base
{
    public class BaseRestControllerWithKeyType<ILogic, TModel> : BaseRestController<ILogic, TModel, int>
        where ILogic : IBusinessLogic<TModel, int>
        where TModel : EntityBase<int>, new()
    {
        public BaseRestControllerWithKeyType(ILogic logic, IHttpContextAccessor httpContextAccessor) : base(logic, httpContextAccessor)
        { }
    }
}
