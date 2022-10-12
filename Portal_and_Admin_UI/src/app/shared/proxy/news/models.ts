
export interface CreateNewsDto {
  title: string;
  content: string;
  isArabic: boolean;
  newsTypeId: number;
  newsCategueryId: number;
  date: string;
  newsOrigin: string;
  imageName: string;
  isActive: boolean;
  openComments: boolean;

  image: any;
}

export interface UpdateNewsDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsTypeId: number;
  newsCategueryId: number;
  date: string;
  newsOrigin: string;
  imageName: string;
  isActive: boolean;
  openComments: boolean;
}

export interface GetNewsDetailsDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsTypeId: number;
  newsCategueryId: number;
  newsCategueryName: string;
  date: string;
  newsDate: string;
  newsOrigin: string;
  imageName: string;
  isActive: boolean;
  openComments: boolean;
}

export interface GetNewsListDto {
  id: number;
  title: string;
  content: string;
  isArabic: boolean;
  newsTypeId: number;
  newsCategueryId: number;
  newsCategueryName: string;
  date: string;
  newsOrigin: string;
  imageName: string;
  isActive: boolean;
  openComments: boolean;
}
