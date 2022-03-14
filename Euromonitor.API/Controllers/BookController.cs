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
    [Route("/api/book")]
    public class BookController : ControllerBase
    {
      
        private readonly IBookLogic  bookLogic;

        public BookController(IBookLogic _bookLogic)
        {
            bookLogic = _bookLogic;
        }

        [HttpGet("{bookId}")]
        public async Task<ActionResult<Subscription>> GetBook(Guid bookId)
        {
            try
            {
                return Ok(ReturnHandler.Handle(bookLogic.GetBook(bookId)));
            }
            catch(Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }


        [HttpGet("list")]
        public async Task<ActionResult<List<Subscription>>> GetBooks(int limit=10, int skip =  0)
        {
            try
            {
                return Ok(ReturnHandler.Handle(bookLogic.GetBooks(limit, skip)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpPost("add")]
        public async Task<ActionResult<Subscription>> AddBook(Book book)
        {
            try
            {
                return Ok(ReturnHandler.Handle(bookLogic.AddBook(book)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<Subscription>> UpdateBook(Guid bookId, Book book)
        {
            try
            {
                return Ok(ReturnHandler.Handle(bookLogic.UpdateBook(bookId, book)));
            }
            catch (Exception eo)
            {
                return BadRequest(ReturnHandler.Handle(eo));
            }
        }
    }
}
