export interface GetAboutUsDto {
  id: number;
  descriptionAr: string;
  descriptionEn: string;
  mainPoints: GetMainPoints[]
}

export interface GetMainPoints {
  id: number;
  nameAr: string;
  nameEn: string;
}
