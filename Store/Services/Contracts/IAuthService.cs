using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles {get; }
        Task<IdentityResult> CreateUser(RegisterDto userDto);
        Task<IEnumerable<IdentityUser>> GetAllUsers();
        Task<IdentityUser> GetUser(string username);
        Task Update();
    }
}