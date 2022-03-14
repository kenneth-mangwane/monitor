using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBS.Core.Interfaces.Bursar;
using OBS.API.Controllers.Base;
using OBS.Database.Models;
using Microsoft.AspNetCore.Http;

namespace OBS.API.Controllers
{

    [Route("api/headlease")]
    public class HeadleaseController : BaseRestControllerWithKeyType<IHeadLeaseLogic, HeadLease>
    {
        public HeadleaseController(IHeadLeaseLogic logic, IHttpContextAccessor httpContextAccessor) : base(logic, httpContextAccessor) { }

        [HttpGet("headLeaseDetails")]
        public IActionResult GetHeadLeaseList(string leaseType, int pageNumber, int pageSize)
        {
            try
            {
                var data = this.logic.GetHeadLeaseList(leaseType, pageNumber, pageSize);
                return this.Ok(data);
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("headLeaseLocations")]
        public IActionResult GetOracleHeadLeaseLocations(int leaseId, int customerId, string leaseType, int pageSize, int pageNumber)
        {
            try
            {

                if (leaseType == OBS.Common.Enums.AccountType.Residential.ToString())
                {
                    var data = this.logic.GeResidentialOracleHeadLeaseLocation(leaseId, customerId, leaseType, pageSize, pageNumber);
                    return this.Ok(data);
                }
                else
                {
                    var data = this.logic.GetOracleHeadLeaseLocation(leaseId, customerId, leaseType, pageSize, pageNumber);
                    return this.Ok(data);
                }


            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet, Route("studentAvailableBeds")]
        public IActionResult GetStudentAvailableBeds(int buildingId, int pageSize, int pageNumber, DateTime occupationDate, DateTime endDate)
        {
            try
            {
                var data = this.logic.GetStudentAvailableBeds(buildingId, pageSize, pageNumber, occupationDate, endDate); //.GetAllResidentialBuilding();
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


        [HttpGet, Route("unavailableRoom")]
        public IActionResult GetUnavailableRoom(int buildingId, DateTime occupationDate, DateTime endDate)
        {
            try
            {
                var data = this.logic.GetUnavailableRoom(buildingId, occupationDate, endDate);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}
