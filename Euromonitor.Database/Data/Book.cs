using Euromonitor.Common;
using System;

namespace Euromonitor.Data
{
    public class Book: AuditBase<Guid>
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
    }
}
