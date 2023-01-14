import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateOpenDataReportDto } from '@proxy/open-data-reports/models';
import { OpenDataReportService } from '@proxy/open-data-reports/open-data-report.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { OpenDataCategueryService } from '@shared/proxy/open-data-categueries/open-data-categuery.service';
import { environment } from 'src/environments/environment';
import { FileManagerService } from '@shared/services/file-manager.service';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-open-data-report-edit',
  templateUrl: './open-data-report-edit.component.html'
})
export class OpenDataReportEditComponent implements OnInit {
  id: number;
  updateOpenDataReportForm: FormGroup;
  isFormSubmitted: boolean;
  updateOpenDataReportDto = {} as UpdateOpenDataReportDto;
  openDataCategueries = [] as LookupDto<number>[];
  fileId: string;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.openDataFileSize ? environment.openDataFileSize : 6000000;
  acceptType: string = environment.openDataAllowedExtensions ? environment.openDataAllowedExtensions : '.xlsx,.xls';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private openDataReportService: OpenDataReportService,
    private openDataCategueryService: OpenDataCategueryService, private fileManagerService: FileManagerService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل بيانات التقرير');
    this.openDataCategueryService.getLookupList().subscribe((response) => {
      this.openDataCategueries = response.data;
    });
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/open-data-report-list");
    }
  }

  buildForm() {
    this.updateOpenDataReportForm = this.formBuilder.group({
      nameAr: [this.updateOpenDataReportDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateOpenDataReportDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      openDataCategueryId: [this.updateOpenDataReportDto.openDataCategueryId || null, [Validators.required]],
      fileAttach: [null],
      isActive: [this.updateOpenDataReportDto.isActive, Validators.required]
    });
  }

  onUpload(event: any) {
    this.updateOpenDataReportForm.get('fileAttach').setValue(event.files[0]);
  }

  onRemove(event) {
    this.updateOpenDataReportForm.get('fileAttach').setValue(null);
  }
  downloadAttachment() {
    if (this.fileId) {
      this.fileManagerService.getById(this.fileId).subscribe((response) => {
        if (response) {
          this.fileManagerService.downloadAttachment(response.base64File, response.fileName);
        }
        else {
          this.globalService.messageAlert(MessageType.Error, 'فشل في تنزيل المرفق');
        }
      });
    }
  }

  getDetails() {
    this.openDataReportService.getById(this.id).subscribe((response) => {
      this.updateOpenDataReportDto = response.data as UpdateOpenDataReportDto;
      this.fileId = response.data.fileId;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateOpenDataReportForm.valid) {
      this.updateOpenDataReportDto = { ...this.updateOpenDataReportForm.value } as UpdateOpenDataReportDto;
      this.updateOpenDataReportDto.id = this.id;
      this.openDataReportService.update(this.updateOpenDataReportDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            let fileContent = this.updateOpenDataReportForm.get('fileAttach').value;
            if (fileContent) {
              this.fileManagerService.deleteByEntityName(this.id, 'OpenData').subscribe((res) => {
                this.fileManagerService.upload(response.data.toString(), 'OpenData', '', [fileContent]).subscribe(res => {
                  this.globalService.navigate("/admin/data-management/open-data-report-list");
                });
              });
            }
            else {
              this.globalService.navigate("/admin/data-management/open-data-report-list");
            }
          }
        });
    }
  }
}
