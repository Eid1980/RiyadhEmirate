
export interface CreateGovernorateDto {
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  phoneNumber: string;
  locationLink: string;
  portalLink: string;
  imageName: string;
  isActive: boolean;

  image: any;
}

export interface UpdateGovernorateDto {
  id: number;
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  phoneNumber: string;
  locationLink: string;
  portalLink: string;
  imageName: string;
  isActive: boolean;

  image: any;
}

export interface GetGovernorateDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  phoneNumber: string;
  locationLink: string;
  portalLink: string;
  imageName: string;
  isActive: boolean;
}

export interface GetGovernorateListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  phoneNumber: string;
  locationLink: string;
  portalLink: string;
  imageName: string;
  isActive: boolean;
}
