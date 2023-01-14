
export interface CreateContactUsMessageDto {
  fullName: string;
  email: string;
  contactUsMessageTypeId: number;
  title: string;
  content: string;
  isReplied: boolean;
}

export interface GetContactUsMessageDetailsDto {
  id: number;
  fullName: string;
  email: string;
  contactUsMessageTypeId: number;
  contactUsMessageTypeName: string;
  title: string;
  content: string;
  isReplied: boolean;
  createdDate: string;
}

export interface GetContactUsMessageListDto {
  id: number;
  fullName: string;
  email: string;
  contactUsMessageTypeName: string;
  title: string;
  content: string;
  isReplied: boolean;
}
