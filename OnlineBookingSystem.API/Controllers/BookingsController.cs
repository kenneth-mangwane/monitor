using Microsoft.AspNetCore.Mvc;
using OBS.API.Controllers.Base;
using OBS.Core.Interfaces;
using OBS.Core.Interfaces.Biometric;
using OBS.Core.Interfaces.Bookings;
using OBS.Core.Interfaces.Bursar;
using OBS.Core.Interfaces.Customers;
using OBS.Core.Interfaces.DAL;
using OBS.Core.Interfaces.Leases;
using OBS.Core.Interfaces.Locations;
using OBS.Core.Interfaces.Residential;
using OBS.Core.Interfaces.Services;
using OBS.Data.EF.Interface;
using OBS.Database;
using OBS.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser = SouthPointMaintenance.Data.ApplicationUser;

namespace OBS.API.Controllers
{

    [Route("api/bookings")]
    public class BookingsController : ResidentialBookingsController
    {

        #region Properties
        protected IHeadLeaseLogic HeadLeaseLogic { get; set; }
        public IResidentialLeaseLogic ResidentialLeaseLogic { get; set; }

        public IBiometricLogic BiometricLogic { get; set; }

        protected IMsSQLLogic MsSQLLogic { get; set; }

        protected IApplicationConfigurationLogic ApplicationConfigurationLogic { get; set; }

        protected ISobsUnitOfWork SobsUnitOfWork { get; set; }

        protected IEmailLogic EmailLogic { get; private set; }

        public IEfUnitOfWork UnitOfWork { get; set; }

        public IBuildingLogic BuildingLogic { get; set; }
        protected IOracleCustomerLogic OracleCustomerLogic { get; set; }
        protected IOracleLeaseLogic OracleLeaseLogic { get; set; }
        protected IBookingsLogic BookingsLogic { get; set; }
        #endregion

        public BookingsController(IBookingsLogic bookingsLogic, IHeadLeaseLogic headLeaseLogic, Core.Interfaces.Residential.IResidentialLeaseLogic residentialLeaseLogic, ISobsUnitOfWork sobsUnitOfWork, IMsSQLLogic msSQLLogic, IEmailLogic emailLogic, IBuildingLogic buildingLogic, IApplicationConfigurationLogic applicationConfigurationLogic, IOracleLeaseLogic oracleLeaseLogic, IOracleCustomerLogic oracleCustomerLogic, IBiometricLogic biometricLogic)
        {
            this.BookingsLogic = bookingsLogic;
            this.BiometricLogic = biometricLogic;
            this.ResidentialLeaseLogic = residentialLeaseLogic;
            this.HeadLeaseLogic = headLeaseLogic;
            this.SobsUnitOfWork = sobsUnitOfWork;
            this.BuildingLogic = buildingLogic;
            this.MsSQLLogic = msSQLLogic;
            this.EmailLogic = emailLogic;
            this.ApplicationConfigurationLogic = applicationConfigurationLogic;
            this.OracleLeaseLogic = oracleLeaseLogic;
            this.OracleCustomerLogic = oracleCustomerLogic;
        }

        [HttpGet("initialize")]
        public async Task<IActionResult> ConfirmId(string identifier, int? uid = null, bool isPassport = false)
        {
            try
            {
                var result =  await BookingsLogic.InitializeBooking(identifier, uid, isPassport);
                return Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return Ok(new { error = eo.Message + " " + eo.InnerException?.Message });

            }
        }
        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            try
            {
                var result = BookingsLogic.GetCities();
                return this.Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return this.Ok(new { error = eo.Message });

            }
        }

        [HttpGet("institutions/{city}")]
        public IActionResult GetInstitutions(string city)
        {
            try
            {
                var result = BookingsLogic.GetInstitutions(city);
                return this.Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return this.Ok(new { error = eo.Message });

            }
        }

        [HttpGet("marketing-questions")]
        public IActionResult GetMarketingQuestions()
        {
            try
            {
                var result = BookingsLogic.GetMarketingQuestions();
                return this.Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return this.Ok(new { error = eo.Message });

            }
        }

        [HttpPut("update/profile/{id}")]
        public IActionResult UpdateProfile(int id, ApplicationUser user)
        {
            try
            {
                var result = BookingsLogic.UpdateUser(id, user);
                return this.Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return this.Ok(new { error = eo.Message });

            }
        }

        [HttpPut("update/booking/{bookingId}")]
        public IActionResult UpdateBooking(int bookingId, Lease lease)
        {
            try
            {
                var result = BookingsLogic.UpdateBooking(bookingId, lease);
                return this.Ok(new { error = "", data = result });

            }
            catch (Exception eo)
            {
                return this.Ok(new { error = eo.Message });

            }
        }


        [HttpGet, Route("BursarCustomers")]
        public IActionResult GetAllBursarCustomers(string bursarType, int bursarId = default(int))
        {
            //  Xpedia.SSOBS.Oracle.DL
            var toReturn = this.OracleCustomerLogic.GetBursarCustomers(bursarType, bursarId);
            DateTime occupationDate = DateTime.Today;
            return this.Ok(new { error = "", data = new { bursarList = toReturn.Rows } });
        }

        [HttpPost, Route("HeadLease")]
        public IActionResult SaveBooking([FromBody] HeadLease headLease)
        {

            try
            {
                this.HeadLeaseLogic.Insert(headLease, true);
                return this.Ok(new { error = "", data = new { headLease = headLease } });
            }
            catch (Exception ex)
            {

                return Ok(new { error = ex.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}
