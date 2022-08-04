
export interface CreateRequestPrisonersServiceDto {
  requestTypeId: number;
  presonName: string;
  caseTypeId: number;
  notes: string;
}

export interface UpdateRequestPrisonersServiceDto {
  id: string;
  requestTypeId: number;
  notes: string;
  presonName: string;
  caseTypeId: number;
  concurrencyStamp: string;
}

export interface RequestPrisonersServiceDto {
  requestTypeId: number;
  canEdit: boolean;
  presonName: string;
  caseTypeId: number;
  notes: string;
  concurrencyStamp: string;
  createdBy: number;
}

export interface GetRequestPrisonersServiceDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  requestStatusName: string;
  canEdit: boolean;
  notes: string;
  concurrencyStamp: string;
  requestTypeName: string;
  caseTypeName: string;
  presonName: string;
  createdBy: number;
}

