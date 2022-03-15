using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Common.Utilities;
using Euromonitor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euromonitor.API.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UserController : ControllerBase
    {
      
        private readonly IUserLogic  userLogic;

        public UserController(IUserLogic _userLogic)
        {
            userLogic = _userLogic;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<ApplicationUser>> GetUser(int uid)
        {
            try
            {
                return Ok(ReturnHandler.Handle(userLogic.GetUser(uid)));
            }
            catch(Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<ApplicationUser>> Login(ApplicationUser user)
        {
            try
            {
                return Ok(ReturnHandler.Handle(userLogic.Login(user.UserName, user.password).Result));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult<ApplicationUser>> Register(ApplicationUser user)
        {
            try
            {
                return Ok(ReturnHandler.Handle(userLogic.Register(user, user.password).Result));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<ApplicationUser>> UpdateDetails(int uid, ApplicationUser user)
        {
            try
            {
                return Ok(ReturnHandler.Handle(userLogic.UpdateUser(uid, user)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }
    }
}
