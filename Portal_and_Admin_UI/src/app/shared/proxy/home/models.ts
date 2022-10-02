
export interface HomeCountsDto {
  userCount: number;
  serviceCount: number;
  requestCount: number;
  rateCount: number;
}

export interface CreateDesignEvaluationDto {
  evaluate: number;
}

export interface CreateNewsSubscriperDto {
  email: string;
}

export interface GetAllServiceListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  descriptionAr: string;
  descriptionEn: string;
  requestLink: string;
  isExternal: boolean;
  requestCount: number;
  image: any;
}
