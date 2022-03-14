using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using OBS.Database.Models;
using SouthPointMaintenance.Data;
using System.Linq;
using OBS.Database;
using OBS.Database.Oracle.DL;
using System;
using System.IO;
using OBS.API.Controllers.Base;
using OBS.Core.Interfaces.Locations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using SP.Utilities.Extensions;
using System.Text;
using System.Web;
using OBS.Common.Interfaces;
using log4net;
using Oracle.ManagedDataAccess.Client;
using OBS.API.Models.ViewModel.Booking;
using System.Xml;
using Microsoft.AspNetCore.Hosting;

namespace OBS.API.Controllers
{
    [ApiController]
    [Route("/api/buildings")]

    public class BuildingController : BaseRestController<IBuildingLogic, Database.Models.Building, int>
    {
        
        protected IHostingEnvironment _hostingEnvironment;
        public BuildingController(IBuildingLogic logic, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment) : base(logic,
            httpContextAccessor)
        {
            _hostingEnvironment = hostingEnvironment;
        }

       
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            return base.Get();
        }

        [HttpGet("/api/building/GetBuildings")]
        public IActionResult GetBuildings()
        {
            return base.Get();

            var data = this.logic.GetAll(this.Filter);
            return base.Ok(new { error = "", data = data });
        }


        [HttpGet("all")]
        public async Task<IActionResult> GetOBSBuildings(int? buildingType = null, string sortBy = null, string q = null, bool dsc = false, int? page = 1, int? take = 10)
        {
            try
            {
                var buildings = BuildingManager.GetOBSBuildings().Where(s => (buildingType != null) ? ((int)s.BuildingType) == buildingType : true).ToList();
                Dictionary<string, object> filters = new();
                var result = await CustomPaginateHelper<Building>.PaginateAsync(Filters: filters, sortBy, q, dsc, page, take, buildings);
                return Ok(new { error = "", data = result });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBuilding(int id)
        {
            try
            {
                var buildings = BuildingManager.GetBuilding(id);
                return Ok(new { error = "", data = buildings });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }
        [HttpPut()]
        public async Task<IActionResult> UpdateBuilding([FromBody]Building building)
        {
            try
            {
                var buildings = BuildingManager.UpdateBuilding(building);
                return Ok(new { error = "", data = buildings });
            }
            catch (Exception exc)
            {
                return Ok(new { error = exc.Message.ToString(), data = "Internal Server Error" });
            }
        }

        /// <summary>
        /// This will retreive all the available buildings in a specific city
        /// for the specified institution
        /// </summary>
        /// <returns>The list of Building</returns>
        [Route("AvailableBuildings")]
        [HttpPost]
        public async Task<IActionResult> AvailableBuildings([FromBody] AvailableBuildingsViewModel availableBuildingsViewModels)
        {
            ILog logger = LogManager.GetLogger(GetType());
            try
            {
                int _cityID = int.Parse(availableBuildingsViewModels.cityID);
                int? _institutionID = int.Parse(availableBuildingsViewModels.institutionID);
                if (_institutionID.Value == 0)
                    _institutionID = null;
                try
                {
                    OBS.Common.BusinessObjects.Building[] buildings;

                    List<IBuilding> building = new List<IBuilding>();
                    try
                    {
                        Core.BuildingManager buildingManager = new Core.BuildingManager(logger);
                        building = buildingManager.GetBuildings(_cityID, _institutionID);
                    }
                    catch (OracleException cex)
                    {
                        string oracleError = OBS.Core.Helpers.OracleExceptionHelper.GetUIFriendlyErrorMessage(cex);
                        logger.Error(oracleError, cex);
                    }
                    catch (System.Exception ex)
                    {
                        logger.Error(string.Format("cityID = {0}. institutionID = {1}.", availableBuildingsViewModels.cityID, availableBuildingsViewModels.institutionID), ex);
                    }
                    buildings = building.Cast<OBS.Common.BusinessObjects.Building>().ToArray();

                    //buildings = buildings.ToArray();
                    StringBuilder innerHTML = new StringBuilder();
                    //if other (for institution) was chosen we cannot recommend any building
                    if (_institutionID == null)
                    {
                        this.addOptions(innerHTML, buildings.OrderBy(o => o.BuildingName).ToList(), "ScreenOneManager.BuildingSelectionChanged(this);");
                    }
                    else
                    {
                        //Get all the building with rankings and that has space availble
                        List<OBS.Common.BusinessObjects.Building> toAddfirst = buildings.Where(b => b.Ranking > 0 && b.Spaceavailable == true)
                                                             .OrderBy(o => o.Ranking).OrderBy(o => o.BuildingName).ToList();
                        //Get all the building with no rankings and/or that has no space availble
                        List<OBS.Common.BusinessObjects.Building> toAddLast = buildings.Where(b => b.Ranking <= 0 || b.Spaceavailable == false)
                                                             .OrderBy(o => o.BuildingName).ToList();

                        string optionGroupTemplate = "<optgroup onclick='ScreenOneManager.OptGroupClicked();' label='{0}'>";
                        //Only add the items with ranking and space availbale first, if there are any
                        //orderby rank and then BuildingName
                        if (toAddfirst != null && toAddfirst.Count > 0)
                        {
                            //is the "Other Buildings" Group going to be added
                            //if not we must not add the "Reccommended Building" Group
                            if (toAddLast != null && toAddLast.Count > 0)
                                innerHTML.Append(string.Format(optionGroupTemplate, "Recommended Buildings"));

                            this.addOptions(innerHTML, toAddfirst, "ScreenOneManager.BuildingSelectionChanged(this);");
                        }
                        //Now add all the items that don't have a ranking or has no space available
                        //orderby BuildingName
                        if (toAddLast != null && toAddLast.Count > 0)
                        {
                            //was the "Reccommended Building" Group added
                            //if not we must not add the "Other Buildings" Group
                            if (toAddfirst != null && toAddfirst.Count > 0)
                                innerHTML.Append(string.Format(optionGroupTemplate, "Other Buildings"));

                            this.addOptions(innerHTML, toAddLast, "ScreenOneManager.BuildingSelectionChanged(this);");
                        }
                    }
                    return Ok(new { error = "", data = innerHTML.ToString() });
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return Ok(new { error = "", data = string.Empty });
        }

        /// <summary>
        /// Loads up the given map url and returns it to the calling application
        /// </summary>
        /// <param name="mapURL">Url to the *.map file that contains the html for the map object</param>
        /// <returns>Json to the calling page, the page should then set the inner html of an object and call maphilite</returns>
        [Route("LoadMap")]
        [HttpGet]
        public async Task<IActionResult>  LoadMap(string mapURL)
        {
            try
            {
                string mapHTML = string.Empty;
                
                string webRootPath = _hostingEnvironment.WebRootPath;
                
                using (System.IO.StreamReader sr = new System.IO.StreamReader(MapPath(mapURL)))//server.mappath, returning a physical file path of the given map url
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(sr);
                    string imageLocation = xdoc.SelectSingleNode("MapFile/img").Attributes["src"].Value;
                    imageLocation = string.Empty; //System.Web.VirtualPathUtility.ToAbsolute(imageLocation);
                    xdoc.SelectSingleNode("MapFile/img").Attributes["src"].Value = imageLocation;
                    mapHTML = xdoc.SelectSingleNode("MapFile").InnerXml;
                }

                string apPath = _hostingEnvironment.WebRootPath; //Request.ApplicationPath;
                //string webRootPath = _hostingEnvironment.WebRootPath;

                if (!apPath.EndsWith("/"))
                    apPath += "/";

                apPath = "src=\"" + apPath;
                mapHTML = mapHTML.Replace("src=\"../../", apPath);
                return Ok(new { error = "", data = mapHTML });
            }
            catch (Exception ex)
            {
                LogManager.GetLogger(GetType()).Error(ex);
            }
            return Ok(new { error = "", data = string.Empty });
        }

        /// <summary>
        /// This will add a list option for every building in the list
        /// </summary>
        /// <param name="innerHTML">The string builder to add the list option to</param>
        /// <param name="buildingsToAdd">The list of buildings to create a list option for</param>        
        /// <param name="onClickMethod">The method to add on the onclick event</param>
        /// <param name="selectedId">The id of the building that needs to be selected. If zero the no building will be set as selected</param>
        private void addOptions(StringBuilder innerHTML, List<OBS.Common.BusinessObjects.Building> buildingsToAdd, string onClickMethod = null, int selectedId = 0)
        {
            if (string.IsNullOrEmpty(onClickMethod))
            {
                onClickMethod = string.Empty;
            }
            else
            {
                onClickMethod = "onclick='" + onClickMethod + "'";
            }

            string optionTemplate = "<option {0} {1} value='{2}' mapURl='{3}' mapImageUrl='{4}' spaceAvailable='{5}' rank='{6}' MinPrice='{9}' MaxPrice='{10}' BuldingName='{11}' PopupHTML='{12}' title='{7}'>{8}</option>";
            foreach (OBS.Common.BusinessObjects.Building item in buildingsToAdd)
            {
                string selected = string.Empty;
                if (selectedId != 0 && item.BuildingID == selectedId)
                    selected = "selected='selected'";
                innerHTML.AppendFormat(optionTemplate,
                    onClickMethod,                                  //0
                    selected,                                       //1
                    HttpUtility.HtmlEncode(item.BuildingID),        //2
                    HttpUtility.HtmlEncode(item.MapUrl),            //3
                    HttpUtility.HtmlEncode(item.MapImageUrl),       //4
                    HttpUtility.HtmlEncode(item.Spaceavailable),    //5
                    HttpUtility.HtmlEncode(item.Ranking),           //6
                    HttpUtility.HtmlEncode(item.DisplayName),       //7
                    HttpUtility.HtmlEncode(item.DisplayName),       //8
                    HttpUtility.HtmlEncode(item.MinPrice),          //9
                    HttpUtility.HtmlEncode(item.MaxPrice),          //10
                    HttpUtility.HtmlEncode(item.BuildingName),      //11
                    HttpUtility.HtmlEncode(item.InfoHtml));         //12
            }
        }
        public static string MapPath(string path)
        {
            return Path.Combine(
                (string)AppDomain.CurrentDomain.GetData("ContentRootPath"),
                path);
        }
    }
}
