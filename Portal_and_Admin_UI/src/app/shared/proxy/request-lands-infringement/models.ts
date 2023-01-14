
export interface CreateRequestLandsInfringementDto {
  requestTypeId: number;
  estimatedSpace: string;
  governorateId: number;
  infringerName: string;
  infringerDescription: string;
  notes: string;
}

export interface UpdateRequestLandsInfringementDto {
  id: string;
  requestTypeId: number;
  estimatedSpace: string;
  governorateId: number;
  infringerName: string;
  infringerDescription: string;
  notes: string;
  concurrencyStamp: string;
}

export interface RequestLandsInfringementDto {
  requestTypeId: number;
  canEdit: boolean;
  estimatedSpace: string;
  governorateId: number;
  infringerName: string;
  infringerDescription: string;
  notes: string;
  concurrencyStamp: string;
  createdBy: number;
}

export interface GetRequestLandsInfringementDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  notes: string;
  concurrencyStamp: string;
  requestTypeName: string;
  estimatedSpace: string;
  governorateName: string;
  locationLink: string;
  infringerName: string;
  infringerDescription: string;
  createdBy: number;
}
