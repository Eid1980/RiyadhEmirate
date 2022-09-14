export interface GetAboutUsDto {
  id: number;
  descriptionAr: string;
  descriptionEn: string;
  mainPoints: GetMainPoints[]
}

export interface EditAboutUs{
  id: number;
  descriptionAr: string;
  descriptionEn: string;
}

export interface GetMainPoints {
  id: number;
  nameAr: string;
  nameEn: string;
  order: number;
  pageContentType: string;
}

export interface CreateMainPoint{
  nameAr: string;
  nameEn: string;
  order: number;
  pageContentType: string;
}


export interface EditPageMainPoint{
  id: number,
  nameAr: string;
  nameEn: string;
  order: number;
  pageContentType: string;
}

