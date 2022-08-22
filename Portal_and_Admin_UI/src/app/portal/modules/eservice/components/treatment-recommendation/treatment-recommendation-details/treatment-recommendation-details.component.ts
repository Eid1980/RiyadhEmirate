import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetRequestTreatmentRecommendationDetailsDto } from '@shared/proxy/request-treatment-recommendation/models';
import { RequestTreatmentRecommendationService } from '@shared/proxy/request-treatment-recommendation/request-treatment-recommendation.service';


@Component({
  selector: 'app-treatment-recommendation-details',
  templateUrl: './treatment-recommendation-details.component.html'
})
export class TreatmentRecommendationDetailsComponent implements OnInit {
  requestId: string;
  requestTreatmentRecommendationDetailsDto = {} as GetRequestTreatmentRecommendationDetailsDto;
  @Input() showStatusLog: boolean = true;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;

  constructor(private requestTreatmentRecommendationService: RequestTreatmentRecommendationService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getDetails();
  }

  getDetails() {
    this.requestTreatmentRecommendationService.getDetailsById(this.requestId).subscribe((response) => {
      if (!this.showStatusLog && !response.data.canEdit) {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
      this.requestTreatmentRecommendationDetailsDto = response.data;
      this.userDataView.initializeForm(response.data.createdBy);
    });
  }
}
