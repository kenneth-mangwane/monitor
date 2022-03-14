using Microsoft.AspNetCore.Mvc;
using OBS.Common.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBS.Core.Interfaces.Leases;
using OBS.Core.Interfaces.Student;
using SouthPointMaintenance.Data;
using SP.Core.Users;

namespace OBS.Admin.Controllers
{
    [Route("api/roles")]
    public class RolesController : Controller
    {
        public IRolesLogic _roles;

        public RolesController(IRolesLogic roles)
        {
            _roles = roles;
        }
        [HttpPost("{id}")]
        public IActionResult EditRole(int id, [FromBody]ApplicationRole role)
        {
            try
            {
                if (role.Id == id)
                {
                    var data = _roles.EditRole(role);
                    return Ok(new { error = "", data });
                }
                return Ok(new { error = "The id does not match the given model" });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpPost()]
        public IActionResult AddRole(ApplicationRole role)
        {
            try
            {

                var data = _roles.AddRole(role);
                return Ok(new { error = "", data });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {


            try
            {
                var data = _roles.GetRole(id: id);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpGet("remaining/{userId}")]
        public IActionResult  GetRemainingRoles(int userId)//Dictionary<string, object> filters, string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                var data = _roles.GetRolesExcludingUserRoles(userId);//(take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: filters).Result;
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpGet()]
        public IActionResult  GetRoles(Dictionary<string, object> filters, string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                var data = _roles.GetPaginatedRoles(take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: filters).Result;
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}
