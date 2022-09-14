import { GetMainPoints } from "../about-us/models";

export interface GetWomanSectionDto {
  id: number;
  descriptionAr: string;
  descriptionEn: string;
  mainPoints: GetMainPoints[]
}

export interface EditWomanSectionDto{
  id: number;
  descriptionAr: string;
  descriptionEn: string;
}




