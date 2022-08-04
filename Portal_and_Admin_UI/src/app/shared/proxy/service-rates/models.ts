
export interface GetServiceRateToUserRequestDto {
  serviceId: number;
  userId: number;
}

export interface GetServiceRateDto {
  serviceRate: number;
  canRate: boolean;
}

export interface CreateServiceRateDto {
  serviceId: number;
  starsCount: number;
  notes: string;
}
