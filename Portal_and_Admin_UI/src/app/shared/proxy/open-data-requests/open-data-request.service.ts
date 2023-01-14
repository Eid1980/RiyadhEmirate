import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateOpenDataRequestDto, GetOpenDataRequestDetailsDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class OpenDataRequestService {
  serviceUrl: string = `${environment.ApiUrl}/api/OpenDataRequest`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetOpenDataRequestDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetOpenDataRequestDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateOpenDataRequestDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
