import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestJudgmentExecutionDto, GetRequestJudgmentExecutionDetailsDto, RequestJudgmentExecutionDto, UpdateRequestJudgmentExecutionDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestJudgmentExecutionService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestJudgmentExecution`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestJudgmentExecutionDto>> => {
    return this.httpClient.get<ApiResponse<RequestJudgmentExecutionDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestJudgmentExecutionDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestJudgmentExecutionDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestJudgmentExecutionDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestJudgmentExecutionDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
