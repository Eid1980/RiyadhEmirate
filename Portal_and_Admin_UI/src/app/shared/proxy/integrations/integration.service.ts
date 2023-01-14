import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { SendEmailRequest, SendSMSRequest } from './models';

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

}
