using System;
using System.ComponentModel.DataAnnotations;

namespace Euromonitor.Common
{
    public abstract class AuditBase<T>
    {
        [Key]
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        protected AuditBase()
        {
            this.DateCreated = DateTime.Now;
            this.DateModified = DateTime.Now;
        }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateModified { get; set; }
    }
}
