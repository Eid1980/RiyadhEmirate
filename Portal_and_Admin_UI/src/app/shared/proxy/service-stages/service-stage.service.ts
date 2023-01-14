import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceStageDto, GetServiceStageDetailsDto, UpdateServiceStageDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ServiceStageService {
  serviceUrl: string = `${environment.ApiUrl}/api/ServiceStage`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetServiceStageDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetServiceStageDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateServiceStageDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateServiceStageDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }


}
