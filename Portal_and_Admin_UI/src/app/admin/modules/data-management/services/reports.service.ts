import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HelperFunctions } from '@shared/helpers/helper-functions';
import { DataAccessService } from '@shared/services/data-access.service';

@Injectable({
  providedIn: 'root',
})
export class ReportsService extends DataAccessService {
  constructor(
    private _httpClient: HttpClient,
    private _helper: HelperFunctions
  ) {
    super(_httpClient, _helper, `${environment.ApiUrl}/api/News`);
    this.serviceUrl = `${environment.ApiUrl}/api/News`;
  }
}
