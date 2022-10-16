import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateOpenDataReportDto } from '@proxy/open-data-reports/models';
import { OpenDataReportService } from '@proxy/open-data-reports/open-data-report.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { OpenDataCategueryService } from '@shared/proxy/open-data-categueries/open-data-categuery.service';

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

  constructor(private formBuilder: FormBuilder, private openDataReportService: OpenDataReportService,
    private openDataCategueryService: OpenDataCategueryService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
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
      fileUrl: [this.updateOpenDataReportDto.fileUrl || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateOpenDataReportDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.openDataReportService.getById(this.id).subscribe((response) => {
      this.updateOpenDataReportDto = response.data as UpdateOpenDataReportDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateOpenDataReportForm.valid) {
      this.updateOpenDataReportDto = { ...this.updateOpenDataReportForm.value } as UpdateOpenDataReportDto;
      this.updateOpenDataReportDto.id = this.id;
      this.openDataReportService.update(this.updateOpenDataReportDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/open-data-report-list");
          }
        });
    }
  }
}
