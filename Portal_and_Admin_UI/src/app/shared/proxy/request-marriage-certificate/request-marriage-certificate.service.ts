import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestMarriageCertificateDto, GetRequestMarriageCertificateDetailsDto, RequestMarriageCertificateDto, UpdateRequestMarriageCertificateDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestMarriageCertificateService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestMarriageCertificate`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestMarriageCertificateDto>> => {
    return this.httpClient.get<ApiResponse<RequestMarriageCertificateDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestMarriageCertificateDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestMarriageCertificateDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestMarriageCertificateDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestMarriageCertificateDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
