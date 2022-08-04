import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetRequestPrisonersServiceDetailsDto } from '@proxy/request-prisoners-services/models';
import { RequestPrisonersServicesService } from '@proxy/request-prisoners-services/request-prisoners-services.service';

@Component({
  selector: 'app-prisoners-services-details',
  templateUrl: './prisoners-services-details.component.html'
})
export class PrisonersServicesDetailsComponent implements OnInit {
  requestId: string;
  requestPrisonersServiceDetailsDto = {} as GetRequestPrisonersServiceDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestPrisonersServicesService: RequestPrisonersServicesService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestPrisonersServicesService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestPrisonersServiceDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }
}
