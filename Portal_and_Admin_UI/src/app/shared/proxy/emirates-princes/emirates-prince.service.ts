import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateEmiratesPrinceDto, GetEmiratesPrinceDetailsDto, GetEmiratesPrinceListDto, UpdateEmiratesPrinceDto } from './models';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

@Injectable({
  providedIn: 'root',
})
export class EmiratesPrinceService {
  serviceUrl: string = `${environment.ApiUrl}/api/EmiratesPrince`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetEmiratesPrinceDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetEmiratesPrinceDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  getAll(): Observable<ApiResponse<GetEmiratesPrinceListDto[]>> {
    return this.httpClient.get<ApiResponse<GetEmiratesPrinceListDto[]>>(`${this.serviceUrl}/GetAll`)
  }

  create = (createdDto: CreateEmiratesPrinceDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateEmiratesPrinceDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
