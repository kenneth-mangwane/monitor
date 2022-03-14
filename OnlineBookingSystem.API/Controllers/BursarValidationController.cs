using Microsoft.AspNetCore.Mvc;
using System;
using SP.Core.Users;
using SouthPointMaintenance.Data;
using OBS.API.Controllers.Base;
using System.Collections.Generic;
using System.Linq;
using OBS.Core;
using log4net;
using SP.Utilities.Models;
using OBS.Common.Data.Filtering;
using SP.Utilities.Extensions;
using OBS.Common.BusinessObjects;
using System.Web.Http;
using OBS.Core.Interfaces.Residential.ResidentailBursarValidation;
using OBS.Database.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using Microsoft.AspNetCore.Http;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
//using OBS.Common.BusinessObjects;

namespace OBS.Admin.Controllers
{
    [Route("api/bursar-validations")]
    public class BursarValidationController : BaseRestControllerWithKeyType<IBursarValidationLogic, BursarValidationEntry>
    {
        BursarValidationManager bursarValidation { get; set; }
        public BursarValidationController(IBursarValidationLogic logic, IHttpContextAccessor httpContextAccessor) : base(logic, httpContextAccessor)
        {

            bursarValidation = new();


        }
        [HttpPost()]
        public IActionResult EditAddBursarValidations([Microsoft.AspNetCore.Mvc.FromBody] Common.BusinessObjects.BursarValidation data)
        {
            try
            {
                bursarValidation.EditAddBursarValidations(data);
                return Ok(new { error = "", data = data });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


        [HttpPost("filtered")]
        public IActionResult GetBursarValidations(string sortBy = null, string q = null, bool dsc = false, int? page = 1, int? take = 10, [Microsoft.AspNetCore.Mvc.FromBody] IDictionary<string, object> filter = null)
        {
            try
            {

                var data = bursarValidation.GetAllBursarValidations();
                var result1 = CustomPaginateHelper<OBS.Common.BusinessObjects.BursarValidation>.PaginateAsync(filter, sortBy, q, dsc, page, take, data).Result;
                return Ok(new { error = "", data = result1 });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


    }
}
