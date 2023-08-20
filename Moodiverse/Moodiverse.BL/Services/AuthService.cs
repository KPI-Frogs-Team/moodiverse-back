using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moodiverse.BL.JWT;
using Moodiverse.BL.Services.Abstract;
using Moodiverse.Common.DTO.UserDTO;
using Moodiverse.Common.Security;
using Moodiverse.DAL.Context;

namespace Moodiverse.BL.Services;

public class AuthService : BaseService
{
    private readonly JwtFactory _jwtFactory;

    public AuthService(MoodiverseDbContext context, IMapper mapper, JwtFactory jwtFactory) : base(context, mapper)
    {
        _jwtFactory = jwtFactory;
    }

    public async Task<AuthUserDto> Authorize(LoginUserDto userDto)
    {
        var userEntity = await _context.Users.FirstOrDefaultAsync(u => u.Username == userDto.Username);
        if (userEntity == null)
        {
            // special not found exception
            throw new Exception();
        }

        if (!SecurityHelper.ValidatePassword(userDto.Password, userEntity.Password, userEntity.Salt))
        {
            // special invalid username or password exception
            throw new Exception();
        }

        var token = await GenerateAccessToken(userEntity.Id, userEntity.Username, userEntity.Email);
        var user = _mapper.Map<UserDto>(userEntity);
        return new AuthUserDto
        {
            User = user,
            Token = token
        };
    }

    public async Task<TokenDto> GenerateAccessToken(int userId, string username, string email)
    {
        var refreshToken = _jwtFactory.GenerateRefreshToken();

        var accessToken = await _jwtFactory.GenerateAccessToken(userId, username, email);

        return new TokenDto
        {
            RefreshToken = refreshToken,
            AccessToken = accessToken
        };
    }
}