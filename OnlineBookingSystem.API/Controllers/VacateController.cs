using Microsoft.AspNetCore.Mvc;
using System;
using SP.Core.Users;
using SouthPointMaintenance.Data;
using OBS.API.Controllers.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBS.Core;
using OBS.Database.Models;
using SP.Utilities.Models;

namespace OBS.Admin.Controllers
{
    [Route("api/vacate")]
    public class VacateListController : Controller
    {
        public RoomVacationManagement _roomVacation;

        public VacateListController(RoomVacationManagement roomVacation)
        {
            _roomVacation = roomVacation;
        }


        [HttpGet("list")]
        public async Task<IActionResult> GetRoomVacations( string sortBy = null, string q = null, bool dsc = false, int? page = null, int? take = null)
        {
            try
            {
                //try
                //{
                //    filters = filters.Where(s => !string.IsNullOrEmpty(s.Value.ToString())).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                //}
                //catch { }
                var data = await _roomVacation.GetRoomVacations(take,page, sortBy, q, dsc, new Dictionary<string, object>());//(take: take, pageNumber: page, sortBy: sortBy, searchString: q, dsc: dsc, filterBy: (Dictionary<string, object>)filters).Result;

                return Ok(new { error = "", data  });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
    }
}
