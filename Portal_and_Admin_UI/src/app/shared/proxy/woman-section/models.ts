export interface GetWomanSectionDto {
  id: number;
  descriptionAr: string;
  descriptionEn: string;
  mainPoints: GetMainPoints[]
}

export interface GetMainPoints {
  id: number;
  nameAr: string;
  nameEn: string;
  order: number;
  pageContentType: string;
}
