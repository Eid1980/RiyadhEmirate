
export interface CreateOpenDataCategueryDto {
  nameAr: string;
  nameEn: string;
  openDataSubCategueryId: number;
  isActive: boolean;
}

export interface UpdateOpenDataCategueryDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataSubCategueryId: number;
  isActive: boolean;
}

export interface GetOpenDataCategueryDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataSubCategueryId: number;
  openDataSubCategueryName: string;
  isActive: boolean;
}

export interface GetOpenDataCategueryListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataSubCategueryId: number;
  openDataSubCategueryName: string;
  isActive: boolean;
}
