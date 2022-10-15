import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateAuctionDto, GetAuctionDetailsDto, UpdateAuctionDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

@Injectable({
  providedIn: 'root',
})
export class AuctionService {
  serviceUrl: string = `${environment.ApiUrl}/api/Auction`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetAuctionDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetAuctionDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateAuctionDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateAuctionDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
