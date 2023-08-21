using Microsoft.AspNetCore.Mvc;
using Moodiverse.BL.Services;
using Moodiverse.Common.DTO.UserDTO;

namespace Moodiverse.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly AuthService _authService;

        public RegisterController(UserService userService, AuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }
        [HttpPost]
        public async Task<ActionResult<AuthUserDto>> RegisterUser(RegisterUserDto userDto)
        {
            var createdUser = await _userService.CreateUser(userDto);
            var token = await _authService.GenerateAccessToken(createdUser.Id, createdUser.Username, createdUser.Email);

            var result = new AuthUserDto()
            {
                User = createdUser,
                Token = token
            };

            return Ok(result);
        }
    }
}
