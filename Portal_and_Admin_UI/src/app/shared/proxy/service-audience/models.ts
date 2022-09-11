
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


export interface CheckedAudience {
  id: number;
  audienceId: number;
  audienceName: string;
  isChecked: boolean;
}

export interface GetCheckedAudienceDto {
  checkedAudiences: CheckedAudience[];
  image: any;
}
