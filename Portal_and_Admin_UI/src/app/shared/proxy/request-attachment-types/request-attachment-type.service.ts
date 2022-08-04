import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateRequestAttachmentTypeDto, GetRequestAttachmentTypeDetailsDto, GetRequestAttachmentTypeListDto, UpdateRequestAttachmentTypeDto } from './models';
import { ApiResponse } from '../shared/api-response.model';

@Injectable({
  providedIn: 'root',
})
export class RequestAttachmentTypeService {
  serviceUrl: string = `${environment.ApiUrl}/api/RequestAttachmentType`;
  constructor(public httpClient: HttpClient)
  {
  }

  getById = (id: number): Observable<ApiResponse<GetRequestAttachmentTypeDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestAttachmentTypeDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getByServiceId = (serviceId: number): Observable<ApiResponse<GetRequestAttachmentTypeListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRequestAttachmentTypeListDto[]>>(`${this.serviceUrl}/GetByServiceId/${serviceId}`).pipe(
    );
  }

  create = (createdDto: CreateRequestAttachmentTypeDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateRequestAttachmentTypeDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }
  changeRequire = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeRequire/${id}`).pipe();
  }

}
