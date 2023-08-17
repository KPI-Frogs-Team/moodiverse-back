using AutoMapper;
using Moodiverse.Common.DTO.AvatarDTO;
using Moodiverse.Common.DTO.MoodDTO;
using Moodiverse.Common.DTO.RecordDTO;
using Moodiverse.Common.DTO.SexDTO;
using Moodiverse.Common.DTO.UserDTO;
using Moodiverse.DAL.Entities;

namespace Moodiverse.BL.MappingProfiles;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Avatar, AvatarDto>().ReverseMap();

        CreateMap<Mood, MoodDto>().ReverseMap();

        CreateMap<Record, CreateRecordDto>().ReverseMap();
        CreateMap<Record, DeleteRecordDto>().ReverseMap();
        CreateMap<Record, GetRecordDto>().ReverseMap();
        CreateMap<Record, RecordRoundStatisticsResponseDto>().ReverseMap();
        CreateMap<Record, RecordStatisticsRequestDto>().ReverseMap();
        CreateMap<Record, RecordTabularStatisticsDto>().ReverseMap();
        CreateMap<Record, UpdateRecordDto>().ReverseMap();

        CreateMap<Sex, SexDto>().ReverseMap();

        CreateMap<User, DeleteUserDto>().ReverseMap();
        CreateMap<User, LoginUserDto>().ReverseMap();
        CreateMap<User, RegisterUserDto>().ReverseMap();
        CreateMap<User, UpdateUserDto>().ReverseMap();
        CreateMap<User, UpdateUserEmailDto>().ReverseMap();
        CreateMap<User, UpdateUserPassDto>().ReverseMap();
        CreateMap<User, UserDataDto>().ReverseMap();
    }
}