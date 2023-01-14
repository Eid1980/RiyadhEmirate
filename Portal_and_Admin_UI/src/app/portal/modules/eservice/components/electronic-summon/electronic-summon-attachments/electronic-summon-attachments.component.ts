import { Component, OnInit, ViewChild } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { GlobalService } from '@shared/services/global.service';
import { RequestAttacmentComponent } from '@shared/components/request-attacment/request-attacment.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-electronic-summon-attachments',
  templateUrl: './electronic-summon-attachments.component.html'
})
export class ElectronicSummonAttachmentsComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 1;
  requestId: string;
  @ViewChild(RequestAttacmentComponent, { static: true }) requestAttacmentComponent: RequestAttacmentComponent;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة الاستدعاء الالكتروني");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }

  onSubmit() {
    if (this.requestAttacmentComponent.checkRequiredAttachments()) {
      this.globalService.navigate(`/eservice/electronic-summon-preview-step/${this.requestId}`);
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, "الرجاء استكمال المرفقات المطلوبة")
    }
  }
  getWizardItems() {
    if (this.requestId) {
      this.wizardItems = [
        { label: 'بيانات الطلب', url: `/eservice/electronic-summon/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/electronic-summon-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/electronic-summon-preview-step/${this.requestId}` }
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
