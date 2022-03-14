using Euromonitor.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Euromonitor.Data
{
    public class Subcription : AuditBase<Guid>
    {
        public Guid BookId { get; set; }
        public int UserId { get; set; }
        public int State { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
