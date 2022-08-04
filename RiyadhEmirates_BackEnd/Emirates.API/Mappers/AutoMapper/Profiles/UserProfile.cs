using AutoMapper;
using Emirates.API.Dtos.Security.Request;
using Emirates.Core.Application.Models.Request.User;

namespace Emirates.API.Mappers.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, CreateUserModel>();
        }
    }
}
