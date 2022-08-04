import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { CreateServiceDto } from '@proxy/services/models';

@Component({
  selector: 'app-service-add',
  templateUrl: './service-add.component.html'
})
export class ServiceAddComponent implements OnInit {
  createServiceForm: FormGroup;
  isFormSubmitted: boolean;
  createServiceDto = {} as CreateServiceDto;

  //#region for uploader
  @ViewChild('uploader',{static:true}) uploader;
  isMultiple: boolean = false;
  fileSize: number = 1000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private serviceService: ServiceService,
    private fileManagerService: FileManagerService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('اضافة خدمة جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createServiceForm = this.formBuilder.group({
      nameAr: [this.createServiceDto.nameAr || '', Validators.required],
      nameEn: [this.createServiceDto.nameEn || '', Validators.required],
      titleAr: [this.createServiceDto.titleAr || '', Validators.required],
      titleEn: [this.createServiceDto.titleEn || ''],
      descriptionAr: [this.createServiceDto.descriptionAr || '', Validators.required],
      descriptionEn: [this.createServiceDto.descriptionEn || ''],
      workDays: [this.createServiceDto.workDays || null],
      requestLink: [this.createServiceDto.requestLink || '', Validators.required],
      image: [ null, Validators.required],
      isActive: [this.createServiceDto.isActive || true, Validators.required]
    });
  }

  onUpload(event: any) {
    this.createServiceForm.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createServiceForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createServiceForm.valid) {
      this.createServiceDto = { ...this.createServiceForm.value } as CreateServiceDto;
      this.serviceService.create(this.createServiceDto).subscribe((response) => {
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService.upload(id, 'Services', '', [this.createServiceForm.get('image').value]).subscribe(res =>{
            this.globalService.messageAlert(MessageType.Success,'تم الحفظ بنجاح');
            this.globalService.navigate("/admin/data-management/service-list");
          })
        }
      });
    }
  }
}
