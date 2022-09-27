
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


