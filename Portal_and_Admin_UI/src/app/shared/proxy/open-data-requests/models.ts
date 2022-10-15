
export interface CreateOpenDataRequestDto {
  fullName: string;
  email: string;
  title: string;
  content: string;
  isReplied: boolean;
}

export interface GetOpenDataRequestDetailsDto {
  id: number;
  fullName: string;
  email: string;
  title: string;
  content: string;
  isReplied: boolean;
  createdDate: string;
}

export interface GetOpenDataRequestListDto {
  id: number;
  fullName: string;
  email: string;
  title: string;
  content: string;
  isReplied: boolean;
}
