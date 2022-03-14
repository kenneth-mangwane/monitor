using Microsoft.AspNetCore.Mvc;
using System;
using SouthPointMaintenance.Data;
using SP.Core.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using SouhtPoint.Models;
using DotslashMiddleware.Services;
using SouhtPoint.Services;
using SP.Utilities.Services;
using Microsoft.AspNetCore.Hosting;
using SP.Core.Logic.Freshsales;
using System.Web.Http;

using SudonumCDRRequest = SouhtPoint.Data.SudonumCDRRequest;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;

namespace OBS.Admin.Controllers
{
    [Route("api/contact")]
    public class ContactController : Controller
    {
        IEmailSender _mailSender;

        public ContactController(IEmailSender mailSender)
        {
            _mailSender = mailSender;
            //info@spms.co.za

        }

        [AllowAnonymous]
        [Route("register/call")]
        [HttpPost]
        public async Task<IActionResult> AddCallLead([FromBody] SudonumCDRRequest sudonum)
        {
            try { sudonum.data.Source = sudonum.data.meta.Source; } catch { }

            try
            {
                DotslashMiddlewareService.AddCallLead(sudonum.data);
            }
            catch (Exception eo) { return BadRequest(eo); }

            try
            {
                return Ok(SPFreshsales.AddCallLead(sudonum));
            }
            catch (Exception eo)
            {

                return BadRequest(eo);
            }
        }

        [Route("/api/contact")]
        [HttpPost()]
        public async Task<IActionResult> Contact([FromBody] ContactViewModel model)
        {
            model.SourceId = 1;

            var cookie = Request.Cookies["utm"];
            try
            {
                try
                {
                    DotslashMiddlewareService.AddForm(new
                    {
                        model.Name,
                        model.Email,
                        model.Phone
                    },
                    new
                    {
                        model.City,
                        Form = "Call me back"

                    }, utm: cookie, page: model.Page);
                }
                catch { }

                try { MailChimpService.AddSPDripMember(model.Email); } catch { }

                bool isComplete;

                try
                {
                    isComplete = SPFreshsales.AddCallRequestLead(model, cookie);
                }
                catch
                {
                    isComplete = false;
                }

                try { SPFreshsales.AddDBLead(model, cookie, isComplete); }
                catch { }

                await _mailSender.SendEmailWithTemplateAsync("info@spms.co.za", "Emails/contact", model);

                await _mailSender.SendEmailWithTemplateAsync(model.Email, "Emails/contactusercopy", model);

                try { SheetsProvider.SubmitEnquiry(model, cookie); } catch { }


                return Ok(isComplete);
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }
    }
}
