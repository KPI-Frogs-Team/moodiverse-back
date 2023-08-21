using Microsoft.AspNetCore.Mvc;
using Moodiverse.BL.Services;
using Moodiverse.Common.DTO.UserDTO;

namespace Moodiverse.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController: ControllerBase
  {
      private readonly AuthService _authService;
  
      public AuthController(AuthService authService)
      {
          _authService = authService;
      }
      
      [HttpPost("login")]
      public async Task<ActionResult<AuthUserDto>> Login(LoginUserDto dto)
      {
          return Ok(await _authService.Authorize(dto));
      }
  }  
}
