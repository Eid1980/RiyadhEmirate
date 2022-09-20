import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateLatestNewsCommentDto, GetLatestNewsCommentDetailsDto, GetLatestNewsCommentListDto, UpdateLatestNewsCommentDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class LatestNewsCommentService {
  serviceUrl: string = `${environment.ApiUrl}/api/LatestNewsComment`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetLatestNewsCommentDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetLatestNewsCommentDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  getByLatestNewsId = (latestNewsId: number): Observable<ApiResponse<GetLatestNewsCommentListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetLatestNewsCommentListDto[]>>(`${this.serviceUrl}/GetByLatestNewsId/${latestNewsId}`).pipe(
    );
  }

  create = (createdDto: CreateLatestNewsCommentDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateLatestNewsCommentDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
