import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceDto, GetServiceDetailsDto, GetServiceListDto, UpdateServiceDto } from './models';
import { LookupDto } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root',
})
export class ServiceService {
  serviceUrl: string = `${environment.ApiUrl}/api/Service`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetServiceDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetServiceDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getByServiceId = (serviceId: number): Observable<ApiResponse<GetServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceListDto[]>>(`${this.serviceUrl}/GetByServiceId/${serviceId}`).pipe(
    );
  }

  create = (createdDto: CreateServiceDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateServiceDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  getLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
    );
  }
  getStagesLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetStagesLookupList`).pipe(
    );
  }

}
