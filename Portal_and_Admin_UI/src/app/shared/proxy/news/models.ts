
export interface CreateNewsDto {
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  newsType: number;
  newsTypeId : number;
  date: string;
  isActive: boolean;

  image: any;
}

export interface UpdateNewsDto {
  id: number;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  newsType: number;
  date: string;
  isActive: boolean;

  image: any;
}

export interface GetNewsDetailsDto {
  id: number;
  titleAr: string;
  titleEn: string;
  descriptionAr: string;
  descriptionEn: string;
  newsType: number;
  date: string;
  isActive: boolean;

  image: any;
}
