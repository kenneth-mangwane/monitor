using Euromonitor.Common;
using System;

namespace Euromonitor.Data
{
    public class Book : AuditBase<Guid>
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Name)) return false;
            if (string.IsNullOrEmpty(Text)) return false;
            if (Price <= 0) return false;

            return true;
        }
    }
}
