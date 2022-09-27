import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RequestService } from '@proxy/requests/request.service';
import { GetAttachmentsDto } from '@proxy/requests/models';
import { GlobalService } from '../../services/global.service';
import { FileManagerService } from '../../services/file-manager.service';
import { MessageType } from '../../enums/message-type.enum';
import { environment } from '../../../../environments/environment';

@Component({
  selector: 'app-request-attacment',
  templateUrl: './request-attacment.component.html'
})
export class RequestAttacmentComponent implements OnInit {
  @Input() allowedExtensions: string = environment.allowedExtensions;
  @Input() fileSize: number = environment.fileSize;
  @Input() serviceName: string = "Request";
  requestId: string;
  serviceId: number;
  attachmentsDto = [] as GetAttachmentsDto[];
  isModalOpen: boolean = false;
  attachment: any;

  constructor(private fileManagerService: FileManagerService, private requestService: RequestService,
    private activatedRoute: ActivatedRoute, public globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getRequestDetails();
    }
    else {
      this.globalService.navigateToRequesterDashboard();
    }
  }


  getRequestDetails() {
    this.requestService.getAttachments(this.requestId).subscribe((response) => {
      this.attachmentsDto = response.data;
      debugger;
    });
  }

  showAttachment(id: string) {
    if (id) {
      this.fileManagerService.getById(id).subscribe((response) => {
        if (response) {
          if (response.extention == '.pdf') {
            this.isModalOpen = false;
            const byteCharacters = atob(response.base64File);
            const byteNumbers = new Array(byteCharacters.length);
            for (let i = 0; i < byteCharacters.length; i++) {
              byteNumbers[i] = byteCharacters.charCodeAt(i);
            }
            const byteArray = new Uint8Array(byteNumbers);
            let file = new window.Blob([byteArray], { type: 'application/pdf' });
            var url = URL.createObjectURL(file);
            var win = window.open();
            win.document.write('<iframe src="' + url + '" frameborder="0" style="border:0; width:100%; height:100%;"></iframe>')
          }
          else {
            this.attachment = response.base64File;
            this.isModalOpen = true;
          }
        }
        else {
          this.globalService.messageAlert(MessageType.Error, 'فشل في عرض المرفق');
        }
      });

    }
  }
  downloadAttachment(id: string) {
    if (id) {
      this.fileManagerService.getById(id).subscribe((response) => {
        if (response) {
          this.fileManagerService.downloadAttachment(response.base64File, response.fileName)
        }
        else {
          this.globalService.messageAlert(MessageType.Error, 'فشل في تنزيل المرفق');
        }
      });
    }
  }
  deleteAttachment(id: string) {
    if (id) {
      this.globalService.showConfirm('هل تريد حذف هذا المرفق؟');
      this.globalService.confirmSubmit = () => this.isconfirm(id);
    }
  }
  isconfirm(id: string) {
    this.fileManagerService.delete(id).subscribe((result) => {
      this.getRequestDetails();
    });
    this.globalService.clearMessages();
  }

  checkRequiredAttachments() {
    return !(this.attachmentsDto.filter(x => x.attachmentIsRequired && !x.isAdded).length > 0);
  }

  onUpload(event: any, requestAttachmentType: string) {
    this.fileManagerService.upload(this.requestId, this.serviceName, requestAttachmentType, event.files).subscribe(res => {
      this.globalService.messageAlert(MessageType.Success, 'تم رفع المرفق بنجاح');
      this.getRequestDetails();
    })
    
  }
}
