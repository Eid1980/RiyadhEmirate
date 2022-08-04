
export interface CreateCaseTypeDto {
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface UpdateCaseTypeDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetCaseTypeDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetCaseTypeListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}
