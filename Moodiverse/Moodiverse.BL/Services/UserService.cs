using AutoMapper;
using Moodiverse.BL.Services.Abstract;
using Moodiverse.Common.DTO.UserDTO;
using Moodiverse.Common.Security;
using Moodiverse.DAL.Context;
using Moodiverse.DAL.Entities;

namespace Moodiverse.BL.Services;

public class UserService: BaseService
{
    public UserService(MoodiverseDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
    public async Task<UserDto> CreateUser(RegisterUserDto userDto)
    {
        var userEntity = _mapper.Map<User>(userDto);
        var salt = SecurityHelper.GetRandomBytes();

        userEntity.Salt = Convert.ToBase64String(salt);
        userEntity.Password = SecurityHelper.HashPassword(userDto.Password, salt);
        userEntity.AvatarId = null;
        
        _context.Users.Add(userEntity);
        await _context.SaveChangesAsync();

        return _mapper.Map<UserDto>(userEntity);
    }
}