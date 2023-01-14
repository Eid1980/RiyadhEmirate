import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceAudienceDto, GetCheckedAudienceDto, GetServiceAudienceListDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ServiceAudienceService {
  serviceUrl: string = `${environment.ApiUrl}/api/ServiceAudience`;
  constructor(public httpClient: HttpClient) {
  }

  getByServiceId = (serviceId: number): Observable<ApiResponse<GetServiceAudienceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceAudienceListDto[]>>(`${this.serviceUrl}/GetByServiceId/${serviceId}`).pipe(
    );
  }

  getCheckedAudience = (serviceId: number): Observable<ApiResponse<GetCheckedAudienceDto>> => {
    return this.httpClient.get<ApiResponse<GetCheckedAudienceDto>>(`${this.serviceUrl}/GetCheckedAudience/${serviceId}`).pipe(
    );
  }

  create = (createdDto: CreateServiceAudienceDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }
}
