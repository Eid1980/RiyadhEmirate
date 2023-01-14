import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OpenDataReportService } from '@proxy/open-data-reports/open-data-report.service';
import { GetOpenDataReportDetailsDto } from '@proxy/open-data-reports/models';
import { GlobalService } from '@shared/services/global.service';
import { FileManagerService } from '@shared/services/file-manager.service';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-open-data-report-view',
  templateUrl: './open-data-report-view.component.html'
})
export class OpenDataReportViewComponent implements OnInit {
  id: number;
  openDataReportDetailsDto = {} as GetOpenDataReportDetailsDto;

  constructor(private openDataReportService: OpenDataReportService,
    private globalService: GlobalService, private fileManagerService: FileManagerService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل التقرير');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.openDataReportService.getById(this.id).subscribe((response) => {
      this.openDataReportDetailsDto = response.data;
    });
  }
  downloadAttachment() {
    if (this.openDataReportDetailsDto.fileId) {
      this.fileManagerService.getById(this.openDataReportDetailsDto.fileId).subscribe((response) => {
        if (response) {
          this.fileManagerService.downloadAttachment(response.base64File, response.fileName);
        }
        else {
          this.globalService.messageAlert(MessageType.Error, 'فشل في تنزيل المرفق');
        }
      });
    }
  }
}
