
export interface CreateLatestNewsCommentDto {
  latestNewsId: number;
  comment: string;
  email: string;
  createdByName: string;
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
  createdByName: string;
  createdDate: string;
}

export interface GetLatestNewsCommentListDto {
  id: number;
  comment: string;
  commentStageName: string;
  email: string;
  createdByName: string;
  createdDate: string;
}
