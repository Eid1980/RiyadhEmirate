
export interface CreateServiceStageDto {
  serviceId: number;
  stageId: number;
  requesterUrl: string;
  adminUrl: string;
}

export interface UpdateServiceStageDto {
  id: number;
  serviceId: number;
  stageId: number;
  requesterUrl: string;
  adminUrl: string;
}

export interface GetServiceStageDetailsDto {
  id: number;
  serviceId: number;
  serviceName: string;
  stageId: number;
  stageName: string;
  requesterUrl: string;
  adminUrl: string;
}

export interface GetServiceStageListDto {
  id: number;
  serviceName: string;
  stageName: string;
}
