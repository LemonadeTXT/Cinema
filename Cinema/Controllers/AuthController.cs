using Cinema.Application.Interfaces.Services;
using Cinema.Common.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/login")]
        public async Task<ActionResult<string>> Login([FromBody] AuthUser authUser)
        {
            var token = await _userService.Login(authUser);

            HttpContext.Response.Cookies.Append("crack", token);

            return Ok(token);
        }

        [HttpPost("/register")]
        public async Task<ActionResult<Guid>> Register([FromBody] AuthUser authUser)
        {
            var id = await _userService.Create(authUser);

            return Ok(id);
        }
    }
}
