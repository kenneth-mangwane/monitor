using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Euromonitor.Data
{

    //<TRole, TContext, TKey, TUserRole, TRoleClaim> 
    public class ApplicationRoleStore :  RoleStore<ApplicationRole, EuromonitorDbContext, int, ApplicationUserRole, ApplicationRoleClaim>
    {
        public ApplicationRoleStore(EuromonitorDbContext context) : base(context) { }
    }
}
