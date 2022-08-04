import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { RequestChangeStageDto } from '@proxy/requests/models';
import { RequestService } from '@proxy/requests/request.service';
import { GlobalService } from '@shared/services/global.service';
import { Stages } from '@shared/enums/stage.enum';
import { Service } from '@shared/enums/service.enum';
import { RateServiceComponent } from '@shared/components/rate-service/rate-service.component';

@Component({
  selector: 'app-prisoners-services-preview-step',
  templateUrl: './prisoners-services-preview-step.component.html'
})
export class PrisonersServicesPreviewStepComponent implements OnInit {
  @ViewChild(RateServiceComponent, { static: true }) rateServiceComponent: RateServiceComponent;

  wizardItems: MenuItem[];
  activeIndex: number = 2;
  requestId: string;
  serviceId: number = Service.PrisonerTempRelease;
  showServiceRate: boolean = false;
  redirectUrl: string = "/eservice/my-requests";

  constructor(private requestService: RequestService, private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمات السجناء");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }
  sendRequest() {
    this.globalService.showConfirm('هل تريد متأكد من ارسال طلب خدمات السجناء؟');
    this.globalService.confirmSubmit = () => this.isconfirm();
  }

  isconfirm() {
    const requestChangeStageDto = {
      id: this.requestId,
      stageId: Stages.NewRequest,
      notes: ''
    } as RequestChangeStageDto
    this.requestService.changeStage(requestChangeStageDto).subscribe((response) => {
      this.globalService.showMessage(response.message);
      this.showServiceRate = true;
      this.rateServiceComponent.buildForm();
    });
  }
  navigate(event: boolean) {
    if (!event) {
      this.globalService.navigateToRequesterDashboard();
    }
  }
  getWizardItems() {
    if (this.requestId) {
      this.wizardItems = [
        { label: 'بيانات الطلب', url: `/eservice/prisoners-services/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/prisoners-services-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/prisoners-services-preview-step/${this.requestId}` }
      ];
    }
    else {
      this.wizardItems = [
        { label: 'بيانات الطلب' },
        { label: 'المرفقات' },
        { label: 'ارسال الطلب' }
      ];
    }
  }
}
