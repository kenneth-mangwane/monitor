using Microsoft.AspNetCore.Mvc;
using System;
using SP.Core.Users;
using SouthPointMaintenance.Data;
using OBS.API.Controllers.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.Admin.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        public IUsersLogic _users;

        public UsersController(IUsersLogic users)
        {
            _users = users;
        }

        [HttpPost("change-username")]
        public async Task<IActionResult> ChangeUsername([FromBody] ApplicationUser user)
        {
            try
            {
                var data = await _users.ChangeUsername(user, user.plainPassword);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ApplicationUser user)
        {
            try
            {
                var data = await _users.ChangePassword(user, true, user.plainPassword);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] ApplicationUser user, bool notifyUser = false)
        {
            try
            {
                var data = await _users.AddUser(user, notifyUser);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpPost("update")]
        public IActionResult AddUserRoles([FromBody] ApplicationUser user)
        {
            try
            {
                var data = _users.UpdateUser(user);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpPost("roles/add/{userId}")]
        public IActionResult AddUserRoles([FromBody] List<ApplicationRole> roles, int userId)
        {
            try
            {
                var data = _users.AddUserRoles(userId, roles);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpPost("filter")]
        public IActionResult GetFilteredUsers([FromBody] IDictionary<string, object> filters, string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                try
                {
                    filters = filters.Where(s => !string.IsNullOrEmpty(s.Value.ToString())).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
                catch { }
                var data = _users.GetFilteredPaginatedUsers(take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: (Dictionary<string, object>)filters).Result;
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            try
            {
                var data = _users.GetUser(id);
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet()]
        public IActionResult GetUsers([FromBody] IDictionary<string, object> filters, string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                try
                {
                    filters = filters.Where(s => !string.IsNullOrEmpty(s.Value.ToString())).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
                catch { }
                var data = _users.GetFilteredPaginatedUsers(take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: (Dictionary<string, object>)filters).Result;
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}
