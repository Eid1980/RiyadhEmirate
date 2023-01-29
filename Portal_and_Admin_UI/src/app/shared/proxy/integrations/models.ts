
export interface SendSMSRequest {
  mobileNumber: string;
  smsBody: string;
}

export interface SendEmailRequest {
  emailSubject: string;
  email: string;
  emailBody: string
}


export interface EntityTableDto {
  id: number;
  name: string;
}
export interface GetSubSubExternalEntityRequestDto {
  externalEntity: number;
  subExternalEntity: number;
}
export interface LetterAdvancedSearchRequedtDto {
  externalEntity: number;
  subExternalEntity: number;
  subSubExternalEntity: number;
  searchClass: string;
  intYear: string;
  letterNo: string;
}
export interface LetterAdvancedSearchResponse {
  letterNo: string;
  letterDate: string;
  externalEntity: string;
  subExternalEntity: string;
  id: string;
}
