
export interface CreateNewsCommentDto {
  newsId: number;
  comment: string;
  email: string;
  createdByName: string;
}

export interface UpdateNewsCommentDto {
  id: number;
  commentStageId: number;
}

export interface GetNewsCommentDetailsDto {
  id: number;
  newsTitle: string;
  comment: string;
  commentStageName: string;
  email: string;
  createdByName: string;
  createdDate: string;
}

export interface GetNewsCommentListDto {
  id: number;
  comment: string;
  commentStageName: string;
  email: string;
  createdByName: string;
  createdDate: string;
}
