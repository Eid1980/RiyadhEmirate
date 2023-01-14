
export interface GetAllCountDto {
  allCount: number;
  benefitCount: number;
}

export interface CreateServiceBenefitDto {
  serviceId: number;
  isBenefit: boolean;
}
