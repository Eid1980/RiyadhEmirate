using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Accounts;
using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Accounts
{
    public interface IAccountService
    {
        IApiResponse GetGetUserDataDto(int id);
        IApiResponse GetById(int id);
        IApiResponse GetByUserName(string userName);
        IApiResponse GetByPhone(string phoneNumber);
        IApiResponse UserExist(string userName);
        IApiResponse Login(UserLoginDto userLoginDto);

        IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto);
        IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto);
        IApiResponse ValidateOTP(ValidateOTPDto validateOTPDto);
        IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto);
        IApiResponse CheckUserRegister(CheckUserRegisterDto checkUserRegisterDto);
        IApiResponse Register(CreateUserDto createUserDto);
        IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto);

    }
}
