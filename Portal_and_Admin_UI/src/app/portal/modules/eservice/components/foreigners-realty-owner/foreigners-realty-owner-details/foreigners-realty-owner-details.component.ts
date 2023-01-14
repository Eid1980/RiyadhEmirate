import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetRequestForeignersRealtyOwnerDetailsDto } from '@shared/proxy/request-foreigners-realty-owner/models';
import { RequestForeignersRealtyOwnerService } from '@shared/proxy/request-foreigners-realty-owner/request-foreigners-realty-owner.service';

@Component({
  selector: 'app-foreigners-realty-owner-details',
  templateUrl: './foreigners-realty-owner-details.component.html'
})
export class ForeignersRealtyOwnerDetailsComponent implements OnInit {
  requestId: string;
  requestForeignersRealtyOwnerDetailsDto = {} as GetRequestForeignersRealtyOwnerDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestForeignersRealtyOwnerService: RequestForeignersRealtyOwnerService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestForeignersRealtyOwnerService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestForeignersRealtyOwnerDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }
}
