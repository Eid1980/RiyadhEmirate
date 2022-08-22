import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetRequestMarriageCertificateDetailsDto } from '@shared/proxy/request-marriage-certificate/models';
import { RequestMarriageCertificateService } from '@shared/proxy/request-marriage-certificate/request-marriage-certificate.service';


@Component({
  selector: 'app-marriage-certificate-details',
  templateUrl: './marriage-certificate-details.component.html'
})
export class MarriageCertificateDetailsComponent implements OnInit {
  requestId: string;
  requestMarriageCertificateDetailsDto = {} as GetRequestMarriageCertificateDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestMarriageCertificateService: RequestMarriageCertificateService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestMarriageCertificateService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestMarriageCertificateDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }

}
