import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { ApiResponse } from '../shared/api-response.model';
import { GetRequestDetailsDto, GetRequestAttachmentsDto, GetRequestStageLogsDto, GetAttachmentsDto, RequestChangeStageDto } from "./models";
import { SearchModel } from "../shared/search-model.model";


@Injectable({
  providedIn: 'root',
})
export class RequestService {
  serviceUrl: string = `${environment.ApiUrl}/api/Request`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<GetRequestDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetRequestDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  changeStage = (changeStageDto: RequestChangeStageDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/ChangeStage`, changeStageDto).pipe();
  }

  getAttachments = (id: string): Observable<ApiResponse<GetAttachmentsDto[]>> => {
    return this.httpClient.get<ApiResponse<GetAttachmentsDto[]>>(`${this.serviceUrl}/GetAttachments/${id}`).pipe(
    );
  }
  getRequestAttachments = (id: string): Observable<ApiResponse<GetRequestAttachmentsDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRequestAttachmentsDto[]>>(`${this.serviceUrl}/GetRequestAttachments/${id}`).pipe(
    );
  }

  getRequestStageLogs = (id: string): Observable<ApiResponse<GetRequestStageLogsDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRequestStageLogsDto[]>>(`${this.serviceUrl}/GetRequestStageLogs/${id}`).pipe(
    );
  }

  myRequests = (searchModel: SearchModel): Observable<ApiResponse<any>> => {
    return this.httpClient.post<ApiResponse<any>>(`${this.serviceUrl}/MyRequests`, searchModel).pipe();
  }
  inbox = (searchModel: SearchModel): Observable<ApiResponse<any>> => {
    return this.httpClient.post<ApiResponse<any>>(`${this.serviceUrl}/Inbox`, searchModel).pipe();
  }
  inboxShamel = (searchModel: SearchModel): Observable<ApiResponse<any>> => {
    return this.httpClient.post<ApiResponse<any>>(`${this.serviceUrl}/InboxShamel`, searchModel).pipe();
  }
}
