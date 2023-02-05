import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { EntityTableDto, GetSubSubExternalEntityRequestDto, GetTransactionResponseDto, LetterAdvancedSearchRequedtDto, LetterAdvancedSearchResponse, SendEmailRequest, SendSMSRequest, TransactionRequedtDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class IntegrationService {
  serviceUrl: string = `${environment.ApiUrl}/api/Integration`;
  constructor(public httpClient: HttpClient) {
  }

  sendSMS = (request: SendSMSRequest): Observable<ApiResponse<boolean>> => {
    return this.httpClient.post<ApiResponse<boolean>>(`${this.serviceUrl}/SendSMS`, request).pipe();
  }
  sendEmail = (request: SendEmailRequest): Observable<ApiResponse<boolean>> => {
    return this.httpClient.post<ApiResponse<boolean>>(`${this.serviceUrl}/SendEmail`, request).pipe();
  }

  getExternalEntityAsync = (): Observable<ApiResponse<EntityTableDto[]>> => {
    return this.httpClient.get<ApiResponse<EntityTableDto[]>>(`${this.serviceUrl}/GetExternalEntityAsync`).pipe();
  }
  getSubExternalEntityAsync = (externalEntity: string): Observable<ApiResponse<EntityTableDto[]>> => {
    return this.httpClient.get<ApiResponse<EntityTableDto[]>>(`${this.serviceUrl}/GetSubExternalEntityAsync/${externalEntity}`).pipe();
  }
  getSubSubExternalEntityAsync = (request: GetSubSubExternalEntityRequestDto): Observable<ApiResponse<EntityTableDto[]>> => {
    return this.httpClient.post<ApiResponse<EntityTableDto[]>>(`${this.serviceUrl}/GetSubSubExternalEntityAsync`, request).pipe();
  }
  getLetterBySearchAsync = (request: LetterAdvancedSearchRequedtDto): Observable<ApiResponse<LetterAdvancedSearchResponse[]>> => {
    return this.httpClient.post<ApiResponse<LetterAdvancedSearchResponse[]>>(`${this.serviceUrl}/GetLetterBySearchAsync`, request).pipe();
  }

  getTransactionAsync = (request: TransactionRequedtDto): Observable<ApiResponse<GetTransactionResponseDto>> => {
    return this.httpClient.post<ApiResponse<GetTransactionResponseDto>>(`${this.serviceUrl}/GetTransactionAsync`, request).pipe();
  }

}
