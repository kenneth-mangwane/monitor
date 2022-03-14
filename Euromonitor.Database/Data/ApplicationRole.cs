using Euromonitor.Common.Utilities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Euromonitor.Data
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }

        [Column(TypeName = "VARCHAR(512)")]
        public string Description { get; set; }

        public Boolean IsDeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

    
        public virtual ICollection<ApplicationUserRole> Users { get; set; }
        public virtual ICollection<ApplicationRoleClaim> Claims { get; set; }

    }

    
}
