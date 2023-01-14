import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateContactUsMessageDto, GetContactUsMessageDetailsDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class ContactUsMessageService {
  serviceUrl: string = `${environment.ApiUrl}/api/ContactUsMessage`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetContactUsMessageDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetContactUsMessageDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateContactUsMessageDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
