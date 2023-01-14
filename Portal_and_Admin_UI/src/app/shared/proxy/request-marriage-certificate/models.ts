
export interface CreateRequestMarriageCertificateDto {
  requestTypeId: number;
  employeeSide: string;
  jobOccupation: string;
  maritalStatusId: number;
  childrenCount: number;
  notes: string;
}

export interface UpdateRequestMarriageCertificateDto {
  id: string;
  requestTypeId: number;
  employeeSide: string;
  jobOccupation: string;
  maritalStatusId: number;
  childrenCount: number;
  notes: string;
  concurrencyStamp: string;
}


export interface RequestMarriageCertificateDto {
  requestTypeId: number;
  canEdit: boolean;
  concurrencyStamp: string;
  createdBy: number;
  employeeSide: string;
  childrenCount: number;
  maritalStatusId: number;
  maritalStatusName: string;
  jobOccupation: string;
  notes: string;
}

export interface GetRequestMarriageCertificateDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  concurrencyStamp: string;
  requestTypeName: string;
  employeeSide: string;
  childrenCount: number;
  maritalStatusName: string;
  jobOccupation: string;
  notes: string;
  createdBy: number;
}
