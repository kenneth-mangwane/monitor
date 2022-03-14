using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OBS.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Controllers.Base
{
    //[WebAPIUserAuth]
    //[EnableCors("*")]
    public class ResidentialBookingsController : ControllerBase
    {
        protected Core.Residential.ResidentialBookings Resientials { get; set; }

        protected ResidentialBookingsController()
        {
            this.Resientials = new Core.Residential.ResidentialBookings();
        }

        protected SOBSContainer GetDbContext()
        {
            return new SOBSContainer(this.getCurrentUserName());
        }

        protected string getCurrentUserName()
        {
            if (this.Request == null)
            {
                return null;
            }

            if (this.Request.Headers == null || string.IsNullOrEmpty(this.Request.Headers["Authorization"]))
                return null;

            return this.Request.Headers["Authorization"];
        }

        [NonAction]
        public IEnumerable<string> Options()
        {
            return new[] { "POST", "PUT", "GET", "DELETE", "OPTIONS" };
        }
    }

    public class WebAPIUserAuthAttribute : ActionFilterAttribute
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            string username = context.HttpContext.Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(username))
            {
                throw new UnauthorizedAccessException();
            }

            return;
        }
    }
}
