
export interface CreateLatestNewsDto {
  title: string;
  content: string;
  isArabic: boolean;
  newsCategueryId: number;
  date: string;
  newsOrigin: string;
  isActive: boolean;
  openComments: boolean;

  image: any;
}

export interface UpdateLatestNewsDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsCategueryId: number;
  date: string;
  newsOrigin: string;
  isActive: boolean;
  openComments: boolean;

  image: any;
}

export interface GetLatestNewsDetailsDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsCategueryId: number;
  newsCategueryName: string;
  date: string;
  newsOrigin: string;
  isActive: boolean;
  openComments: boolean;

  image: any;
}

export interface GetLatestNewsListDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsCategueryId: number;
  newsCategueryName: string;
  date: string;
  newsOrigin: string;
  isActive: boolean;
  openComments: boolean;

  image: any;
}
