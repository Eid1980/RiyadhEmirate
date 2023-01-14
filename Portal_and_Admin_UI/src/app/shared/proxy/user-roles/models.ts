
export interface GetRolUsersDto {
  id: number;
  userFullName: string;
  userNationalId: string;
  userPhoneNumber: string;
}

export interface GetUserListDto {
  id: number;
  fullName: string;
  userName: string;
  phoneNumber: string;
  governorateName: string;
}

export interface CreateUserRoleDto {
  userId: number;
  roleId: number;
}

export interface GetUserRoleListDto {
  id: number;
  roleNameAr: number;
  roleNameEn: number;
}
