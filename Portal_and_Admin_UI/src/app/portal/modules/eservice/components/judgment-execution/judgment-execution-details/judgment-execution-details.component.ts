import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetRequestJudgmentExecutionDetailsDto } from '@shared/proxy/request-judgment-execution/models';
import { RequestJudgmentExecutionService } from '@shared/proxy/request-judgment-execution/request-judgment-execution.service';

@Component({
  selector: 'app-judgment-execution-details',
  templateUrl: './judgment-execution-details.component.html'
})
export class JudgmentExecutionDetailsComponent implements OnInit {
  requestId: string;
  requestJudgmentExecutionDetailsDto = {} as GetRequestJudgmentExecutionDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestJudgmentExecutionService: RequestJudgmentExecutionService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestJudgmentExecutionService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestJudgmentExecutionDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }
}
