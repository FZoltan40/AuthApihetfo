using AuthApi.Models;
using AuthApi.Models.Dtos;
using AuthApi.Services.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Services
{
    public class AuthService : IAuth
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AuthService(AppDbContext appDbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _appDbContext = appDbContext;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public Task<object> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<object> Register(RegisterRequestDto registerRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registerRequestDto.UserName,
                NormalizedUserName = registerRequestDto.UserName.ToUpper(),
                FullName = registerRequestDto.FullName,
                Email = registerRequestDto.Email

            };

            var result = await userManager.CreateAsync(user, registerRequestDto.Password);

            if (result.Succeeded)
            {
                var userToReturn = await _appDbContext.applicationUsers.FirstOrDefaultAsync(user => user.UserName == registerRequestDto.UserName);


                var UserResponse = new
                {
                    id = userToReturn.Id,
                    email = userToReturn.Email,
                    userName = userToReturn.UserName,
                    fullName = userToReturn.FullName,


                };

                return new { result = UserResponse, message = "Sikeres regisztráció." };
            }

            return result.Errors.FirstOrDefault().Description;
        }
    }
}
