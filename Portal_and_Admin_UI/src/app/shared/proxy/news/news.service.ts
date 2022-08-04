import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map, Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';
import { CreateNewsDto, GetNewsDetailsDto, UpdateNewsDto } from './models';
import { SearchModel } from '../shared/search-model.model';
import { ResponseVM, ServiceResponseVM } from '@shared/models/response.model';

@Injectable({
  providedIn: 'root',
})
export class NewsService {
  serviceUrl: string = `${environment.ApiUrl}/api/News`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetNewsDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetNewsDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateNewsDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateNewsDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  getListPage(searchModel: SearchModel): Observable<ServiceResponseVM> {
    return this.httpClient
      .post(`${this.serviceUrl}/GetListPage`, searchModel)
      .pipe();
  }

  getAll(newTypeId : number): Observable<ServiceResponseVM> {
    return this.httpClient
      .get(`${this.serviceUrl}/GetAll/${newTypeId}`)
  }



  //getLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
  //  return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
  //  );
  //}

}
