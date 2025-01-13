using AuthApi.Models.Dtos;
using AuthApi.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;

        public AuthController(IAuth auth)
        {
            this.auth = auth;
        }

        [HttpPost("login")]
        public async Task<ActionResult> LoginPost(LoginRequestDto loginRequestDto)
        {
            return Ok();
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterPost(RegisterRequestDto registerRequestDto)
        {
            return Ok();
        }

    }
}
