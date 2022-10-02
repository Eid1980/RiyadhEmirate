
export interface CreateEmiratesPrinceDto {
  nameAr: string;
  nameEn: string;
  behalfToArAr: string;
  behalfToArEn: string;
  fromDate: string;
  toDate: string;
  isActive: boolean;

  image: any;
}

export interface UpdateEmiratesPrinceDto {
  id: number;
  nameAr: string;
  nameEn: string;
  behalfToArAr: string;
  behalfToArEn: string;
  fromDate: string;
  toDate: string;
  isActive: boolean;

  image: any;
}

export interface GetEmiratesPrinceDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  behalfToArAr: string;
  behalfToArEn: string;
  fromDate: string;
  toDate: string;
  isActive: boolean;
  image: any;
}

export interface GetEmiratesPrinceListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  behalfToAr: string;
  behalfToEn: string;
  fromDate: string;
  toDate: string;
  isActive: boolean;
  image: any;
}
