import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestElectronicBoardDto, GetRequestElectronicBoardDetailsDto, RequestElectronicBoardDto, UpdateRequestElectronicBoardDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestElectronicBoardService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestElectronicBoard`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestElectronicBoardDto>> => {
    return this.httpClient.get<ApiResponse<RequestElectronicBoardDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestElectronicBoardDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestElectronicBoardDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestElectronicBoardDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestElectronicBoardDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
