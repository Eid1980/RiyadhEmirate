import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ApiResponse } from '../shared/api-response.model';
import { GetWomanSectionDto } from './models';

@Injectable({
  providedIn: 'root'
})
export class WomanSectionService {

  serviceUrl: string = `${environment.ApiUrl}/api/WomanSection`;

  constructor(private _httpClient: HttpClient) { }

  getAboutUs() {
    return this._httpClient.get<ApiResponse<GetWomanSectionDto>>(`${this.serviceUrl}`).pipe(
    );
  }

  update = (updatedDto: GetWomanSectionDto): Observable<ApiResponse<number>> => {
    return this._httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }
}
