import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { RequestChangeStageDto } from '@proxy/requests/models';
import { RequestService } from '@proxy/requests/request.service';
import { GlobalService } from '@shared/services/global.service';
import { Stages } from '@shared/enums/stage.enum';
import { Service } from '@shared/enums/service.enum';
import { RateServiceComponent } from '@shared/components/rate-service/rate-service.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { ServiceConditionsComponent } from '../../service-conditions/service-conditions.component';

@Component({
  selector: 'app-judgment-execution-preview-step',
  templateUrl: './judgment-execution-preview-step.component.html'
})
export class JudgmentExecutionPreviewStepComponent implements OnInit {
  @ViewChild(RateServiceComponent, { static: true }) rateServiceComponent: RateServiceComponent;
  @ViewChild(ServiceConditionsComponent, { static: true }) serviceConditions: ServiceConditionsComponent;

  wizardItems: MenuItem[];
  activeIndex: number = 2;
  requestId: string;
  serviceId: number = Service.JudgmentExecution;
  showServiceRate: boolean = false;
  redirectUrl: string = "/eservice/my-requests";
  accept: boolean = false;
  showDialog: boolean = false;

  constructor(private requestService: RequestService, private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة انفاذ حكم شرعي");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }
  sendRequest() {
    if (this.accept) {
      this.globalService.showConfirm('هل تريد متأكد من ارسال طلب خدمة انفاذ حكم شرعي؟');
      this.globalService.confirmSubmit = () => this.isconfirm();
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء الموافقة على الشروط والأحكام')
    }
  }
  showConditions() {
    this.serviceConditions.getServiceCondition();
    this.showDialog = true;
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
        { label: 'بيانات الطلب', url: `/eservice/judgment-execution/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/judgment-execution-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/judgment-execution-preview-step/${this.requestId}` }
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
