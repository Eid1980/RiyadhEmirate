import { Component, OnInit } from '@angular/core';
import { RequestAttachmentTypeService } from '@proxy/request-attachment-types/request-attachment-type.service';
import { CreateRequestAttachmentTypeDto } from '@proxy/request-attachment-types/models';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-request-attachment-type-add',
  templateUrl: './request-attachment-type-add.component.html'
})
export class RequestAttachmentTypeAddComponent implements OnInit {
  createRequestAttachmentTypeForm: FormGroup;
  isFormSubmitted: boolean;
  createRequestAttachmentTypeDto: CreateRequestAttachmentTypeDto = {} as CreateRequestAttachmentTypeDto;
  services = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private requestAttachmentTypeService: RequestAttachmentTypeService,
    private serviceService: ServiceService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مرفق خدمة جديد');
    //this.globalService.changeBreadcrumbItems([
    //  { label: 'مرفقات الخدمات', url:'/data-management/request-attachment-type-list' },
    //  { label: 'إضافة مرفق خدمة جديد' }
    //]);
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
  }

  buildForm() {
    this.createRequestAttachmentTypeForm = this.formBuilder.group({
      nameAr: [this.createRequestAttachmentTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createRequestAttachmentTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      serviceId: [this.createRequestAttachmentTypeDto.serviceId || null, Validators.required],
      extentionAllowed: [this.createRequestAttachmentTypeDto.extentionAllowed || null],
      maxFileSize: [this.createRequestAttachmentTypeDto.maxFileSize || null],
      isRequired: [this.createRequestAttachmentTypeDto.isRequired || true, Validators.required],
      isActive: [this.createRequestAttachmentTypeDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createRequestAttachmentTypeForm.valid) {
      this.createRequestAttachmentTypeDto = { ...this.createRequestAttachmentTypeForm.value } as CreateRequestAttachmentTypeDto;
      this.requestAttachmentTypeService.create(this.createRequestAttachmentTypeDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/request-attachment-type-list");
          }
        });
    }
  }

}
