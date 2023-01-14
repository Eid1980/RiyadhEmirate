
export interface CreateOpenDataReportDto {
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  isActive: boolean;
}

export interface UpdateOpenDataReportDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  isActive: boolean;
}

export interface GetOpenDataReportDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  openDataCategueryName: string;
  isActive: boolean;
  fileId: string;
}

export interface GetOpenDataReportListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  openDataCategueryName: string;
  isActive: boolean;
}
