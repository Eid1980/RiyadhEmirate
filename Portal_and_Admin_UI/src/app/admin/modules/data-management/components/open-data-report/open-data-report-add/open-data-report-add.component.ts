import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { CreateOpenDataReportDto } from '@proxy/open-data-reports/models';
import { OpenDataReportService } from '@proxy/open-data-reports/open-data-report.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { OpenDataCategueryService } from '@shared/proxy/open-data-categueries/open-data-categuery.service';
import { environment } from 'src/environments/environment';
import { FileManagerService } from '@shared/services/file-manager.service';

@Component({
  selector: 'app-open-data-report-add',
  templateUrl: './open-data-report-add.component.html'
})
export class OpenDataReportAddComponent implements OnInit {
  createOpenDataReportForm: FormGroup;
  isFormSubmitted: boolean;
  createOpenDataReportDto = {} as CreateOpenDataReportDto;
  openDataCategueries = [] as LookupDto<number>[];

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
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة تقرير جديد');
    this.openDataCategueryService.getLookupList().subscribe((response) => {
      this.openDataCategueries = response.data;
    });
    this.buildForm();
  }

  buildForm() {
    this.createOpenDataReportForm = this.formBuilder.group({
      nameAr: [this.createOpenDataReportDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createOpenDataReportDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      openDataCategueryId: [this.createOpenDataReportDto.openDataCategueryId || null, [Validators.required]],
      fileAttach: [null, Validators.required],
      isActive: [this.createOpenDataReportDto.isActive || true, Validators.required]
    });
  }

  onUpload(event: any) {
    this.createOpenDataReportForm.get('fileAttach').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createOpenDataReportForm.get('fileAttach').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createOpenDataReportForm.valid) {
      this.createOpenDataReportDto = { ...this.createOpenDataReportForm.value } as CreateOpenDataReportDto;
      this.openDataReportService.create(this.createOpenDataReportDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            let fileContent = this.createOpenDataReportForm.get('fileAttach').value;
            if (fileContent) {
              this.fileManagerService.upload(response.data.toString(), 'OpenData', '', [fileContent]).subscribe(res => {
                this.globalService.navigate("/admin/data-management/open-data-report-list");
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
