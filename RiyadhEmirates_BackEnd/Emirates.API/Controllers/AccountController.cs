using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Emirates.Core.Application.Services.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Emirates.Core.Application.Services.Accounts;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Shared;
using Emirates.Core.Application.Dtos.Accounts;
using Emirates.API.Filters;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public AccountController(IAccountService accountService, IConfiguration config,
            ILocalizationService localizationService) : base(localizationService)
        {
            _accountService = accountService;
            _config = config;
        }

        [Authorize, HttpGet("GetUserData/{id?}")]
        public IApiResponse GetUserData(int id=0)
        {
            if (id == 0)
                id = UserId;
            return _accountService.GetUserData(id);
        }
        [Authorize, HttpGet("GetCurrentUserRoles")]
        public IApiResponse GetCurrentUserRoles()
        {
            return _accountService.GetCurrentUserRoles(UserId);
        }

        [Authorize, HttpGet("GetAuthUser")]
        public IApiResponse GetAuthUser()
        {
            return _accountService.GetAuthUser(UserId);
        }

        [Authorize, HttpGet("GetById/{id}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetById(int id)
        {
            return _accountService.GetById(id);
        }

        [Authorize, HttpGet("GetByUserName/{userName}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetByUserName(string userName)
        {
            return _accountService.GetByUserName(userName);
        }
        [Authorize, HttpGet("GetByPhone/{phoneNumber}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse GetByPhone(string phoneNumber)
        {
            return _accountService.GetByPhone(phoneNumber);
        }

        [Authorize, HttpGet("UserExist/{userName}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
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
                    new Claim("UserId",user.Id.ToString())
                   }),
                    Expires = DateTime.UtcNow.AddHours(24),
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
                    IsSuccess = false,
                    Message = CustumMessages.MsgWarning("رجاء التأكد من صحة البيانات المدخلة")
                };
            return _accountService.Register(createUserDto);
        }

        [Authorize, HttpPost("UpdateUserProfile")]
        public IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto)
        {
            return _accountService.UpdateUserProfile(updateUserProfileDto);
        }

        [Authorize, HttpGet("GetUserProfileData/{id}")]
        public IApiResponse GetUserProfileData(int id)
        {
            return _accountService.GetUserProfileData(id);
        }
        
        [HttpGet("CreateEmployee/{userId}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse CreateEmployee(int userId)
        {
            return _accountService.CreateEmployee(userId);
        }
        
        [HttpGet("DeleteEmployee/{userId}")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.UsersPermission)]
        public IApiResponse DeleteEmployee(int userId)
        {
            return _accountService.DeleteEmployee(userId);
        }

        [HttpGet("IsSuperAdmin")]
        public bool IsSuperAdmin()
        {
            return _accountService.IsUserInRoles(UserId, new int[] { (int)SystemEnums.Roles.SuperSystemAdmin });
        }

        [HttpPost("CheckIamUser")]
        public IApiResponse CheckIamUser(CheckIamUserRequestDto checkIamUserDto)
        {
            var response = _accountService.CheckIamUser(checkIamUserDto);
            var responseData = (CheckIamUserDto)response.Data;
            if (responseData.IamLoginResponse == (int)SystemEnums.IamLoginResponse.Success)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:TokenSigningKey").Value);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId",responseData.UserId.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddHours(24),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                responseData.TokenHandler = tokenHandler.WriteToken(token);
                response.Data = responseData;
            }
            return response;
        }

        [HttpPost("CompleteUserData")]
        public IApiResponse CompleteUserData(CompleteDataDto completeDataDto)
        {
            var response = _accountService.CompleteUserData(completeDataDto);
            var responseData = (CheckIamUserDto)response.Data;
            if (responseData.IamLoginResponse == (int)SystemEnums.IamLoginResponse.Success)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:TokenSigningKey").Value);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId",responseData.UserId.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddHours(24),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                responseData.TokenHandler = tokenHandler.WriteToken(token);
                response.Data = responseData;
            }
            return response;
        }

    }
}
