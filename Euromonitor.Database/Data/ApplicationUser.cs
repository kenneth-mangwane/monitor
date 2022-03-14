using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Euromonitor.Data
{
    public class ApplicationUser : IdentityUser<int>
    {
        
        public Boolean IsDeleted { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastSyncDate { get; set; }
       
        public virtual ICollection<ApplicationUserRole> Roles { get; set; }

        public virtual ICollection<ApplicationRoleClaim> Claims { get; set; }

        public virtual ICollection<ApplicationUserLogin> Logins { get; } = new List<ApplicationUserLogin>();



    }
 
}
