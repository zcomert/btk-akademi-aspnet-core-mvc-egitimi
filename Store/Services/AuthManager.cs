using Microsoft.AspNetCore.Identity;
using Services.Contracts;

namespace Services
{
    public class AuthManager : IAuthService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthManager(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IEnumerable<IdentityRole> Roles => 
            _roleManager.Roles;
    }
}