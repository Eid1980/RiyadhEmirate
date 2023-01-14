import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateNewsDto, GetNewsDetailsDto, GetNewsListDto, UpdateNewsDto } from './models';
import { SearchModel } from '../shared/search-model.model';
import { ServiceResponseVM } from '@shared/models/response.model';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

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
  create = (createdDto: CreateNewsDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateNewsDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }
  changecommentStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangecommentStatus/${id}`).pipe();
  }
  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
