
export interface CreatePrisonDto {
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface UpdatePrisonDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetPrisonDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetPrisonListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}
