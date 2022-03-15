using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Data;
using Euromonitor.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euromonitor.BusinessObjects.Logic
{
    public class UserLogic : IUserLogic
    {
        private EuromonitorDbContext EuromonitorDbContext { get; set; }
        private UserManager<ApplicationUser> userManager { get; set; }
        public UserLogic(EuromonitorDbContext _euromonitorDbContext, UserManager<ApplicationUser> _userManager)
        {
            this.EuromonitorDbContext = _euromonitorDbContext;
            this.userManager = _userManager;
        }

        public ApplicationUser GetUser(int userId)
        {
            return EuromonitorDbContext.Users.Where(s => s.Id == userId).FirstOrDefault();
        }

        public ApplicationUser UpdateUser(int userId, ApplicationUser user)
        {
            if (user.Id == userId)
            {
                EuromonitorDbContext.Users.Update(user);
                EuromonitorDbContext.SaveChanges();
            }
            return user;
        }

        public async Task<ApplicationUser> Login(string username, string password)
        {
            var user = EuromonitorDbContext.Users.Where(s => s.UserName.Trim().ToLower() == username.Trim().ToLower() || s.Email.Trim().ToLower() == username.Trim().ToLower()).FirstOrDefault();
            if (user == null) return null;
            var valid = (await userManager.PasswordValidators.FirstOrDefault().ValidateAsync(userManager, user, password)).Succeeded;
            return user;
        }
        public async Task<ApplicationUser> Register(ApplicationUser user, string password)
        {

            EuromonitorDbContext.Users.Add(user);
            EuromonitorDbContext.SaveChanges();
            var result = await userManager.AddPasswordAsync(user, password);

            return user;
        }
    }
}
