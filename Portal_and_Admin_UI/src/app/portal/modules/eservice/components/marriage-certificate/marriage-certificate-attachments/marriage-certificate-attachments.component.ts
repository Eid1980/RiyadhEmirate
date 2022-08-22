import { Component, OnInit, ViewChild } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { GlobalService } from '@shared/services/global.service';
import { RequestAttacmentComponent } from '@shared/components/request-attacment/request-attacment.component';
import { MessageType } from '@shared/enums/message-type.enum';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-marriage-certificate-attachments',
  templateUrl: './marriage-certificate-attachments.component.html'
})
export class MarriageCertificateAttachmentsComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 1;
  requestId: string;
  @ViewChild(RequestAttacmentComponent, { static: true }) requestAttacmentComponent: RequestAttacmentComponent;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة توثيق زواج");
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }

  onSubmit() {
    if (this.requestAttacmentComponent.checkRequiredAttachments()) {
      this.globalService.navigate(`/eservice/marriage-certificate-preview-step/${this.requestId}`);
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, "الرجاء استكمال المرفقات المطلوبة")
    }
  }
  getWizardItems() {
    if (this.requestId) {
      this.wizardItems = [
        { label: 'بيانات الطلب', url: `/eservice/marriage-certificate/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/marriage-certificate-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/marriage-certificate-preview-step/${this.requestId}` }
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
