
export interface CreateRequestPrisonerTempReleaseDto {
  requestTypeId: number;
  presonName: string;
  caseTypeId: number;
  notes: string;
}

export interface UpdateRequestPrisonerTempReleaseDto {
  id: string;
  requestTypeId: number;
  notes: string;
  presonName: string;
  caseTypeId: number;
  concurrencyStamp: string;
}

export interface RequestPrisonerTempReleaseDto {
  requestTypeId: number;
  canEdit: boolean;
  presonName: string;
  caseTypeId: number;
  notes: string;
  concurrencyStamp: string;
  createdBy: number;
}

export interface GetRequestPrisonerTempReleaseDetailsDto {
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
  presonName: string;
  createdBy: number;
}

