import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { RateServiceComponent } from '@shared/components/rate-service/rate-service.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { Service } from '@shared/enums/service.enum';
import { Stages } from '@shared/enums/stage.enum';
import { RequestService } from '@shared/proxy/requests/request.service';
import { GlobalService } from '@shared/services/global.service';
import { RequestChangeStageDto } from '@shared/proxy/requests/models';

@Component({
  selector: 'app-lands-infringement-preview-step',
  templateUrl: './lands-infringement-preview-step.component.html'
})
export class LandsInfringementPreviewStepComponent implements OnInit {
  @ViewChild(RateServiceComponent, { static: true }) rateServiceComponent: RateServiceComponent;

  wizardItems: MenuItem[];
  activeIndex: number = 2;
  requestId: string;
  serviceId: number = Service.PrisonerTempRelease;
  showServiceRate: boolean = false;
  redirectUrl: string = "/eservice/my-requests";
  accept: boolean = false;

  constructor(private requestService: RequestService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة التعدي على الأراضي الحكومية");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }
  sendRequest() {
    if (this.accept) {
      this.globalService.showConfirm('هل تريد متأكد من ارسال طلب تعدي على الأراضي الحكومية؟');
      this.globalService.confirmSubmit = () => this.isconfirm();
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء الموافقة على الشروط والأحكام')
    }
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
    this.globalService.clearMessages();
  }
  navigate(event: boolean) {
    if (!event) {
      this.globalService.navigateToRequesterDashboard();
    }
  }
  getWizardItems() {
    if (this.requestId) {
      this.wizardItems = [
        { label: 'بيانات الطلب', url: `/eservice/lands-infringement/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/lands-infringement-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/lands-infringement-preview-step/${this.requestId}` }
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
