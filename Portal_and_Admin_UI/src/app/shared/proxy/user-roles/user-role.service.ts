import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { GetRolUsersDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class UserRoleService {
  serviceUrl: string = `${environment.ApiUrl}/api/UserRole`;
  constructor(public httpClient: HttpClient) {
  }

  getUsersByRoleId = (roleId: number): Observable<ApiResponse<GetRolUsersDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRolUsersDto[]>>(`${this.serviceUrl}/GetUsersByRoleId/${roleId}`).pipe(
    );
  }

  //create = (createdDto: CreateRoleDto): Observable<ApiResponse<number>> => {
  //  return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  //}
  //update = (updatedDto: UpdateRoleDto): Observable<ApiResponse<number>> => {
  //  return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  //}

  //changeStatus = (id: number): Observable<ApiResponse<boolean>> => {
  //  return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  //}

  //delete = (id: number): Observable<ApiResponse<boolean>> => {
  //  return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  //}

}
