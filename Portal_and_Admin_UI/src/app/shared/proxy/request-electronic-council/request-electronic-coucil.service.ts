import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestElectronicCouncilDto, GetRequestElectronicCouncilDetailsDto, RequestElectronicCouncilDto, UpdateRequestElectronicCouncilDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestElectronicCouncilService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestElectronicBoard`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestElectronicCouncilDto>> => {
    return this.httpClient.get<ApiResponse<RequestElectronicCouncilDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestElectronicCouncilDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestElectronicCouncilDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestElectronicCouncilDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestElectronicCouncilDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
