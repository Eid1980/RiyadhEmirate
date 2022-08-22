
export interface CreateRequestTreatmentRecommendationDto {
  requestTypeId: number;
  patientType: number;
  patientName: string;
  patientNationalId: string;
  notes: string;
}

export interface UpdateRequestTreatmentRecommendationDto {
  id: string; requestTypeId: number;
  ratientType: number;
  patientName: string;
  patientNationalId: string;
  notes: string;
  concurrencyStamp: string;
}

export interface RequestTreatmentRecommendationDto {
  requestTypeId: number;
  patientType: number;
  patientName: string;
  patientNationalId: string;
  notes: string;
  canEdit: boolean;
  concurrencyStamp: string;
  createdBy: number;
}

export interface GetRequestTreatmentRecommendationDetailsDto {
  id: string;
  requestNumber: string;
  serviceName: string;
  requestDate: string;
  stageName: string;
  canEdit: boolean;
  notes: string;
  concurrencyStamp: string;
  requestTypeName: string;
  patientTypeName: string;
  patientName: string;
  patientNationalId: string;
  createdBy: number;
}

