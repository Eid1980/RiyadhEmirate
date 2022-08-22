
export interface CreateRequestJudgmentExecutionDto {
  requestTypeId: number;
  requesterType: number;
  requesterName: string;
  requesterNationalId: string;
  defendantTypeId: number;
  lawsuitNumber: string;
  lawsuitDate: string;
  notes: string;
}

export interface UpdateRequestJudgmentExecutionDto {
  id: string;
  requesterType: number;
  requesterName: string;
  requesterNationalId: string;
  defendantTypeId: number;
  lawsuitNumber: string;
  lawsuitDate: string;
  notes: string;
  concurrencyStamp: string;
}


export interface RequestJudgmentExecutionDto {
  requestTypeId: number;
  canEdit: boolean;
  concurrencyStamp: string;
  createdBy: number;
  requesterType: number;
  requesterName: string;
  requesterNationalId: string;
  defendantTypeId: number;
  lawsuitNumber: string;
  lawsuitDate: string;
  notes: string;
}

export interface GetRequestJudgmentExecutionDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  concurrencyStamp: string;
  requesterTypeName: string;
  requesterName: string;
  requesterNationalId: string;
  defendantTypeName: string;
  lawsuitNumber: string;
  lawsuitDate: string;
  notes: string;
  createdBy: number;
}
