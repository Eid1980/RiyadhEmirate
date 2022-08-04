import { Component, Input, OnInit } from '@angular/core';
import { RequestService } from '@proxy/requests/request.service';
import { GetRequestStageLogsDto } from '@proxy/requests/models';

@Component({
  selector: 'app-request-stage-log',
  templateUrl: './request-stage-log.component.html'
})
export class RequestStageLogComponent implements OnInit {
  @Input() requestId: string;
  requestStageLogsDto = [] as GetRequestStageLogsDto[];

  constructor(private requestService: RequestService)
  {
  }

  ngOnInit(): void {
    if (this.requestId) {
      this.requestService.getRequestStageLogs(this.requestId).subscribe((response) => {
        this.requestStageLogsDto = response.data;
      });
    }
  }

}
