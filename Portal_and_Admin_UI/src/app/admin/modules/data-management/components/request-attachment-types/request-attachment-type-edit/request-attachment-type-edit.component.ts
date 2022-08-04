import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GetRequestAttachmentTypeDetailsDto, UpdateRequestAttachmentTypeDto } from '@proxy/request-attachment-types/models';
import { RequestAttachmentTypeService } from '@proxy/request-attachment-types/request-attachment-type.service';
import { GlobalService } from '@shared/services/global.service';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ServiceService } from '@proxy/services/service.service';

@Component({
  selector: 'app-request-attachment-type-edit',
  templateUrl: './request-attachment-type-edit.component.html'
})
export class RequestAttachmentTypeEditComponent implements OnInit {
  id: number;
  updateRequestAttachmentTypeForm: FormGroup;
  isFormSubmitted: boolean;
  updateRequestAttachmentTypeDto: UpdateRequestAttachmentTypeDto = {} as UpdateRequestAttachmentTypeDto;
  requestAttachmentTypeDetailsDto: GetRequestAttachmentTypeDetailsDto;
  services = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private requestAttachmentTypeService: RequestAttachmentTypeService,
    private serviceService: ServiceService, 
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل مرفق خدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.id) {
      this.getDetails();
      this.serviceService.getLookupList().subscribe((response) => {
        this.services = response.data;
      });
    }
    else {
      this.globalService.navigate("/admin/data-management/request-attachment-type-list");
    }
  }

  buildForm() {
    this.updateRequestAttachmentTypeForm = this.formBuilder.group({
      nameAr: [this.updateRequestAttachmentTypeDto.nameAr || '', Validators.required],
      nameEn: [this.updateRequestAttachmentTypeDto.nameEn || '', Validators.required],
      serviceId: [this.updateRequestAttachmentTypeDto.serviceId || null, Validators.required],
      extentionAllowed: [this.updateRequestAttachmentTypeDto.extentionAllowed || null],
      maxFileSize: [this.updateRequestAttachmentTypeDto.maxFileSize || null],
      isRequired: [this.updateRequestAttachmentTypeDto.isRequired, Validators.required],
      isActive: [this.updateRequestAttachmentTypeDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.requestAttachmentTypeService.getById(this.id).subscribe((response) => {
      this.updateRequestAttachmentTypeDto = response.data as UpdateRequestAttachmentTypeDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateRequestAttachmentTypeForm.valid) {
      this.updateRequestAttachmentTypeDto = { ...this.updateRequestAttachmentTypeForm.value } as UpdateRequestAttachmentTypeDto;
      this.updateRequestAttachmentTypeDto.id = this.id;
      this.requestAttachmentTypeService.update(this.updateRequestAttachmentTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/request-attachment-type-list");
          }
        });
    }
  }

}
