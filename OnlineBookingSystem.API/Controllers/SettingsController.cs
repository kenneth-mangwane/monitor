using Microsoft.AspNetCore.Mvc;
using System;
using SP.Core.Users;
using SouthPointMaintenance.Data;
using OBS.API.Controllers.Base;
using System.Collections.Generic;
using System.Linq;
using SobsConfiguration;
using OBS.Common.BusinessObjects;

namespace OBS.Admin.Controllers
{
    [Route("api/settings")]
    public class SettingsController : Controller
    {
        public IUsersLogic _users;

        public SettingsController(IUsersLogic users)
        {
            _users = users;
        }

        [HttpPost("configuration/groups")]
        public IActionResult UpdateConfigurationGroups(string group, [FromBody]List<ApplicationConfiguration> settings)
        {
            try
            {
                string lastGroup = string.Empty;
                var data = Settings.SaveData(group, settings);

                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("configuration/groups")]
        public IActionResult GetConfigurationGroups()
        {
            try
            {
                string lastGroup = string.Empty;
                var data = Settings.loadConfigurationByGroup();

                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpGet("configuration")]
        public IActionResult GetConfiguration()
        {
            try
            {
                string lastGroup = string.Empty;
                var data = Settings.Sobs;
                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

    }
}
