
export interface CreateAuctionDto {
  title: string;
  content: string;
  isActive: boolean;
}

export interface UpdateAuctionDto {
  id: number;
  title: string;
  content: string;
  isActive: boolean;
}

export interface GetAuctionDetailsDto {
  id: number;
  title: string;
  content: string;
  isActive: boolean;
}

export interface GetAuctionListDto {
  id: number;
  title: string;
  content: string;
  isActive: boolean;
}
