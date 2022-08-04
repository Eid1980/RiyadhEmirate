import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestPrisonerTempReleaseDto, GetRequestPrisonerTempReleaseDetailsDto, RequestPrisonerTempReleaseDto, UpdateRequestPrisonerTempReleaseDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestPrisonerTempReleaseService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestPrisonerTempRelease`;
  constructor(public httpClient: HttpClient)
  {
  }

  getById = (id: string): Observable<ApiResponse<RequestPrisonerTempReleaseDto>> => {
    return this.httpClient.get<ApiResponse<RequestPrisonerTempReleaseDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestPrisonerTempReleaseDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestPrisonerTempReleaseDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestPrisonerTempReleaseDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestPrisonerTempReleaseDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
