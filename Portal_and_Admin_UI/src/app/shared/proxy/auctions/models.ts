
export interface CreateAuctionDto {
  title: string;
  content: string;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface UpdateAuctionDto {
  id: number;
  title: string;
  content: string;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface GetAuctionDetailsDto {
  id: number;
  title: string;
  content: string;
  imageName: string;
  isActive: boolean;
}

export interface GetAuctionListDto {
  id: number;
  title: string;
  content: string;
  imageName: string;
  isActive: boolean;
}
