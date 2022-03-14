using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using OBS.Core;
using System.Threading.Tasks;
using OBS.Core.Interfaces.Leases;
//using OBS.Common.BusinessObjects;

namespace OBS.Admin.Controllers
{
    [Route("api/leases")]
    public class LeaseController : Controller
    {
        AutoCancelledLeaseManager autoCancelledLease { get; set; }
        ILeaseSendingLogic leaseSendingLogic;
        public LeaseController(ILeaseSendingLogic _leaseSendingLogic)
        {
            leaseSendingLogic = _leaseSendingLogic;
            autoCancelledLease = new();
        }

        [HttpGet("send-lease/{leaseId}")]
        public async Task<IActionResult> SendLease(long leaseId, string email, string tenant)
        {
            try
            {
                var result = await leaseSendingLogic.SendLeaseSchedule(leaseId, email, tenant);
                return Ok(result);
            }
            catch (Exception eo)
            {
                return BadRequest(eo);

            }
        }
        [HttpGet("tenancy-schedule/{leaseId}")]
        [HttpGet("/api/tenancy/{leaseId}")]
        public async Task<IActionResult> Tenant(long leaseId)
        {
            try
            {
                var data = await leaseSendingLogic.GetLease(leaseId);
                return Ok(new { error = "", data });

            }
            catch (Exception eo)
            {
                return BadRequest(eo);
            }
        }
        [HttpGet("envelope-status/{leaseId}")]
        public async Task<IActionResult> EnvelopeStatus(long leaseId)
        {
            try
            {
                var result = leaseSendingLogic.CheckStatus(leaseId);
                return Ok(result);
            }
            catch (Exception eo)
            {
                return BadRequest(eo);

            }
        }
        [HttpPost("sending/paginate")]
        public async Task<IActionResult> PaginateTenants([FromBody] Dictionary<string, object> Filter, string table, string SortBy = null, string SearchString = null, bool DSC = false, int? Page = 1, int? Take = 10)
        {
            try
            {
                var data = await leaseSendingLogic.PaginateLeases(Filter, SortBy, SearchString, DSC, Page, Take);
                if (data.Status == 200) return Ok(new { error = "", data });
                return BadRequest(data);
            }
            catch (Exception eo)
            {
                return BadRequest(eo);
            }
        }

        [HttpGet("auto-cancelled/{id}")]
        [HttpGet("cancelled/{id}")]
        public IActionResult GetCancelledLease(int id)
        {
            try
            {
                var data = autoCancelledLease.GetCancelledLease(id);


                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("cancelled")]
        [HttpGet("auto-cancelled")]
        public IActionResult GetAutoCancelledLeases(string sortBy = null, string q = null, bool dsc = false, int? page = 1, int? take = 10, [FromQuery] Dictionary<string, string> filter = null)
        {
            try
            {

                var data = autoCancelledLease.GetPaginatedCancelledLeases((int)take, (int)page, filter, q);// out int PageCount, out int TotalNumberOfRecords, out int PageNumber);

                return Ok(new { error = "", data });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }


    }
}
