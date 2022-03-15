using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Data;
using Euromonitor.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                return book;

            }
            return null;
        }
        public Book UpdateBook(Guid bookId, Book _book)
        {
            var book = EuromonitorDbContext.Books.Find(bookId);
            book.Name = string.IsNullOrEmpty(_book.Name) ? book.Name : _book.Name;
            book.Text = string.IsNullOrEmpty(_book.Text) ? book.Text : _book.Text;
            book.Price = _book.Price <= 0 ? book.Price : _book.Price;
            EuromonitorDbContext.Books.Update(book);
            EuromonitorDbContext.SaveChanges();
            return book;
        }

        public List<Book> GetBooks(int take = 10, int skip = 0)
        {
            return EuromonitorDbContext.Books.Take(take).Skip(skip).ToList(); ;
        }
        public List<Book> GetMyBooks(int userId, int take = 10, int skip = 0 )
        {
            return EuromonitorDbContext.Subcriptions.Include(s => s.Book).Where(s=>s.UserId==userId && s.State==(int)SubscriptionEnum.Subscribe).Select(s=>s.Book).Take(take).Skip(skip).ToList(); ;
        }

        public Book GetBook(Guid bookId)
        {
            return EuromonitorDbContext.Books.Find(bookId);
        }
    }
}
