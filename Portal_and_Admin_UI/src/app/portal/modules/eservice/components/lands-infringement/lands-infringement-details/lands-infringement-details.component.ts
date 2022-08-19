import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { GetRequestLandsInfringementDetailsDto } from '@shared/proxy/request-lands-infringement/models';
import { RequestLandsInfringementService } from '@shared/proxy/request-lands-infringement/request-lands-infringement.service';

@Component({
  selector: 'app-lands-infringement-details',
  templateUrl: './lands-infringement-details.component.html'
})
export class LandsInfringementDetailsComponent implements OnInit {
  requestId: string;
  requestLandsInfringementDetailsDto = {} as GetRequestLandsInfringementDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestLandsInfringementService: RequestLandsInfringementService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestLandsInfringementService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestLandsInfringementDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }
}
