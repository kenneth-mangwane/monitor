using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Data;
using Euromonitor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Euromonitor.BusinessObjects.Logic
{
    public class BookLogic : IBookLogic
    {
        private EuromonitorDbContext EuromonitorDbContext { get; set; }
        public BookLogic(EuromonitorDbContext _euromonitorDbContext)
        {
            this.EuromonitorDbContext = _euromonitorDbContext;
        }

        public Book AddBook(Book book)
        {
            if (book.Validate())
            {
                EuromonitorDbContext.Books.Add(book);
                EuromonitorDbContext.SaveChanges();
            }
            return book;
        }
        public Book UpdateBook(Guid bookId, Book _book)
        {
            var book = EuromonitorDbContext.Books.Find(bookId);
            book.Name = string.IsNullOrEmpty(book.Name) ? _book.Name : book.Name;
            book.Text = string.IsNullOrEmpty(book.Text) ? _book.Text : book.Text;
            book.Price = book.Price <= 0 ? _book.Price : book.Price;
            return book;
        }

        public List<Book> GetBooks(int take = 10, int skip = 0)
        {
            return EuromonitorDbContext.Books.Take(take).Skip(skip).ToList(); ;
        }

        public Book GetBook(Guid bookId)
        {
            return EuromonitorDbContext.Books.Find(bookId);
        }
    }
}
