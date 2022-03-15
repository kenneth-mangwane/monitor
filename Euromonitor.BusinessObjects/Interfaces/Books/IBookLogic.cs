using Euromonitor.Data;
using System;
using System.Collections.Generic;

namespace Euromonitor.BusinessObjects.Interfaces
{
    public interface IBookLogic
    {
        public Book AddBook(Book book);
        public Book UpdateBook(Guid bookId, Book _book);
        public List<Book> GetBooks(int take = 10, int skip = 0);
        public List<Book> GetMyBooks(int userId, int take = 10, int skip = 0);
        public Book GetBook(Guid bookId);

    }
}
