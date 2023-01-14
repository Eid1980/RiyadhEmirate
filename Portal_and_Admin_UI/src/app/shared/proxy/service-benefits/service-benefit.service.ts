import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceBenefitDto, GetAllCountDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ServiceBenefitService {
  serviceUrl: string = `${environment.ApiUrl}/api/ServiceBenefit`;
  constructor(public httpClient: HttpClient) {
  }

  getAllCountByServiceId = (serviceId: number): Observable<ApiResponse<GetAllCountDto>> => {
    return this.httpClient.get<ApiResponse<GetAllCountDto>>(`${this.serviceUrl}/GetAllCountByServiceId/${serviceId}`).pipe(
    );
  }

  create = (createdDto: CreateServiceBenefitDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

}
