
export interface CreateRequestPrisonersServiceDto {
  requestTypeId: number;
  prisonId: number;
  caseTypeId: number;
  notes: string;
}

export interface UpdateRequestPrisonersServiceDto {
  id: string;
  requestTypeId: number;
  notes: string;
  prisonId: number;
  caseTypeId: number;
  concurrencyStamp: string;
}

export interface RequestPrisonersServiceDto {
  requestTypeId: number;
  canEdit: boolean;
  prisonId: number;
  prisonName: string;
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
  stageName: string;
  canEdit: boolean;
  notes: string;
  concurrencyStamp: string;
  requestTypeName: string;
  caseTypeName: string;
  prisonName: string;
  createdBy: number;
}

