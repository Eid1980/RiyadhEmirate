import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateRequestTreatmentRecommendationDto, GetRequestTreatmentRecommendationDetailsDto, RequestTreatmentRecommendationDto, UpdateRequestTreatmentRecommendationDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class RequestTreatmentRecommendationService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestTreatmentRecommendation`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<RequestTreatmentRecommendationDto>> => {
    return this.httpClient.get<ApiResponse<RequestTreatmentRecommendationDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getDetailsById = (id: string): Observable<ApiResponse<GetRequestTreatmentRecommendationDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestTreatmentRecommendationDetailsDto>>(`${this.serviceUrl}/GetDetailsById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateRequestTreatmentRecommendationDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestTreatmentRecommendationDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

}
