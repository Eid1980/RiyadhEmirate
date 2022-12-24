
export interface CreateServieNotificationDto {
  serviceId?: number;
  stageId: number;
  isSMS: boolean;
  isEmail: boolean;
  isDefault: boolean;
  isActive: boolean;
  message: string;
}

export interface UpdateServieNotificationDto {
  id: number;
  serviceId?: number;
  stageId: number;
  isSMS: boolean;
  isEmail: boolean;
  isDefault: boolean;
  isActive: boolean;
  message: string;
}

export interface GetServieNotificationDetailsDto {
  id: number;
  serviceId?: number;
  serviceName: string;
  stageId: number;
  stageName: string;
  isSMS: boolean;
  isEmail: boolean;
  isDefault: boolean;
  isActive: boolean;
  message: string;
}

export interface GetCaseTypeListDto {
  id: number;
  serviceName: string;
  stageName: string;
  isActive: boolean;
  message: string;
}

