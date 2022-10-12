import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateNewsCommentDto, GetNewsCommentDetailsDto, GetNewsCommentListDto, UpdateNewsCommentDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class NewsCommentService {
  serviceUrl: string = `${environment.ApiUrl}/api/NewsComment`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetNewsCommentDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetNewsCommentDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  getByNewsId = (NewsId: number): Observable<ApiResponse<GetNewsCommentListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetNewsCommentListDto[]>>(`${this.serviceUrl}/GetByNewsId/${NewsId}`).pipe(
    );
  }

  create = (createdDto: CreateNewsCommentDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateNewsCommentDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
