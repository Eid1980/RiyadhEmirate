import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { RequestElectronicSummonService } from '@shared/proxy/request-electronic-summon/request-electronic-summon.service';
import { GetRequestElectronicSummonDetailsDto } from '@shared/proxy/request-electronic-summon/models';

@Component({
  selector: 'app-electronic-summon-details',
  templateUrl: './electronic-summon-details.component.html'
})
export class ElectronicSummonDetailsComponent implements OnInit {
  requestId: string;
  requestElectronicSummonDetailsDto = {} as GetRequestElectronicSummonDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestElectronicSummonService: RequestElectronicSummonService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestElectronicSummonService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestElectronicSummonDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }

}
