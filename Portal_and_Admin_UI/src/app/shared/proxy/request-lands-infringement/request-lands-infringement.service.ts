import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestLandsInfringementDto, GetRequestLandsInfringementDetailsDto, RequestLandsInfringementDto, UpdateRequestLandsInfringementDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestLandsInfringementService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestLandsInfringement`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestLandsInfringementDto>> => {
    return this.httpClient.get<ApiResponse<RequestLandsInfringementDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestLandsInfringementDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestLandsInfringementDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestLandsInfringementDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestLandsInfringementDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
