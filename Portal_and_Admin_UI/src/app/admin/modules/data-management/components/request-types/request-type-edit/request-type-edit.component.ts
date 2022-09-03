import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { UpdateRequestTypeDto } from '@proxy/request-types/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-request-type-edit',
  templateUrl: './request-type-edit.component.html',
})
export class RequestTypeEditComponent implements OnInit {
  id: number;
  updateRequestTypeForm: FormGroup;
  isFormSubmitted: boolean;
  updateRequestTypeDto = {} as UpdateRequestTypeDto;
  services = [] as LookupDto<number>[];

  constructor(
    private formBuilder: FormBuilder,
    private requestTypeService: RequestTypeService,
    private serviceService: ServiceService,
    private activatedRoute: ActivatedRoute,
    private globalService: GlobalService
  ) {}

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل نوع الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.id) {
      this.getDetails();
      this.serviceService.getLookupList().subscribe((response) => {
        this.services = response.data;
      });
    } else {
      this.globalService.navigate('/admin/data-management/request-type-list');
    }
  }

  buildForm() {
    this.updateRequestTypeForm = this.formBuilder.group({
      nameAr: [this.updateRequestTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateRequestTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      serviceId: [
        this.updateRequestTypeDto.serviceId || null,
        Validators.required,
      ],
      isActive: [this.updateRequestTypeDto.isActive, Validators.required],
    });
  }

  getDetails() {
    this.requestTypeService.getById(this.id).subscribe((response) => {
      this.updateRequestTypeDto = response.data as UpdateRequestTypeDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateRequestTypeForm.valid) {
      this.updateRequestTypeDto = {
        ...this.updateRequestTypeForm.value,
      } as UpdateRequestTypeDto;
      this.updateRequestTypeDto.id = this.id;
      this.requestTypeService
        .update(this.updateRequestTypeDto)
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
