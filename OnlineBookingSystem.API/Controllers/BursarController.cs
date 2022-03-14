using Microsoft.AspNetCore.Http;
using OBS.API.Controllers.Base;
using OBS.Common.BusinessObjects;
using OBS.Core.Interfaces.Bursar;
using OBS.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace OBS.API.Controllers
{
    [Route("api/bursar")]
    public class BursarController : BaseRestControllerWithKeyType<IBursarLogic, Bursars>
    {
        private const string CELBUXAPIKEY = "CelbuxApi";
        public BursarController(IBursarLogic bursarLogic, IHttpContextAccessor httpContextAccessor) : base(bursarLogic, httpContextAccessor) { }

        [AllowAnonymous]
        [HttpGet("leasedetails")]
        public IActionResult GetFundedLeaseDetails(string idNumber)
        {
            try
            {
                OBS.Database.Models.Bursars bursar = null;

                LeaseTenant studentLease = this.logic.GetFundedLeaseDetails(idNumber).FirstOrDefault();

                if (null != studentLease)
                {
                    bursar = this.logic.GetStudentBursar(studentLease.BursarId);
                }
                return Ok(new { error = "", data = bursar });
            }
            catch (System.Security.SecurityException sx)
            {
                return Ok(new { error = sx.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [AllowAnonymous]
        [HttpGet("studentDetails")]
        public IActionResult GetStudentDetails(string idNumber)
        {
            try
            {
                LeaseTenant studentLease = this.logic.GetFundedLeaseDetails(idNumber).FirstOrDefault();

                return Ok(new { error = "", data = studentLease });
            }
            catch (System.Security.SecurityException sx)
            {
                return Ok(new { error = sx.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [AllowAnonymous]
        [HttpGet, Route("sendEmailStatement")]
        public IActionResult SendTransactionEmail(string idNumber)
        {
            try
            {
                LeaseTenant studentLease = this.logic.GetFundedLeaseDetails(idNumber).FirstOrDefault(); // Get student details
                Core.Logic.File.FileLogic fl = new Core.Logic.File.FileLogic();
                ResponseMessage sendEmail = fl.emailCelbuxPdf(studentLease);
                return Ok(new { error = "", data = sendEmail });
            }
            catch (System.Security.SecurityException sx)
            {
                return Ok(new { error = sx.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}