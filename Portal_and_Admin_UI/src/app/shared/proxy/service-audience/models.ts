
export interface CreateServiceAudienceDto {
  serviceId: number;
  audienceId: number;
}

export interface GetServiceAudienceListDto {
  id: number;
  serviceId: number;
  audienceId: number;
  audienceName: string;
}
