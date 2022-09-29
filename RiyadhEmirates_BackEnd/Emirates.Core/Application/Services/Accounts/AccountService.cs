﻿using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Accounts;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Common;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using System.Text;

namespace Emirates.Core.Application.Services.Accounts
{
    public class AccountService : BaseService, IAccountService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ICommonService _commonService;
        public AccountService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper,
            ICommonService commonService)
        {
            _mapper = mapper;
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _commonService = commonService;

        }

        public IApiResponse GetUserData(int id)
        {
            var user = _mapper.Map<GetUserDataDto>(_emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == id, x => x.Nationality, x => x.Governorate));
            if (user != null)
                return GetResponse(data: user);
            return GetResponse(isSuccess: false);
        }
        public IApiResponse GetById(int id)
        {
            var user = _mapper.Map<GetUserDto>(_emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == id, x => x.Nationality, x => x.Governorate));
            if (user != null)
                return GetResponse(data: user);
            return GetResponse(isSuccess: false);
        }
        public IApiResponse GetAuthUser(int id)
        {
            var userResponse = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == id, x => x.UserRoles);
            var user = _mapper.Map<GetUserSessionDto>(userResponse);
            if (user == null)
                throw new BusinessException("غير مصرح بالدخول لك بالدخول على النظام");
            user.RoleIds = string.Join(",", userResponse.UserRoles.Select(x => x.RoleId).ToArray());
            return GetResponse(data: user);
        }
        public IApiResponse GetByUserName(string userName)
        {
            var user = _mapper.Map<GetUserDto>(_emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName == userName, x => x.Governorate, x => x.Nationality));
            if (user != null)
                return GetResponse(data: user);
            return GetResponse(isSuccess: false);
        }
        public IApiResponse GetByPhone(string phoneNumber)
        {
            var user = _mapper.Map<GetUserDto>(_emiratesUnitOfWork.Users.FirstOrDefault(u => u.PhoneNumber == phoneNumber));
            if (user != null)
                return GetResponse(data: user);
            return GetResponse(isSuccess: false);
        }
        public IApiResponse UserExist(string userName)
        {
            var isExist = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName.ToString() == userName) != null;
            return GetResponse(data: isExist);
        }
        public IApiResponse Login(UserLoginDto userLoginDto)
        {
            var user = _mapper.Map<GetUserDto>(_emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName == userLoginDto.UserName));
            if(user == null)
                throw new BusinessException("اسم المستخدم غير مضاف على النظام");

            if (!VerifyPasswordHash(userLoginDto.Password, user.PasswordHash, user.PasswordSalt))
                throw new BusinessException("كلمة المرور غير صحيحة");
            return GetResponse(data: user);
        }

        public IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto)
        {
            bool issuccess = false;
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName == forgetPasswordDto.UserName);
            if (user == null)
                throw new BusinessException("اسم المستخدم غير مضاف على النظام");
            try
            {
                // TODO 
                // Validate this email address for the current user or not
                //var user = GetUserByUserName(forgetPasswordModel.UserName);
                if (user != null)
                {
                    // generate token and send it 
                    var token = GenerateToken();
                    // Send Email Address
                    var mailRequest = new MailRequestDto()
                    {
                        ToEmail = user.Email,
                        Subject = "[Edraak]  Please reset your password",
                        Body = @$"Reset your Edraak password
                        <h6> Hello {user.FirstNameAr} {user.LastNameAr} </h6>
                        this is the verification code of edraak {token}",
                        Attachments = null
                    };
                    _commonService.SendEmailAsync(mailRequest).Wait();
                    var updatedUser = user;
                    updatedUser.Last2Factor = token;
                    _emiratesUnitOfWork.Users.Update(user, updatedUser);
                    _emiratesUnitOfWork.Complete();
                    issuccess = true;
                }
            }
            catch (Exception ex)
            {
                // TODO
                // log the exceptions
            }
            return GetResponse(data: issuccess);
        }
        public IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto)
        {
            bool isUpdated = false;
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == updatePasswordDto.UserId);
            if (user == null)
                throw new BusinessException("اسم المستخدم غير مضاف على النظام");

            if (VerifyPasswordHash(updatePasswordDto.OldPassword, user.PasswordHash, user.PasswordSalt))
            {
                var updatedUser = user;
                CreatePasswordHash(updatePasswordDto.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);
                updatedUser.PasswordHash = passwordHash;
                updatedUser.PasswordSalt = passwordSalt;
                _emiratesUnitOfWork.Complete();
                isUpdated = true;
            }
            return GetResponse(data: isUpdated);
        }

        public IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto)
        {
            try
            {
                var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == updateUserProfileDto.Id);
                if (user == null)
                    throw new BusinessException("اسم المستخدم غير مضاف على النظام");

                if (!string.IsNullOrEmpty(updateUserProfileDto.NewPassWord) && !string.IsNullOrEmpty(updateUserProfileDto.ConfirmNewPassWord))
                {
                    CreatePasswordHash(updateUserProfileDto.NewPassWord, out byte[] passwordHash, out byte[] passwordSalt);
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                }

                user.FirstNameAr = updateUserProfileDto.FirstNameAr;
                user.FirstNameEn = updateUserProfileDto.FirstNameEn;
                user.SecondNameAr = updateUserProfileDto.SecondNameAr;
                user.SecondNameEn = updateUserProfileDto.SecondNameEn;
                user.ThirdNameAr = updateUserProfileDto.ThirdNameAr;
                user.ThirdNameEn = updateUserProfileDto.ThirdNameEn;

                user.PhoneNumber = updateUserProfileDto.PhoneNumber;
                user.Email = updateUserProfileDto.Email;
                user.IsMale = updateUserProfileDto.IsMale;
                user.NationalityId = updateUserProfileDto.NationalityId;
                user.GovernorateId = updateUserProfileDto.GovernorateId;
                user.IdentityExpireDate = updateUserProfileDto.IdentityExpireDate;

                user.Address = updateUserProfileDto.Address;

                _emiratesUnitOfWork.Complete();

                return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateUserProfileDto.Id);
            }
            catch (Exception ex)
            {
                return GetResponse(message: CustumMessages.UpdateRequestFailed(), data: updateUserProfileDto.Id);
            }
        }

        public IApiResponse GetUserProfileData(int id) 
        {
            var userProfile = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == id, x => x.Nationality, x => x.Governorate);
            if (userProfile == null)
                return GetResponse(isSuccess: false);
            else
            {
                var response = new UserProfileDto
                {
                    Id = userProfile.Id,
                    FirstNameAr = userProfile.FirstNameAr,
                    SecondNameAr = userProfile.SecondNameAr,
                    ThirdNameAr = userProfile.ThirdNameAr,
                    LastNameAr = userProfile.LastNameAr,
                    FirstNameEn = userProfile.FirstNameEn,
                    SecondNameEn = userProfile.SecondNameEn,
                    ThirdNameEn = userProfile.ThirdNameEn,
                    LastNameEn = userProfile.LastNameEn,
                    IsMale = userProfile.IsMale,
                    BirthDate = userProfile.BirthDate.ToString("yyyy-MM-dd"),
                    Email = userProfile.Email,
                    PhoneNumber = userProfile.PhoneNumber,
                    PassportId = userProfile.PassportId,
                    NationalityId = userProfile.NationalityId,
                    NationalityName = userProfile.Nationality == null ? "" : userProfile.Nationality.NameAr,
                    GovernorateId = userProfile.GovernorateId,
                    GovernorateName = userProfile.Governorate == null ? "" : userProfile.Governorate.NameAr,
                    Address = userProfile.Address
                };
                return GetResponse(data: response);
            }
        }

        public IApiResponse ValidateOTP(ValidateOTPDto validateOTPDto)
        {
            bool isValid = false;
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName == validateOTPDto.UserName);
            if (user != null)
                isValid = validateOTPDto.OTP == user.Last2Factor;
            return GetResponse(data: isValid);
        }
        public IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            bool isReseted = false;
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName == resetPasswordDto.UserName);
            if (user == null)
                throw new BusinessException("اسم المستخدم غير مضاف على النظام");
            try
            {
                var updatedUser = user;
                CreatePasswordHash(resetPasswordDto.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);
                updatedUser.PasswordHash = passwordHash;
                updatedUser.PasswordSalt = passwordSalt;
                _emiratesUnitOfWork.Users.Update(user, updatedUser);
                _emiratesUnitOfWork.Complete();
                isReseted = true;
            }
            catch (Exception ex)
            {
            }
            return GetResponse(data: isReseted);
        }

        public IApiResponse CheckUserRegister(CheckUserRegisterDto checkUserRegisterDto)
        {
            if (_emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName.Equals(checkUserRegisterDto.NationalId)) != null)
                throw new BusinessException("اسم المستخدم مضاف مسبقا");
            // Nic check
            var nicUser = new CreateUserDto
            {
                UserName = checkUserRegisterDto.NationalId,
                BirthDate = checkUserRegisterDto.BirthDate,
                FirstNameAr = "محمد",
                SecondNameAr = "احمد",
                ThirdNameAr = "علي",
                LastNameAr = "الجوهري",
                FirstNameEn = "Mohamed",
                SecondNameEn = "Ahmad",
                ThirdNameEn = "Ali",
                LastNameEn = "Algohary",
                IsMale = true
            };
            return GetResponse(data: nicUser);
        }
        public IApiResponse Register(CreateUserDto createUserDto)
        {
            if (_emiratesUnitOfWork.Users.FirstOrDefault(u => u.UserName.Equals(createUserDto.UserName)) != null)
                throw new BusinessException("اسم المستخدم مضاف مسبقا");

            var addedModel = _mapper.Map<User>(createUserDto);
            CreatePasswordHash(createUserDto.PassWord, out byte[] passwordHash, out byte[] passwordSalt);
            addedModel.PasswordHash = passwordHash;
            addedModel.PasswordSalt = passwordSalt;
            addedModel.IsActive = true;
            addedModel.IsEmployee = false;
            addedModel.LastLoginDate = DateTime.Now;

            _emiratesUnitOfWork.Users.Add(addedModel);
            _emiratesUnitOfWork.Complete();

            return GetResponse(message: CustumMessages.MsgSuccess("تم التسجيل بنجاح"), data: addedModel.Id);
        }
        public IApiResponse CreateEmployee(int userId)
        {
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new BusinessException("رقم الهوية غير مسجل بالنظام برجاء التسجيل أولا");
            if(user.IsEmployee)
                throw new BusinessException("المستخدم مضاف مسبقا");

            user.IsEmployee = true;
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess());
        }
        public IApiResponse DeleteEmployee(int userId)
        {
            var user = _emiratesUnitOfWork.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new BusinessException("رقم الهوية غير مسجل بالنظام برجاء التسجيل أولا");
            if (!user.IsEmployee)
                throw new BusinessException("المستخدم محذوف مسبقا");

            user.IsEmployee = false;
            var userRoles = _emiratesUnitOfWork.UserRoles.Where(x => x.UserId == userId).ToList();
            if (userRoles.Any())
                _emiratesUnitOfWork.UserRoles.RemoveRange(userRoles);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        #region Helper Functions
        private string GenerateToken()
        {
            Random rd = new Random();
            return DateTime.Now.ToString("yy-MM-dd-mm").Replace("-", "") + rd.Next(100, 200).ToString();
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }


        #endregion

    }
}
