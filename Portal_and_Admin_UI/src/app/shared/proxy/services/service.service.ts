import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateServiceDto, GetServiceDetailsDto, GetServiceListDto, UpdateServiceDto } from './models';
import { LookupDto } from '../shared/lookup-dto.model';
import { SearchModel } from '../shared/search-model.model';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

@Injectable({
  providedIn: 'root',
})
export class ServiceService {
  serviceUrl: string = `${environment.ApiUrl}/api/Service`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetServiceDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetServiceDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getByServiceId = (serviceId: number): Observable<ApiResponse<GetServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceListDto[]>>(`${this.serviceUrl}/GetByServiceId/${serviceId}`).pipe(
    );
  }
  getAll = (): Observable<ApiResponse<GetServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceListDto[]>>(`${this.serviceUrl}/GetAll`).pipe(
    );
  }
  searchByFilter = (filter: string): Observable<ApiResponse<GetServiceListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetServiceListDto[]>>(`${this.serviceUrl}/SearchByFilter/${filter}`).pipe(
    );
  }

  create = (createdDto: CreateServiceDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  update = (updatedDto: UpdateServiceDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
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
  getStagesLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetStagesLookupList`).pipe(
    );
  }
  getServiceExplainAttachment = (id: number): Observable<ApiResponse<any>> => {
    return this.httpClient.get<ApiResponse<any>>(`${this.serviceUrl}/GetServiceExplainAttachment/${id}`).pipe(
    );
  }

}
