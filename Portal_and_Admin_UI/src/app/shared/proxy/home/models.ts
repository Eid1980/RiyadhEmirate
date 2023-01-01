
export interface HomeCountsDto {
  userCount: number;
  serviceCount: number;
  requestCount: number;
  rateCount: number;
}

export interface CreateDesignEvaluationDto {
  evaluate: number;
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
  imageName: string;
}

export interface GetNewsSearchListDto {
  id: number;
  title: string;
  content: string;
  date: string;
  newsTypeId: number;
  imageName: any;
}

export interface GetRequestStatisticsDto {
  name: string;
  count: number;
}

export interface GetStatisticsDto {
  userCount: number;
  requestCount: number;
  requestFinishedCount: number;
  requestElectronicBoardsCount: number;
  serviceRequests: GetRequestStatisticsDto[];
  stageRequests: GetRequestStatisticsDto[];
  governorateRequests: GetRequestStatisticsDto[];
}
