
export interface GetUserDto {
  id: number;
  nameAr: string;
  nameEn: string;

  employeeSide: string;
  childrenCount: number;
  maritalStatusName: string;
  jobOccupation: string;

  nationalId: string;
  genderName: string;
  address: string;
  email: string;
  phoneNumber: string;

  nationalityName: string;
  governorateName: string;

  passwordHash: [];
  passwordSalt: [];
  isAdmin: boolean;
  isActive: boolean;
  userName: string;
  oTP: string;
  birthDate: string;
}


export interface UserLoginDto {
  userName: string;
  password: string;
}

export interface ForgetPasswordDto {
  userName: string;
  token: string;
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


