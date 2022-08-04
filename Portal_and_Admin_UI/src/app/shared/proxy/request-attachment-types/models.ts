
export interface CreateRequestAttachmentTypeDto {
  nameAr: string;
  nameEn: string;
  serviceId: number;
  extentionAllowed: string;
  maxFileSize?: number;
  isRequired: boolean;
  isActive: boolean;
}

export interface UpdateRequestAttachmentTypeDto {
  id: number;
  nameAr: string;
  nameEn: string;
  serviceId: number;
  extentionAllowed: string;
  maxFileSize?: number;
  isRequired: boolean;
  isActive: boolean;
}

export interface GetRequestAttachmentTypeDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  serviceId: number;
  serviceName: string;
  extentionAllowed: string;
  maxFileSize?: number;
  isRequired: boolean;
  isActive: boolean;
}

export interface GetRequestAttachmentTypeListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  serviceId: number;
  serviceName: string;
  isRequired: boolean;
  isActive: boolean;
}
