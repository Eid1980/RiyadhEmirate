import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateDesignEvaluationDto, CreateNewsSubscriperDto, GetAllServiceListDto, HomeCountsDto } from './models';

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
  createNewsSubscriper = (createdDto: CreateNewsSubscriperDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/CreateNewsSubscriper`, createdDto).pipe();
  }

  getAllServices = (): Observable<ApiResponse<GetAllServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetAllServiceListDto[]>>(`${this.serviceUrl}/GetAllServices`).pipe(
    );
  }
}
