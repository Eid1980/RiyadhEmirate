
export interface CreateRequestLandsInfringementDto {
  requestTypeId: number;
  instrumentNumber: string;
  estimatedSpace: string;
  governorateId: number;
  address: string;
  longitude: string;
  latitude: string;
  infringerName: string;
  infringerDescription: string;
  notes: string;
}

export interface UpdateRequestLandsInfringementDto {
  id: string;
  requestTypeId: number;
  instrumentNumber: string;
  estimatedSpace: string;
  governorateId: number;
  address: string;
  longitude: string;
  latitude: string;
  infringerName: string;
  infringerDescription: string;
  notes: string;
  concurrencyStamp: string;
}

export interface RequestLandsInfringementDto {
  requestTypeId: number;
  canEdit: boolean;
  instrumentNumber: string;
  estimatedSpace: string;
  governorateId: number;
  address: string;
  longitude: string;
  latitude: string;
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
  requestStatusName: string;
  canEdit: boolean;
  notes: string;
  concurrencyStamp: string;
  requestTypeName: string;
  instrumentNumber: string;
  estimatedSpace: string;
  governorateId: string;
  address: string;
  longitude: string;
  latitude: string;
  locationLink: string;
  infringerName: string;
  infringerDescription: string;
  createdBy: number;
}
