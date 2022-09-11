
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
  workDays: string;
  isActive: boolean;
  createdDate: string;
  image: any;
}


