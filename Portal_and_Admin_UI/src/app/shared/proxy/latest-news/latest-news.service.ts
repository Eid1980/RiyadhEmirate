import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateLatestNewsDto, GetLatestNewsDetailsDto, UpdateLatestNewsDto } from './models';
import { SearchModel } from '../shared/search-model.model';
import { ServiceResponseVM } from '@shared/models/response.model';

@Injectable({
  providedIn: 'root',
})
export class LatestNewsService {
  serviceUrl: string = `${environment.ApiUrl}/api/LatestNews`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetLatestNewsDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetLatestNewsDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getListPage(searchModel: SearchModel): Observable<ServiceResponseVM> {
    return this.httpClient
      .post(`${this.serviceUrl}/GetListPage`, searchModel)
      .pipe();
  }
  getAll(): Observable<ServiceResponseVM> {
    return this.httpClient
      .get(`${this.serviceUrl}/GetAll`)
  }

  create = (createdDto: CreateLatestNewsDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateLatestNewsDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }
  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
