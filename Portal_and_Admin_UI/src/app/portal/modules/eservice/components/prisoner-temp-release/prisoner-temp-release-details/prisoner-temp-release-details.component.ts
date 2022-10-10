import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RequestPrisonerTempReleaseService } from '@proxy/request-prisoner-temp-release/request-prisoner-temp-release.service';
import { GetRequestPrisonerTempReleaseDetailsDto } from '@proxy/request-prisoner-temp-release/models';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import * as html2pdf from 'html2pdf.js';

@Component({
  selector: 'app-prisoner-temp-release-details',
  templateUrl: './prisoner-temp-release-details.component.html'
})
export class PrisonerTempReleaseDetailsComponent implements OnInit {
  @ViewChild("RequestData") requestDataDiv: ElementRef;
  requestId: string;
  requestPrisonerTempReleaseDetailsDto = {} as GetRequestPrisonerTempReleaseDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestPrisonerTempReleaseService: RequestPrisonerTempReleaseService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestPrisonerTempReleaseService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestPrisonerTempReleaseDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }

  print() {
    var opt = {
      margin: 1,
      filename: 'output.pdf',
      image: { type: 'jpeg', quality: 0.98 },
      html2canvas: { scale: 3 },
      jsPDF: { unit: 'in', format: 'letter', orientation: 'landscape' },
    };
    html2pdf().set(opt).from(this.requestDataDiv.nativeElement).toPdf().save();

  }

}
