using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Common.Utilities;
using Euromonitor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euromonitor.API.Controllers
{
    [ApiController]
    [Route("/api/subscription")]
    public class SubscriptionController : ControllerBase
    {
      
        private readonly ISubscriptionLogic subscriptionLogic;

        public SubscriptionController(ISubscriptionLogic _subscriptionLogic)
        {
            subscriptionLogic = _subscriptionLogic;
        }

        [HttpGet("{subscriptionId}")]
        public async Task<ActionResult<Subscription>> GetBySubscription(Guid subscriptionId)
        {
            try
            {
                return Ok(ReturnHandler.Handle(subscriptionLogic.GetSubscription(subscriptionId)));
            }
            catch(Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpGet()]
        public async Task<ActionResult<Subscription>> GetByBookUser(Guid bookId, int userId)
        {
            try
            {
                return Ok(ReturnHandler.Handle(subscriptionLogic.GetSubscription(bookId, userId)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<Subscription>>> GetSubscriptions(int limit=10, int skip =  0)
        {
            try
            {
                return Ok(ReturnHandler.Handle(subscriptionLogic.GetSubscriptions(limit, skip)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpGet("unsubscribe")]
        public async Task<ActionResult<Subscription>> Unsubscribe(Guid bookId, int userId)
        {
            try
            {
                return Ok(ReturnHandler.Handle(subscriptionLogic.Unsubscribe(bookId, userId)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpGet("subscribe")]
        public async Task<ActionResult<Subscription>> Subscribe(Guid bookId, int userId)
        {
            try
            {
                return Ok(ReturnHandler.Handle(subscriptionLogic.Subscribe(bookId, userId)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }
    }
}
