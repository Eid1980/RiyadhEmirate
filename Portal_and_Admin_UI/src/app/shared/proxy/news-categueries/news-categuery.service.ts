import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateNewsCategueryDto, GetNewsCategueryDetailsDto, UpdateNewsCategueryDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root',
})
export class NewsCategueryService {
  serviceUrl: string = `${environment.ApiUrl}/api/NewsCateguery`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetNewsCategueryDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetNewsCategueryDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateNewsCategueryDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateNewsCategueryDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

  getLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
    );
  }

}
