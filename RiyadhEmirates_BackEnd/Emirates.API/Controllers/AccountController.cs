using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Emirates.Core.Application.Services.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Accounts;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Dtos.Accounts;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : BaseController, IAccountService
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public AccountController(IAccountService accountService, IConfiguration config,
            ILocalizationService localizationService) : base(localizationService)
        {
            _accountService = accountService;
            _config = config;
        }

        [HttpGet("GetGetUserDataDto/{id?}")]
        [Authorize]
        public IApiResponse GetGetUserDataDto(int id=0)
        {
            if (id == 0)
                id = UserId;

            return _accountService.GetGetUserDataDto(id);
        }

        [HttpGet("GetAuthUser")]
        [Authorize]
        public IApiResponse GetAuthUser()
        {
            var user = _accountService.GetById(UserId);
            if (!user.IsSuccess)
                throw new BusinessException("غير مصرح بالدخول لك بالدخول على النظام");
            return user;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _accountService.GetById(id);
        }

        [HttpGet("GetByUserName/{userName}")]
        public IApiResponse GetByUserName(string userName)
        {
            return _accountService.GetByUserName(userName);
        }
        [HttpGet("GetByPhone/{phoneNumber}")]
        public IApiResponse GetByPhone(string phoneNumber)
        {
            return _accountService.GetByPhone(phoneNumber);
        }

        [HttpGet("UserExist/{userName}")]
        public IApiResponse UserExist(string userName)
        {
            return _accountService.UserExist(userName);
        }

        [HttpPost]
        [Route("Login")]
        public IApiResponse Login(UserLoginDto userLoginDto)
        {
            var userResponse = _accountService.Login(userLoginDto);
            if (userResponse.IsSuccess)
            {
                var user = (GetUserDto)userResponse.Data;
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:TokenSigningKey").Value);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim("UserId",user.Id.ToString()),
                    new Claim("Name", user.NameAr.ToString()),
                    new Claim("Phone",user.PhoneNumber.ToString())
                   }),

                    Expires = DateTime.UtcNow.AddDays(360),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                userResponse.Data = tokenHandler.WriteToken(token);
            }
            return userResponse;
        }

        [HttpPost]
        [Route("ForgetPassword")]
        public IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto)
        {
            return _accountService.ForgetPassword(forgetPasswordDto);
        }

        [HttpPost]
        [Route("ResetPassword")]
        public IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            return _accountService.ResetPassword(resetPasswordDto);
        }

        [HttpPost]
        [Route("UpdatePassword")]
        public IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto)
        {
            updatePasswordDto.UserId = UserId;
            return _accountService.UpdatePassword(updatePasswordDto);
        }

        [HttpPost("ValidateOTP")]
        public IApiResponse ValidateOTP(ValidateOTPDto validateOTPDto)
        {
            return _accountService.ValidateOTP(validateOTPDto);
        }


        [HttpPost("CheckUserRegister")]
        public IApiResponse CheckUserRegister(CheckUserRegisterDto checkUserRegisterDto)
        {
            return _accountService.CheckUserRegister(checkUserRegisterDto);
        }

        [HttpPost("Register")]
        public IApiResponse Register(CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
                return new ApiResponse
                {
                    IsSuccess=false,
                    Message = CustumMessages.MsgWarning("رجاء التأكد من صحة البيانات المدخلة")
                };
            return _accountService.Register(createUserDto);
        }

        //[Authorize]
        [HttpPost("UpdateUserProfile")]
        public IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto)
        {
            return _accountService.UpdateUserProfile(updateUserProfileDto);
        }

        [HttpGet("GetUserProfileData/{id}")]
        public IApiResponse GetUserProfileData(int id)
        {
            return _accountService.GetUserProfileData(id);
        }
    }
}
