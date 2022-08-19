import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestElectronicSummonDto, GetRequestElectronicSummonDetailsDto, RequestElectronicSummonDto, UpdateRequestElectronicSummonDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestElectronicSummonService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestElectronicSummon`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestElectronicSummonDto>> => {
    return this.httpClient.get<ApiResponse<RequestElectronicSummonDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestElectronicSummonDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestElectronicSummonDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestElectronicSummonDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestElectronicSummonDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
