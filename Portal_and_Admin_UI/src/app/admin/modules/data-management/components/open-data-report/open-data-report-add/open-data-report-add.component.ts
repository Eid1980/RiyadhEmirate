import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { CreateOpenDataReportDto } from '@proxy/open-data-reports/models';
import { OpenDataReportService } from '@proxy/open-data-reports/open-data-report.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { OpenDataCategueryService } from '@shared/proxy/open-data-categueries/open-data-categuery.service';

@Component({
  selector: 'app-open-data-report-add',
  templateUrl: './open-data-report-add.component.html'
})
export class OpenDataReportAddComponent implements OnInit {
  createOpenDataReportForm: FormGroup;
  isFormSubmitted: boolean;
  createOpenDataReportDto = {} as CreateOpenDataReportDto;
  openDataCategueries = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private openDataReportService: OpenDataReportService,
    private openDataCategueryService: OpenDataCategueryService, private globalService: GlobalService) {
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
      fileUrl: [this.createOpenDataReportDto.fileUrl || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createOpenDataReportDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createOpenDataReportForm.valid) {
      this.createOpenDataReportDto = { ...this.createOpenDataReportForm.value } as CreateOpenDataReportDto;
      this.openDataReportService.create(this.createOpenDataReportDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/open-data-report-list");
          }
        });
    }
  }
}
