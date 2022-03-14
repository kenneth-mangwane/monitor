using DryIoc;
using Microsoft.AspNetCore.Mvc;
using OBS.Common.Interfaces;
using OBS.Core.Interfaces.BedManagerLogic;
using OBS.Core.Interfaces.BuildingManagerLogic;
using OBS.Core.Interfaces.BursarConfig;
using OBS.Core.Interfaces.BursarManagerLogic;
using OBS.Core.Interfaces.CityManagerLogic;
using OBS.Core.Interfaces.Locations;
using OBS.Core.IoC;
using OBS.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Controllers
{
    [Route("api/bursarconfig")]
    public class BursarConfigController : ControllerBase
    {
        public ICityManagerLogic ICityManagerLogic { get; set; }
        public IBuildingManagerLogic IBuildingManagerLogic { get; set; }
        public IBursarManagerLogic IBursarManagerLogic { get; set; }
        public IBedManagerLogic IBedManagerLogic { get; set; }
        public IBuildingLogic buildingLogic { get; set; }
        public IBursarConfigurationLogic bursarConfigLogic { get; set; }
        const string BUILDINGTYPE = "S";
        public BursarConfigController(ICityManagerLogic logic, IBuildingManagerLogic buildManLogic, IBursarManagerLogic bursarLogic, IBedManagerLogic bedLogic, IBuildingLogic buildLogic, IBursarConfigurationLogic bursarConfigLogic)
        {
            var container = ContainerRegistration.CreateContainer(rules =>
                                      rules.WithoutThrowOnRegisteringDisposableTransient()
                                      .With(FactoryMethod.ConstructorWithResolvableArguments)
            );
            this.ICityManagerLogic = (ICityManagerLogic)container.Resolve(typeof(ICityManagerLogic), true);
            this.IBuildingManagerLogic = (IBuildingManagerLogic)container.Resolve(typeof(IBuildingManagerLogic), true);
            this.IBursarManagerLogic = (IBursarManagerLogic)container.Resolve(typeof(IBursarManagerLogic), true);
            this.IBedManagerLogic = (IBedManagerLogic)container.Resolve(typeof(IBedManagerLogic), true);
            this.buildingLogic = (IBuildingLogic)container.Resolve(typeof(IBuildingLogic), true);
            this.bursarConfigLogic = (IBursarConfigurationLogic)container.Resolve(typeof(IBursarConfigurationLogic), true);
        }

        [HttpGet]
        [Route("getRegions")]
        public IActionResult GetRegions()
        {
            try
            {
                var data = this.ICityManagerLogic.GetCities();
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("getBursarFeeTypes")]
        public IActionResult GetBursarFeeTypes()
        {
            try
            {
                var data = this.bursarConfigLogic.GetBursarFeeTypes();
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [HttpGet("/api/bursars/bursar-list")]
        [Route("getBursarList")]
        public IActionResult GetBursarList(string cityName, string personIdentifier = null)
        {
            try
            {
                var data = this.IBursarManagerLogic.GetBursars(cityName, personIdentifier);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("getBuildings")]
        public IActionResult GetBuildings(int cityID, int? institutionID = null)
        {
            try
            {
                List<IBuilding> buildings = this.IBuildingManagerLogic.GetBuildings(cityID, institutionID);
                foreach (Common.BusinessObjects.Building item in buildings)
                {
                    // instead of loading them afterwards, we load the apartment types with the building
                    item.ApartmentTypes = this.buildingLogic.GetBuildingRoomType(BUILDINGTYPE, item.BuildingID);
                }
                return this.Ok(new { error = "", data = buildings });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("getBursarPricing")]
        public IActionResult GetBursarPricing(int bursarID, string buildings, int year)
        {
            int[] buildingIDs = stringToIntArray(buildings);
            try
            {
                var data = this.bursarConfigLogic.GetBursarPricing(bursarID, buildingIDs, year);
                return this.Ok(new { error = "", data = data });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpPut, Route("saveConfiguration")]
        public IActionResult SaveConfiguration([FromBody] List<BursarPricing> bursarPricing)
        {
            try
            {
                this.bursarConfigLogic.SaveBursarPricing(bursarPricing);
                return this.Ok(new { error = "", data = "OK" });
            }
            catch (Exception exc)
            {
                return this.Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        /// <summary>
        /// Converts a single string object with an array inside into an int array
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private int[] stringToIntArray(string items)
        {
            if (items.Length > 2)
            {
                int startPos = items.IndexOf("[") + 1;
                int endPos = items.IndexOf("]") - 1;
                return items.Substring(startPos, endPos).Split(',').Select(int.Parse).ToArray();
            }
            else
            {
                return new int[0];
            }
        }

    }
}
