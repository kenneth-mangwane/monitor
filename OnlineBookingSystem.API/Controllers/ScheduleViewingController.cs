using Microsoft.AspNetCore.Mvc;
using System;
using SouthPointMaintenance.Data;
using SP.Core.Users;
using System.Collections.Generic;
using SouhtPoint.Services;
using System.Threading.Tasks;
using SouthPointMaintenance.Models;

namespace OBS.Admin.Controllers
{
    [Route("api/schedule-viewing")]
    public class ScheduleViewingController : Controller
    {
        IScheduleViewingLogic _scheduleViewingLogic;

        public ScheduleViewingController(IScheduleViewingLogic scheduleViewingLogic)
        {
            _scheduleViewingLogic = scheduleViewingLogic;

        }


        [HttpPost()]
        public IActionResult Booking([FromBody]RequestViewingViewModel model)
        {
            try
            {

                var cookie = Request.Cookies["utm"];
                _scheduleViewingLogic.ScheduleViewing(model, cookie);
                return Ok();
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            return Ok(_scheduleViewingLogic.GetCities());
        }

        [HttpGet("buildings/{cityId}")]
        public IActionResult GetBuildings(int cityId)
        {
            return Ok(_scheduleViewingLogic.GetCityBuildings(cityId));
        }

        [HttpGet("apartment-types/{buildingId}")]
        public IActionResult GetApartmentTypes(int buildingId)
        {

            return Ok(_scheduleViewingLogic.GetBuildingApartmentType(buildingId));
        }

        [HttpGet("slots/{apartmentTypeId}/{date}")]
        public IActionResult BookingSlots(string date, int apartmentTypeId)
        {
            return Ok(_scheduleViewingLogic.GetSlots(date, apartmentTypeId));
        }
    }
}
