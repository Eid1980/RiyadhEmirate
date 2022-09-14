
export interface CreateLatestNewsCommentDto {
  latestNewsId: number;
  comment: string;
  email: string;
  createdBy: string;
}

export interface UpdateLatestNewsCommentDto {
  id: number;
  commentStageId: number;
}

export interface GetLatestNewsCommentDetailsDto {
  id: number;
  comment: string;
  commentStageName: string;
  email: string;
  createdBy: string;
  createdDate: string;
}

export interface GetLatestNewsCommentListDto {
  id: number;
  comment: string;
  commentStageName: string;
  email: string;
  createdBy: string;
  createdDate: string;
}
