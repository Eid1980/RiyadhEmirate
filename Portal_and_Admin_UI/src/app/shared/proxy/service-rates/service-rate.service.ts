import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceRateDto, GetServiceRateDto, GetServiceRateToUserRequestDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ServiceRateService {
  serviceUrl: string = `${environment.ApiUrl}/api/ServiceRate`;
  constructor(public httpClient: HttpClient) {
  }

  getServiceRate = (serviceId: number): Observable<ApiResponse<number>> => {
    return this.httpClient.get<ApiResponse<number>>(`${this.serviceUrl}/GetServiceRate/${serviceId}`).pipe(
    );
  }
  getServiceRateToUser = (requestDto: GetServiceRateToUserRequestDto): Observable<ApiResponse<GetServiceRateDto>> => {
    return this.httpClient.post<ApiResponse<GetServiceRateDto>>(`${this.serviceUrl}/GetServiceRateToUser`, requestDto).pipe();
  }

  create = (createModel: CreateServiceRateDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createModel).pipe();
  }
}
