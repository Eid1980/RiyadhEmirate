
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
  subSubExternalEntity: string;
  id: string;
  subExternalEntityName: string;
}


export interface TransactionRequedtDto {
  transactionType: string;
  transactionClass: string;
  intYear: string;
  intNumber: string;
}
export interface TransactionResponse {
  letterDate: string;
  letterNo: string;
  startDate: string;
  intNumber: string;
  externalEntity: string;
  subExternalEntity: string;
  subSubExternalEntity: string;
  state: string;
  id: string;
  subExternalEntityName: string;
}


export interface GetTransactionResponseDto {
  incomingNumber: string;
  incomingDate: string;
  outgoingNumber: string;
  outgoingDate: string;
  letterNo: string;
  letterDate: string;
  stateName: string;
  incomingEntityName: string;
  outgoingEntityName: string;
  canFeedback: boolean;
}
