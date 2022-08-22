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

@Component({
  selector: 'app-foreigners-realty-owner-preview-step',
  templateUrl: './foreigners-realty-owner-preview-step.component.html'
})
export class ForeignersRealtyOwnerPreviewStepComponent implements OnInit {
  @ViewChild(RateServiceComponent, { static: true }) rateServiceComponent: RateServiceComponent;

  wizardItems: MenuItem[];
  activeIndex: number = 2;
  requestId: string;
  serviceId: number = Service.ForeignersRealtyOwner;
  showServiceRate: boolean = false;
  redirectUrl: string = "/eservice/my-requests";
  accept: boolean = false;

  constructor(private requestService: RequestService, private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة تملك العقار للأجانب");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }
  sendRequest() {
    if (this.accept) {
      this.globalService.showConfirm('هل تريد متأكد من ارسال طلب خدمة تملك العقار للأجانب؟');
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
        { label: 'بيانات الطلب', url: `/eservice/foreigners-realty-owner/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/foreigners-realty-owner-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/foreigners-realty-owner-preview-step/${this.requestId}` }
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
