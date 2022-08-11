
export interface CreateServiceDto {
  nameAr: string;
  nameEn: string;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays?: number;
  isActive: boolean;
}

export interface UpdateServiceDto {
  id: number;
  nameAr: string;
  nameEn: string;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  workDays?: number;
  requestLink: string;
  isActive: boolean;
}

export interface GetServiceDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays?: number;
  isActive: boolean;
  image: any;
}

export interface GetServiceListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays?: number;
  isActive: boolean;
  createdDate: string;
  image: any;
}
