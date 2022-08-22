import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestForeignersRealtyOwnerDto, GetRequestForeignersRealtyOwnerDetailsDto, RequestForeignersRealtyOwnerDto, UpdateRequestForeignersRealtyOwnerDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestForeignersRealtyOwnerService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestForeignersRealtyOwner`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestForeignersRealtyOwnerDto>> => {
    return this.httpClient.get<ApiResponse<RequestForeignersRealtyOwnerDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestForeignersRealtyOwnerDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestForeignersRealtyOwnerDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestForeignersRealtyOwnerDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestForeignersRealtyOwnerDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
