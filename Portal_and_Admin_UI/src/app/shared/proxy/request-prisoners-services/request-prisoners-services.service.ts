import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestPrisonersServiceDto, GetRequestPrisonersServiceDetailsDto, RequestPrisonersServiceDto, UpdateRequestPrisonersServiceDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestPrisonersServicesService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestPrisonersService`;
  constructor(public httpClient: HttpClient)
  {
  }

  getById = (id: string): Observable<ApiResponse<RequestPrisonersServiceDto>> => {
    return this.httpClient.get<ApiResponse<RequestPrisonersServiceDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestPrisonersServiceDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestPrisonersServiceDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestPrisonersServiceDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestPrisonersServiceDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
