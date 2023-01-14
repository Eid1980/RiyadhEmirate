
export interface CreateNewsCategueryDto {
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface UpdateNewsCategueryDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetNewsCategueryDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetNewsCategueryListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}
