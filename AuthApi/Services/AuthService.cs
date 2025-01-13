using AuthApi.Models;
using AuthApi.Models.Dtos;
using AuthApi.Services.IService;

namespace AuthApi.Services
{
    public class AuthService : IAuth
    {
        private readonly AppDbContext _appDbContext;

        public AuthService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<object> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<object> Register(RegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
