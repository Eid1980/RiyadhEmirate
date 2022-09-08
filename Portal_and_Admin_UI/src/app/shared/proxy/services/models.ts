
export interface CreateServiceDto {
  nameAr: string;
  nameEn: string;
  sectorAr: string;
  sectorEn: string;
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
  sectorAr: string;
  sectorEn: string;
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
  sectorAr: string;
  sectorEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays?: number;
  isActive: boolean;
  isExternal: boolean;
  image: any;
}

export interface GetServiceListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  sectorAr: string;
  sectorEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays?: number;
  isActive: boolean;
  createdDate: string;
  image: any;
}
