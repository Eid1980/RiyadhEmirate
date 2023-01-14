
export interface CreateRequestElectronicCouncilDto {
  requestTypeId: number;
  requestTitle: string;
  requestContent: string;
  notes: string;
}

export interface UpdateRequestElectronicCouncilDto {
  id: string;
  requestTypeId: number;
  requestTitle: string;
  requestContent: string;
  notes: string;
  concurrencyStamp: string;
}


export interface RequestElectronicCouncilDto {
  requestTypeId: number;
  canEdit: boolean;
  concurrencyStamp: string;
  createdBy: number;
  requestTitle: string;
  requestContent: string;
  notes: string;
}

export interface GetRequestElectronicCouncilDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  concurrencyStamp: string;
  requestTypeName: string;
  requestTitle: string;
  requestContent: string;
  notes: string;
  createdBy: number;
}
