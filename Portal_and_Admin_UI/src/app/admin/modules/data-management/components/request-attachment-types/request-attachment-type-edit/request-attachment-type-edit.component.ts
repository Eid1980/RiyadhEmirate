import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GetRequestAttachmentTypeDetailsDto, UpdateRequestAttachmentTypeDto } from '@proxy/request-attachment-types/models';
import { RequestAttachmentTypeService } from '@proxy/request-attachment-types/request-attachment-type.service';
import { GlobalService } from '@shared/services/global.service';
import { LookupDto, LookupExtention } from '@proxy/shared/lookup-dto.model';
import { ServiceService } from '@proxy/services/service.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupService } from '@shared/proxy/shared/lookup.service';

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
  extentions = [] as LookupExtention[];
  selectedExtentions = [] as string[];

  constructor(private formBuilder: FormBuilder, private requestAttachmentTypeService: RequestAttachmentTypeService,
    private serviceService: ServiceService, private lookupService: LookupService, 
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
      this.extentions = this.lookupService.getExtentionList();
    }
    else {
      this.globalService.navigate("/admin/data-management/request-attachment-type-list");
    }
  }

  buildForm() {
    this.updateRequestAttachmentTypeForm = this.formBuilder.group({
      nameAr: [this.updateRequestAttachmentTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateRequestAttachmentTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      serviceId: [this.updateRequestAttachmentTypeDto.serviceId || null, Validators.required],
      extentionAllowed: [this.updateRequestAttachmentTypeDto.extentionAllowed || null],
      selectedExtentions: [this.selectedExtentions],
      maxFileSize: [this.updateRequestAttachmentTypeDto.maxFileSize || null],
      isRequired: [this.updateRequestAttachmentTypeDto.isRequired, Validators.required],
      isActive: [this.updateRequestAttachmentTypeDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.requestAttachmentTypeService.getById(this.id).subscribe((response) => {
      this.updateRequestAttachmentTypeDto = response.data as UpdateRequestAttachmentTypeDto;
      if (this.updateRequestAttachmentTypeDto.extentionAllowed) {
        this.selectedExtentions = this.updateRequestAttachmentTypeDto.extentionAllowed.split(',');
      }
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateRequestAttachmentTypeForm.valid) {
      this.updateRequestAttachmentTypeDto = { ...this.updateRequestAttachmentTypeForm.value } as UpdateRequestAttachmentTypeDto;
      this.updateRequestAttachmentTypeDto.id = this.id;
      if (this.updateRequestAttachmentTypeForm.value.selectedExtentions.length > 0) {
        this.updateRequestAttachmentTypeDto.extentionAllowed = this.updateRequestAttachmentTypeForm.value.selectedExtentions.toString();
      }
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
