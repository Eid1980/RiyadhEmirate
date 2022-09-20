
export interface CreateGovernorateDto {
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  phoneNumber: string;
  locationLink: string;
  portalLink: string;
  isActive: boolean;
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
  isActive: boolean;
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
  isActive: boolean;

  image: any;
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
  isActive: boolean;

  image: any;
}
