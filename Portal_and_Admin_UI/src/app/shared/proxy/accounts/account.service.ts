import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { GetUserDto, UserLoginDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { JsonPipe } from '@angular/common';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  serviceUrl: string = `${environment.ApiUrl}/api/Account`;
  constructor(public httpClient: HttpClient, private router: Router) {
  }

  login = (userLoginDto: UserLoginDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Login`, userLoginDto).pipe(
    );
  }

  //isAuthorizedComponent = (componentURL): Observable<ApiResponse<GetUserDto>> => {
  //  return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/IsAuthorizedComponent`).pipe(
  //  );
  //}
  //isAuthorizedComponent(componentURL) {
  //  return this.httpClient
  //    .get(`${this.serviceUrl}/IsAuthorizedComponent`, {
  //      params: { componentUrl: encodeURI(componentURL) },
  //    })
  //    .pipe(
  //      map((result: ResponseVM) => {
  //        const serviceResponse: ServiceResponseVM = {
  //          IsSuccess: result.isSuccess,
  //          Data: result.data,
  //        };
  //        return serviceResponse;
  //      })
  //    );
  //}

  isAuthorizedPermission = (code: string): boolean => {
    if (localStorage.getItem('AuthUser') != null) {
      const codes = (localStorage.getItem('AuthUser') as any).PermissionCodes;
      return codes.includes(code) || code === '*' || !code || code === '';
    }
    else {
      return false;
    }
  }

  logOut = (): void => {
    localStorage.removeItem('Employee_Token');
    this.router.navigate(['/auth']);
  }

  getCurrentUserInfo = (): GetUserDto => {
    if (localStorage.getItem('AuthUser') != null) {
      return JSON.parse(localStorage.getItem('AuthUser'));
    }
    else {
      this.router.navigate(['/auth']);
      return null;
    }
  }

  getAuthUser = (): Observable<ApiResponse<GetUserDto>> => {
    return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/GetAuthUser`).pipe(
    );
  }
  getById = (id: number): Observable<ApiResponse<GetUserDto>> => {
    return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

}
