
export interface CreateServiceConditionDto {
  serviceId: number;
  condition: string;
  order: number;
}

export interface UpdateServiceConditionDto {
  id: number;
  serviceId: number;
  condition: string;
  order: number;
}

export interface GetServiceConditionDetailsDto {
  id: number;
  condition: string;
  order: number;
}

export interface GetServiceConditionListDto {
  id: number;
  condition: string;
  order: number;
}
