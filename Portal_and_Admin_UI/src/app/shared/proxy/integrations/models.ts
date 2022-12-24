
export interface SendSMSRequest {
  mobileNumber: string;
  smsBody: string;
}

export interface SendEmailRequest {
  emailSubject: string;
  email: string;
  emailBody: string
}

