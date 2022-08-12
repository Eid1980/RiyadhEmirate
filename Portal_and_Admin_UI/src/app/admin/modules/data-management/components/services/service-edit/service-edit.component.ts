import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { UpdateServiceDto } from '@proxy/services/models';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-service-edit',
  templateUrl: './service-edit.component.html',
})
export class ServiceEditComponent implements OnInit {
  updateServiceForm: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  updateServiceDto = {} as UpdateServiceDto;
  oldImage: any;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 1000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(
    private formBuilder: FormBuilder,
    private serviceService: ServiceService,
    private fileManagerService: FileManagerService,
    private globalService: GlobalService,
    private activatedRoute: ActivatedRoute,
    public sanitizer: DomSanitizer
  ) {}

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/service-list');
    }
  }

  buildForm() {
    this.updateServiceForm = this.formBuilder.group({
      nameAr: [this.updateServiceDto.nameAr || '', Validators.required],
      nameEn: [this.updateServiceDto.nameEn || '', Validators.required],
      titleAr: [this.updateServiceDto.titleAr || '', Validators.required],
      titleEn: [this.updateServiceDto.titleEn || ''],
      descriptionAr: [
        this.updateServiceDto.descriptionAr || '',
        Validators.required,
      ],
      descriptionEn: [this.updateServiceDto.descriptionEn || ''],
      workDays: [this.updateServiceDto.workDays || null],
      requestLink: [
        this.updateServiceDto.requestLink || '',
        Validators.required,
      ],
      image: [null],
      isActive: [this.updateServiceDto.isActive, Validators.required],
    });
  }
  onUpload(event: any) {
    this.updateServiceForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateServiceForm.get('image').setValue(null);
  }

  getDetails() {
    this.serviceService.getById(this.id).subscribe((response) => {
      this.updateServiceDto = response.data as UpdateServiceDto;
      this.buildForm();
      this.oldImage = response.data.image;
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateServiceForm.valid) {
      this.updateServiceDto = {
        ...this.updateServiceForm.value,
      } as UpdateServiceDto;
      this.updateServiceDto.id = this.id;
      this.serviceService
        .update(this.updateServiceDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            if (this.updateServiceForm.get('image').value) {
              this.fileManagerService
                .deleteByEntityName(this.id.toString(), 'Services')
                .subscribe((res) => {
                  this.fileManagerService
                    .upload(this.id.toString(), 'Services', '', [
                      this.updateServiceForm.get('image').value,
                    ])
                    .subscribe((res) => {
                      this.globalService.navigate(
                        '/admin/data-management/service-list'
                      );
                    });
                });
            } else {
              this.globalService.navigate(
                '/admin/data-management/service-list'
              );
            }
          }
        });
    }
  }
}
