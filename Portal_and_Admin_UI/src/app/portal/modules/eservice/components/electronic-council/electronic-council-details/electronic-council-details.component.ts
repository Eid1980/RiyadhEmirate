import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { GetRequestElectronicBoardDetailsDto } from '@shared/proxy/request-electronic-board/models';
import { RequestElectronicBoardService } from '@shared/proxy/request-electronic-board/request-electronic-board.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-electronic-council-details',
  templateUrl: './electronic-council-details.component.html',
  styleUrls: ['./electronic-council-details.component.scss']
})
export class ElectronicCouncilDetailsComponent implements OnInit {
  requestId: string;
  requestElectronicBoardDetailsDto = {} as GetRequestElectronicBoardDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestElectronicBoardService: RequestElectronicBoardService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    console.log('electronic-council-details')
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    debugger
    console.log('getDetailsById')
    this.requestElectronicBoardService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestElectronicBoardDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }

}
