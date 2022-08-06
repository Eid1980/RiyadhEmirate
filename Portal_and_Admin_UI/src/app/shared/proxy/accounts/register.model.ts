
export interface CheckUserRegisterDto {
  nationalId: string;
  birthDate: string;
}

export interface CreateUserDto {
  userName: string;
  birthDate: string;
  passWord: string;
  confirmPassWord: string;

  firstNameAr: string;
  secondNameAr: string;
  thirdNameAr: string;
  lastNameAr: string;

  firstNameEn: string;
  secondNameEn: string;
  thirdNameEn: string;
  lastNameEn: string;

  employeeSide: string;
  childrenCount?: number;
  maritalStatusId?: number;
  jobOccupation: string;

  phoneNumber: string;
  email: string;

  isMale: boolean;
  passportId: string;

  nationalityId?: number;
  governorateId?: number;
  address: string;
}