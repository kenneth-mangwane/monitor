using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Controllers
{
    public class InstitutionController : Controller
    {
        /*public JsonResult AvailableInstitutions(string cityID)
        {
            ILog logger = LogManager.GetLogger(GetType());
            try
            {
                int _cityID = int.Parse(cityID);
                SSOBSService.SSOBSClient service = new SSOBSService.SSOBSClient();
                try
                {
                    var institutionManager = new OBS.Core.InstitutionManager();

                    Institution[] institutions = institutionManager.GetInstitutions(_cityID);
                    service.Close();
                    institutions = institutions.OrderBy(o => o.InstitutionName).ToArray();
                    StringBuilder innerHTML = new StringBuilder();

                    string optionTemplate = "<option value='{0}'>{1}</option>";
                    innerHTML.Append("<option value='(Select)'>(Select)</option>");
                    foreach (Institution item in institutions)
                    {

                        innerHTML.Append(string.Format(optionTemplate, HttpUtility.HtmlEncode(item.InstitutionID),
                                                                        HttpUtility.HtmlEncode(item.InstitutionName)));
                    }
                    innerHTML.Append("<option value='0'>Other</option>");
                    return this.Json(innerHTML.ToString());
                }
                catch (TimeoutException toex)
                {
                    service.Abort();
                    logger.Error(string.Format("TimeoutException @ InstitutionController.AvailableInstitutions('{0}')", cityID));
                    logger.Error(toex);
                }
                catch (CommunicationException comex)
                {
                    service.Abort();
                    logger.Error(string.Format("CommunicationException @ InstitutionController.AvailableInstitutions('{0}')", cityID));
                    logger.Error(comex);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return this.Json(string.Empty);
        }*/
    }
}
