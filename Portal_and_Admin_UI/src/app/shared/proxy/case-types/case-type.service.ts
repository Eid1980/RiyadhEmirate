import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateCaseTypeDto, GetCaseTypeDetailsDto, UpdateCaseTypeDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root',
})
export class CaseTypeService {
  serviceUrl: string = `${environment.ApiUrl}/api/CaseType`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: number): Observable<ApiResponse<GetCaseTypeDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetCaseTypeDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateCaseTypeDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateCaseTypeDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  getLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
    );
  }

}
