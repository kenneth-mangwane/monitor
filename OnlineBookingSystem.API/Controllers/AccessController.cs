using Microsoft.AspNetCore.Mvc;
using System;
using SouthPointMaintenance.Data;
using SP.Core.Users;
using System.Collections.Generic;
using SPM.Database.Data.Security;
using SP.Core.Security;

namespace OBS.Admin.Controllers
{
    [Route("api/access")]
    public class AccessController : Controller
    {
        public IAccessManager _access;
        public IRolesLogic _roles;

        public AccessController(IAccessManager access, IRolesLogic roles)
        {
            _access = access;
            _roles = roles;
        }
        [HttpGet("pages/{roleId}")]
        public IActionResult GetDSPages(int roleId)
        {
            try
            {
                var role = _roles.GetRole(roleId);
                _access.AddDSPageRolePermission(role);
                var data = _access.GetDSPageRolePermission(role);
                return Ok(new { error = "", data });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpPost("pages/{roleId}")]

        public IActionResult GetDSPages(int roleId, [FromBody] IDictionary<string, object> filters, string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                var role = _roles.GetRole(roleId);
                _access.AddDSPageRolePermission(role);
                var data = _access.GetPaginatedDSPageRolePermission(role, take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: (Dictionary<string, object>)filters).Result;
                return Ok(new { error = "", data });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpPost("permission")]
        public IActionResult UpdateDSPagesRolePermission([FromBody]DSPageRolePermission permission)
        {
            try
            {
                permission = _access.UpdateDSPageRolePermission(permission);
                return Ok(new { error = "", data = permission });

            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

    }
}
