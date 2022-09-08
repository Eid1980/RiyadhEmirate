
export interface GetServiceRateToUserRequestDto {
  serviceId: number;
  userId: number;
}

export interface GetServiceRateDto {
  serviceRate: number;
  canRate: boolean;
  rateCout: number;
  lastRateDate: string;
  serviceRatePercentage: number;
  ratePercentage: string;
}

export interface CreateServiceRateDto {
  serviceId: number;
  starsCount: number;
  notes: string;
}
