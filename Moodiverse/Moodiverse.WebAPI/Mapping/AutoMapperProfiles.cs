using AutoMapper;
using Moodiverse.WebAPI.Models.Domain;
using Moodiverse.WebAPI.Models.DTO.AvatarDTO;
using Moodiverse.WebAPI.Models.DTO.MoodDTO;
using Moodiverse.WebAPI.Models.DTO.RecordDTO;
using Moodiverse.WebAPI.Models.DTO.SexDTO;
using Moodiverse.WebAPI.Models.DTO.UserDTO;

namespace Moodiverse.WebAPI.Mapping;

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