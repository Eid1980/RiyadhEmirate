
export interface CreateRequestForeignersRealtyOwnerDto {
  buildingTypeId: number;
  governorateId: number;
  district: string;
  religionId: number;
  address: string;
  notes: string;
}

export interface UpdateRequestForeignersRealtyOwnerDto {
  id: string;
  buildingTypeId: number;
  governorateId: number;
  district: string;
  religionId: number;
  address: string;
  notes: string;
  concurrencyStamp: string;
}


export interface RequestForeignersRealtyOwnerDto {
  canEdit: boolean;
  concurrencyStamp: string;
  createdBy: number;

  buildingTypeId: number;
  governorateId: number;
  district: string;
  religionId: number;
  address: string;
  notes: string;
}

export interface GetRequestForeignersRealtyOwnerDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  concurrencyStamp: string;

  buildingTypeName: string;
  governorateName: string;
  district: string;
  religionName: string;
  address: string;
  notes: string;
  createdBy: number;
}
