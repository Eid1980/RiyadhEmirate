using AutoMapper;
using Emirates.API.Extensions.Dtos.Request.Authentication;
using Emirates.Core.Application.Models.Request.Authenticattion;

namespace Emirates.API.Mappers.AutoMapper.Profiles
{
    public class AuthenticationProfile : Profile
    {
        public AuthenticationProfile()
        {
            CreateMap<UpdatePasswordRequestDTO, UpdatePasswordRequestModel>();

            CreateMap<ForgetPasswordRequestDTO, ForgetPasswordRequestModel>();

            CreateMap<ResetPasswordRequestDTO, ForgetPasswordRequestModel>();

            CreateMap<ValidateOTPRequestDTO, ValidateOTPModel>();

            CreateMap<ResetPasswordRequestDTO, ResetPasswordDto>();
        }
    }
}
