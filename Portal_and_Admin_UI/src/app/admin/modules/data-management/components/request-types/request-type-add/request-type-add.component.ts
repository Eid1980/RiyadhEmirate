import { Component, OnInit } from '@angular/core';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { CreateRequestTypeDto } from '@proxy/request-types/models';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { LookupDto } from '@proxy/shared/lookup-dto.model';

@Component({
  selector: 'app-request-type-add',
  templateUrl: './request-type-add.component.html',
})
export class RequestTypeAddComponent implements OnInit {
  createRequestTypeForm: FormGroup;
  isFormSubmitted: boolean;
  createRequestTypeDto: CreateRequestTypeDto = {} as CreateRequestTypeDto;
  services = [] as LookupDto<number>[];

  constructor(
    private formBuilder: FormBuilder,
    private requestTypeService: RequestTypeService,
    private serviceService: ServiceService,
    private globalService: GlobalService
  ) {}

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة نوع خدمة جديد');
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
  }

  buildForm() {
    this.createRequestTypeForm = this.formBuilder.group({
      nameAr: [this.createRequestTypeDto.nameAr || '', Validators.required],
      nameEn: [this.createRequestTypeDto.nameEn || '', Validators.required],
      serviceId: [
        this.createRequestTypeDto.serviceId || null,
        Validators.required,
      ],
      isActive: [
        this.createRequestTypeDto.isActive || true,
        Validators.required,
      ],
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createRequestTypeForm.valid) {
      this.createRequestTypeDto = {
        ...this.createRequestTypeForm.value,
      } as CreateRequestTypeDto;
      this.requestTypeService
        .create(this.createRequestTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate(
              '/admin/data-management/request-type-list'
            );
          }
        });
    }
  }
}
