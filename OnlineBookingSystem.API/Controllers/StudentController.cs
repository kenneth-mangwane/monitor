using Microsoft.AspNetCore.Mvc;
using OBS.Common.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBS.Core.Interfaces.Leases;
using OBS.Core.Interfaces.Student;
using OBS.API.Controllers.Base;
using Microsoft.Extensions.Hosting.Internal;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http.Headers;
using OBS.Common.JQuery;
using OBSAdmin.Core.StudentManagement;
using OBSAdmin.Common.BusinessObjects;
using log4net;
using OBS.Core;

namespace OBS.API.Controllers
{
    [Route("api/student")]
    public class StudentController : Controller
    {
        readonly IOracleLeaseLogic _oracleLeaseLogic;
        readonly IStudentLogic _studentLogic;
        private IHostingEnvironment _hostingEnvironment;

        public StudentController(IOracleLeaseLogic oracleLeaseLogic, IStudentLogic studentLogic, IHostingEnvironment hostingEnvironment)
        {
            _oracleLeaseLogic = oracleLeaseLogic;
            _studentLogic = studentLogic;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [Route("sleepovers")]
        [HttpGet]
        public IActionResult GetSleepovers(string idNumber, int pageNumber, int pageSize)
        {
            try
            {
                var data = this._studentLogic.GetSleepovers(idNumber, pageNumber, pageSize);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [Route("addSleepover")]
        [HttpPost]
        public IActionResult AddSleepover([FromBody] Sleepover sleepover)
        {
            try
            {
                OBS.Database.Models.Sleepover data = this._studentLogic.AddSleepover(sleepover);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [Route("blacklistedStudents")]
        [HttpGet]
        public IActionResult GetBlacklistedStudents(int pageNumber, int pageSize, string IdNumber = null, string type = null)
        {
            try
            {
                if (type == "Booking" || type == "Wifi Tokens")
                {
                    var data = this._studentLogic.GetBlacklistedStudentsByType(pageNumber, pageSize, IdNumber, type);
                    return this.Ok(new { error = "", data = data });
                }
                else
                {
                    var data = this._studentLogic.GetBlacklistedStudents(pageNumber, pageSize, IdNumber, type);
                    return this.Ok(new { error = "", data = data });
                }
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [Route("blacklistStudent")]
        [HttpPost]
        public IActionResult BlacklistStudent([FromBody] Blacklist blacklist)
        {
            try
            {
                OBS.Database.Models.Blacklist data = this._studentLogic.AddBlacklist(blacklist);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [Route("removeBlacklist")]
        [HttpPost]
        public IActionResult RemoveBlacklist([FromBody] Blacklist blacklist)
        {
            try
            {
                OBS.Database.Models.Blacklist data = this._studentLogic.DeleteBlacklist(blacklist);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [Route("blacklistArchive")]
        [HttpGet]
        public IActionResult BlacklistArchive(int pageNumber, int pageSize, string IdNumber = null)
        {
            try
            {
                var data = this._studentLogic.GetBlacklistArchive(pageNumber, pageSize, IdNumber);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


        [Route("blacklistArchiveToExcel")]
        [HttpGet]
        public IActionResult ExportToExcel()
        {

            string ExcelFileName = "BlacklistArchive";
            string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");
            string webRootPath = _hostingEnvironment.WebRootPath;
            string file = Path.Combine(webRootPath, "downloads", fileName);

            this._studentLogic.ExportBlacklistArchiveToExcel(file);
            if (!System.IO.File.Exists(file))
            {
                //return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }
            var net = new System.Net.WebClient();
            var data = net.DownloadData(file);
            var content = new System.IO.MemoryStream(data);
            var contentType = "APPLICATION/octet-stream";
            return File(content, contentType, fileName);
        }


        [HttpGet]
        [Route("studentleasenextofkin")]
        public IActionResult GetNextOfKinDetails(string idNumber, string refNumber, string name, int pageNumber, int pageSize)
        {
            try
            {
                // first try get the current lease
                LeaseApartment studentLease = _oracleLeaseLogic.GetOracleLease(idNumber, string.Empty, false).Rows.FirstOrDefault();
                string[] args = new[] { idNumber, refNumber, name, studentLease != null ? studentLease.LeaseNumber : string.Empty };

                // if the student has a lease, then use that lease's information, else, use the latest from the database
                var data = _studentLogic.GetNextOfKinDetails(args, pageNumber, pageSize);

                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("Bookings")]
        public IActionResult GetBookings(string idNumber, string refNumber, string name, int pageNumber, int pageSize)
        {
            try
            {
                string[] args = new[] { idNumber, refNumber, name };

                // if the student has a lease, then use that lease's information, else, use the latest from the database
                var data = this._studentLogic.PaginateBookings(args, pageNumber, pageSize);

                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("lease/{oracleLeaseNumber}/{terminationDate}")]
        public IActionResult FindLeaseByLeaseNumber(string oracleLeaseNumber, int terminationDate)
        {
            try
            {
                var lease = _oracleLeaseLogic.LoadLeaseByLeaseNumberTerminationDate(oracleLeaseNumber, terminationDate);

                return this.Ok(new { error = "", data = lease });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        /// <summary>
        /// Find student details - first screen visible to the user
        /// </summary>
        /// <param name="identityNumber">Get the student details by identity number.</param>
        /// <returns>The student details and which screen to proceed too.</returns>
        [HttpPost]
        [Route("FindStudentDetails")]
        public IActionResult FindStudentDetails([FromBody] string identityNumber)
        {

            try
            {
                if (this._studentLogic.IsStudentBlacklisted(identityNumber))
                {
                    OBS.Common.BusinessObjects.LoadedLease leaseData = new LoadedLease();
                    return this.Ok(new { error = "", data = leaseData, Screen = -6 });
                }
                else
                {
                    OBS.Common.BusinessObjects.LoadedLease sendMe = BookingManager.GetStudentLeaseByPersonIdentifier(identityNumber);
                    return this.Ok(new { error = "", data = sendMe });
                }
            }
            catch (Exception ex)
            {
                 OBS.Common.BusinessObjects.LoadedLease leaseData = new LoadedLease();
                return this.Ok(new { error = "", data = leaseData, Screen =- 2 });
            }
            return this.Ok(new { error = "", data = new object() });
        }

        /*[Route("FindStudentData")]
        [HttpPost]
        public JsonResult FindStudentData([FromBody] StudentDataHelperQuery data)
        {
            var studentData = new OBSAdmin.Core.StudentDataManagement.StudentData();
            var toReturn = studentData.FindStudentData(data.accountNumber, data.personIdentifier, data.mobileNumber, data.year);
            return Json(toReturn);
        }

        [Route("ExportToExcel")]
        [HttpPost]
        public JsonResult ExportToExcel([FromBody] StudentDataHelperQuery data)
        {
            var studentData = new OBSAdmin.Core.StudentDataManagement.StudentData();
            var toReturn = studentData.FindStudentData(data.accountNumber, data.personIdentifier, data.mobileNumber, data.year);

            string ExcelFileName = "LeasesForYear";
            string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");
            //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);

            string webRootPath = _hostingEnvironment.WebRootPath;
            string file = Path.Combine(webRootPath, "downloads", fileName);


            SobsAdmin.Common.ExcelExport ee = new SobsAdmin.Common.ExcelExport(file);
            ee.GenerateFile
                (
                    toReturn.Cast<object>().ToList(),
                    new string[]{
                            "PersonName",
                            "PersonIdentifier",
                            "MobileNumber",
                            "AccountNumber",
                            "Course",
                            "HeardFromWhere",
                            "HomeTown",
                            "InstitutionName",
                            "StudentNumber"

                        },
                    typeof(OBSAdmin.Common.Interface.iStudentData),
                    new string[]{
                            "Person Name",
                            "ID/Passport number",
                            "Mobile Number",
                            "Account Number",
                            "Course",
                            "Heard From Where",
                            "Home Town",
                            "Institution Name",
                            "Student Number"
                        }
                );
            return Json(string.Concat("../Excel/", fileName));
        }*/
    }
}
