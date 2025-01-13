using AuthApi.Models;
using AuthApi.Services.IService;

namespace AuthApi.Services
{
    public class TokenGenarator : ITokenGenerator
    {
        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}
