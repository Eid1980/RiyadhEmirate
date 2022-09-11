import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ApiResponse } from '../shared/api-response.model';
import { CreateMainPoint, GetAboutUsDto } from './models';

@Injectable({
  providedIn: 'root'
})
export class AboutUsService {

  serviceUrl: string = `${environment.ApiUrl}/api/AboutUs`;

  constructor(private _httpClient: HttpClient) { }

  getAboutUs() {
    return this._httpClient.get<ApiResponse<GetAboutUsDto>>(`${this.serviceUrl}`).pipe(
    );
  }

  update = (updatedDto: GetAboutUsDto): Observable<ApiResponse<number>> => {
    return this._httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  createMainPoint(mainPoint : CreateMainPoint ){
    return this._httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/createMainPoint`, mainPoint).pipe();
  }
}
