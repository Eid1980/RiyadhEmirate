import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';
import { CreateServiceConditionDto, GetServiceConditionDetailsDto, GetServiceConditionListDto, UpdateServiceConditionDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ServiceConditionService {
  serviceUrl: string = `${environment.ApiUrl}/api/ServiceCondition`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetServiceConditionDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetServiceConditionDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getByServiceId = (serviceId: number): Observable<ApiResponse<GetServiceConditionListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceConditionListDto[]>>(`${this.serviceUrl}/GetByServiceId/${serviceId}`).pipe(
    );
  }

  create = (createdDto: CreateServiceConditionDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  update = (updatedDto: UpdateServiceConditionDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
