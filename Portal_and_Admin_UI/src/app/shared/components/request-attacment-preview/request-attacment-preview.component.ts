import { Component, Input, OnInit } from '@angular/core';
import { RequestService } from '@proxy/requests/request.service';
import { GetRequestAttachmentsDto } from '@proxy/requests/models';
import { FileManagerService } from '../../services/file-manager.service';
import { GlobalService } from '../../services/global.service';
import { MessageType } from '../../enums/message-type.enum';

@Component({
  selector: 'app-request-attacment-preview',
  templateUrl: './request-attacment-preview.component.html'
})
export class RequestAttacmentPreviewComponent implements OnInit {
  @Input() requestId: string;
  requestAttachmentsDto = [] as GetRequestAttachmentsDto[];
  isModalOpen: boolean = false;
  attachment: any;

  constructor(private requestService: RequestService, private fileManagerService: FileManagerService,
    public globalService: GlobalService) {
  }

  ngOnInit(): void {
    if (this.requestId) {
      this.requestService.getRequestAttachments(this.requestId).subscribe((response) => {
        debugger
        this.requestAttachmentsDto = response.data;
      });
    }
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
  /*
  downloadAttachment(id: string) {
    if (id) {
      this.fileManagerService.download(id);
    }
  }
*/

}
