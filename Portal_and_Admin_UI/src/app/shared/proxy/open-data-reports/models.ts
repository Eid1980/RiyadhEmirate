
export interface CreateOpenDataReportDto {
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  fileUrl: string;
  isActive: boolean;
}

export interface UpdateOpenDataReportDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  fileUrl: string;
  isActive: boolean;
}

export interface GetOpenDataReportDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  openDataCategueryName: string;
  fileUrl: string;
  isActive: boolean;
}

export interface GetOpenDataReportListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  openDataCategueryId: number;
  openDataCategueryName: string;
  fileUrl: string;
  isActive: boolean;
}
