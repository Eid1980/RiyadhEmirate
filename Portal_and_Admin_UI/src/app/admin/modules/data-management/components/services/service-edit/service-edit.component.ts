import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { UpdateServiceDto } from '@proxy/services/models';
import { DomSanitizer } from '@angular/platform-browser';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-service-edit',
  templateUrl: './service-edit.component.html',
})
export class ServiceEditComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
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
  ) { }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/service-list');
    }
    this.getWizardItems();
  }

  buildForm() {
    this.updateServiceForm = this.formBuilder.group({
      nameAr: [this.updateServiceDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateServiceDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      sectorAr: [this.updateServiceDto.sectorAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      sectorEn: [this.updateServiceDto.sectorEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionAr: [this.updateServiceDto.descriptionAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionEn: [this.updateServiceDto.descriptionEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      requestLink: [this.updateServiceDto.requestLink || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      workDays: [this.updateServiceDto.workDays || null],
      cost: [this.updateServiceDto.cost || null],
      image: [null],
      isActive: [this.updateServiceDto.isActive || true, Validators.required],
      isExternal: [this.updateServiceDto.isExternal || false, Validators.required]
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
      this.updateServiceDto = { ...this.updateServiceForm.value } as UpdateServiceDto;
      this.updateServiceDto.id = this.id;
      this.serviceService.update(this.updateServiceDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (this.updateServiceForm.get('image').value) {
            this.fileManagerService.deleteByEntityName(this.id.toString(), 'Services').subscribe((res) => {
              this.fileManagerService.upload(this.id.toString(), 'Services', '', [this.updateServiceForm.get('image').value]).subscribe((res) => {
              });
            });
          }
          this.globalService.navigate(`/admin/data-management/service-audience/${this.id}`);
        }
      });
    }
  }

  getWizardItems() {
    this.wizardItems = [
      { label: 'البيانات الأساسية', url: `/data-management/service-edit/${this.id}` },
      { label: 'الجمهور المستهدف', url: `/data-management/service-audience/${this.id}` },
      { label: 'شروط ووثائق الخدمة', url: `/data-management/service-condition/${this.id}` }
    ];
  }

}
