using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Accounts;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Accounts
{
    public interface IAccountService
    {
        IApiResponse GetUserData(int id);
        IApiResponse GetCurrentUserRoles(int id);
        IApiResponse GetById(int id);
        IApiResponse GetAuthUser(int id);
        IApiResponse GetByUserName(string userName);
        IApiResponse GetByPhone(string phoneNumber);
        IApiResponse UserExist(string userName);
        IApiResponse Login(UserLoginDto userLoginDto);

        IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto);
        IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto);
        IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto);
        IApiResponse CheckUserRegister(CheckUserRegisterDto checkUserRegisterDto);
        IApiResponse Register(CreateUserDto createUserDto);
        IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto);

        IApiResponse GetUserProfileData(int id);
        IApiResponse CreateEmployee(int userId);
        IApiResponse DeleteEmployee(int userId);
        bool IsUserInRoles(int userId, int[] roles);
        IApiResponse CheckIamUser(CheckIamUserRequestDto checkIamUserDto);
        IApiResponse CompleteUserData(CompleteDataDto completeDataDto);
    }
}
