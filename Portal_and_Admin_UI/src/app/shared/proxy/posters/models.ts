
export interface CreatePosterDto {
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface UpdatePosterDto {
  id: number;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface GetPosterDetailsDto {
  id: number;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
}

export interface GetPosterListDto {
  id: number;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
}
