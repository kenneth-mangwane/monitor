using Audit.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;

namespace Euromonitor.Data
{


    public class EuromonitorDbContext : AuditIdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, IdentityUserToken<int>>
    {
        public IHttpContextAccessor ContextAccessor;

        public EuromonitorDbContext(DbContextOptions<EuromonitorDbContext> options, IHttpContextAccessor contextAccessor = null)
            : base(options)
        {
            ContextAccessor = contextAccessor;
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Subscription> Subcriptions { get; set; }
    }
}
