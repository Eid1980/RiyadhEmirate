import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateDesignEvaluationDto, GetAllServiceListDto, GetNewsSearchListDto, HomeCountsDto } from './models';
import { GetNewsListDto } from '../news/models';
import { SearchModel } from '../shared/search-model.model';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  serviceUrl: string = `${environment.ApiUrl}/api/Home`;
  constructor(public httpClient: HttpClient) {
  }

  getCounts = (): Observable<ApiResponse<HomeCountsDto>> => {
    return this.httpClient.get<ApiResponse<HomeCountsDto>>(`${this.serviceUrl}/GetCounts`).pipe(
    );
  }

  createDesignEvaluation = (createdDto: CreateDesignEvaluationDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/CreateDesignEvaluation`, createdDto).pipe();
  }

  getAllServices = (): Observable<ApiResponse<GetAllServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetAllServiceListDto[]>>(`${this.serviceUrl}/GetAllServices`).pipe(
    );
  }


  getNewsSearch = (filter: string): Observable<ApiResponse<GetNewsSearchListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetNewsSearchListDto[]>>(`${this.serviceUrl}/GetNewsSearch/${filter}`).pipe(
    );
  }
  getAllNews = (searchModel: SearchModel): Observable<ApiResponse<GetNewsListDto[]>> => {
    return this.httpClient.post<ApiResponse<GetNewsListDto[]>>(`${this.serviceUrl}/GetAllNews`, searchModel).pipe(
    );
  }
  getTop5NewsByLang = (isArabic: boolean): Observable<ApiResponse<GetNewsSearchListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetNewsSearchListDto[]>>(`${this.serviceUrl}/GetTop5NewsByLang/${isArabic}`).pipe(
    );
  }

}