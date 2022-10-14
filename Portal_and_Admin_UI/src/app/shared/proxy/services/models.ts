
export interface CreateServiceDto {
  nameAr: string;
  nameEn: string;
  sectorAr: string;
  sectorEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays: string;
  cost?: number;
  imageName: string;
  isActive: boolean;
  isExternal: boolean;
}

export interface UpdateServiceDto {
  id: number;
  nameAr: string;
  nameEn: string;
  sectorAr: string;
  sectorEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  workDays: string;
  cost?: number;
  imageName: string;
  isActive: boolean;
  isExternal: boolean;
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
  workDays: string;
  serviceCost?: number;
  imageName: string;
  isActive: boolean;
  isExternal: boolean;
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
  workDays: string;
  imageName: string;
  isActive: boolean;
  isExternal: boolean;
  createdDate: string;
}


