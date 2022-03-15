using Euromonitor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Euromonitor.BusinessObjects.Interfaces
{
    public interface IUserLogic
    {
        public ApplicationUser GetUser(int userId);
        public ApplicationUser UpdateUser(int userId, ApplicationUser user);
        public Task<ApplicationUser> Login(string username, string password);
        public Task<ApplicationUser> Register(ApplicationUser user, string password);

    }
}
