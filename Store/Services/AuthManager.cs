using AutoMapper;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Services.Contracts;

namespace Services
{
    public class AuthManager : IAuthService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        public AuthManager(RoleManager<IdentityRole> roleManager,
        UserManager<IdentityUser> userManager,
        IMapper mapper)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IEnumerable<IdentityRole> Roles =>
            _roleManager.Roles;

        public async Task<IdentityResult> CreateUser(UserDtoForCreation userDto)
        {
            var user = _mapper.Map<IdentityUser>(userDto);
            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (!result.Succeeded)
                throw new Exception("User could not be created.");

            if (userDto.Roles.Count > 0)
            {
                var roleResult = await _userManager.AddToRolesAsync(user, userDto.Roles);
                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with roles.");
            }

            return result;
        }

        public async Task<IdentityResult> DeleteOneUser(string userName)
        {
            var user = await GetOneUser(userName);
            return await _userManager.DeleteAsync(user);
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return _userManager.Users.ToList();
        }

        public async Task<IdentityUser> GetOneUser(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user is not null)
                return user;
            throw new Exception("User could not be found.");
        }

        public async Task<UserDtoForUpdate> GetOneUserForUpdate(string userName)
        {
            var user = await GetOneUser(userName);
            var userDto = _mapper.Map<UserDtoForUpdate>(user);
            userDto.Roles = new HashSet<string>(Roles.Select(r => r.Name).ToList());
            userDto.UserRoles = new HashSet<string>(await _userManager.GetRolesAsync(user));
            return userDto;
        }

        public async Task<IdentityResult> ResetPassword(ResetPasswordDto model)
        {
            var user = await GetOneUser(model.UserName);
            await _userManager.RemovePasswordAsync(user);
            var result = await _userManager.AddPasswordAsync(user, model.Password);
            return result;
        }

        public async Task Update(UserDtoForUpdate userDto)
        {
            var user = await GetOneUser(userDto.UserName);
            user.PhoneNumber = userDto.PhoneNumber;
            user.Email = userDto.Email;
            var result = await _userManager.UpdateAsync(user);
            if (userDto.Roles.Count > 0)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var r1 = await _userManager.RemoveFromRolesAsync(user, userRoles);
                var r2 = await _userManager.AddToRolesAsync(user, userDto.Roles);
            }
            return;
        }
    }
}