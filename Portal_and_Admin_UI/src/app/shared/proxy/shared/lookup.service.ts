import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root'
})
export class LookupService {
  serviceUrl: string = `${environment.ApiUrl}/api/Lookup`;
  constructor(public httpClient: HttpClient) {
  }

  getMaritalStatusLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetMaritalStatusLookupList`).pipe(
    );
  }
  getGovernorateLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetGovernorateLookupList`).pipe(
    );
  }
  getNationalityLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetNationalityLookupList`).pipe(
    );
  }
}
