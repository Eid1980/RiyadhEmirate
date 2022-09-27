
export interface GetUserDto {
  id: number;
  userName: string;

  nameAr: string;
  shortNameAr: string;
  nameEn: string;
  shortNameEn: string;

  nationalId: string;
  genderName: string;
  address: string;
  email: string;
  phoneNumber: string;

  nationalityName: string;
  governorateName: string;

  passwordHash: [];
  passwordSalt: [];
  isEmployee: boolean;
  isActive: boolean;
  oTP: string;
  birthDate: string;
}

export interface GetUserProfileData {
  id: number;
  firstNameAr: string;
  secondNameAr: string;
  thirdNameAr: string;
  lastNameAr: string;
  firstNameEn: string;
  secondNameEn: string;
  thirdNameEn: string;
  lastNameEn: string;
  isMale: boolean;
  birthDate: string;
  email: string;
  phoneNumber: string;
  passportId: string;
  nationalityId: number;
  nationalityName: string;
  governorateId: number;
  governorateName: string;
  address: string;
}

export interface GetUserSessionDto {
  id: number;
  shortName: string;
  isEmployee: boolean;
}

export interface GetUserDataDto {
  id: number;
  userName: string;
  name: string;

  genderName: string;
  birthDate: string;
  phoneNumber: string;

  nationalityName: string;
  governorateName: string;
  email: string;
}

export interface UpdateUserProfileDto {
  id: number;

  newPassWord: string;

  ConfirmNewPassWord: string;

  firstNameAr: string;
  secondNameAr: string;
  thirdNameAr: string;
  lastNameAr: string

  firstNameEn: string
  secondNameEn: string
  thirdNameEn: string
  lastNameEn: string

  isMale: boolean;
  email: string;
  phoneNumber: string;


  nationalityId: number;
  governorateId: number;
  identityExpireDate: string
  address: string
}

export interface UserLoginDto {
  userName: string;
  password: string;
}

export interface ForgetPasswordDto {
  userName: string;
}

export interface ResetPasswordDto {
  userName: string;
  newPassword: string;
}

export interface UpdatePasswordDto {
  userId: number;
  oldPassword: string;
  newPassword: string;
}

export interface ValidateOTPDto {
  userName: string;
  oTP: string;
}


