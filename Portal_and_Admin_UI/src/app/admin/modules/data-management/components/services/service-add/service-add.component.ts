import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceService } from '@proxy/services/service.service';
import { CreateServiceDto } from '@proxy/services/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MenuItem } from 'primeng/api';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-service-add',
  templateUrl: './service-add.component.html'
})
export class ServiceAddComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  createServiceForm: FormGroup;
  isFormSubmitted: boolean;
  createServiceDto = {} as CreateServiceDto;

  //#region for uploader
  @ViewChild('uploader',{static:true}) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.servicesfileSize ? environment.servicesfileSize : environment.fileSize;
  acceptType: string = environment.servicesallowedExtensions ? environment.servicesallowedExtensions : environment.allowedExtensions;
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
    this.getWizardItems();
  }

  buildForm() {
    this.createServiceForm = this.formBuilder.group({
      nameAr: [this.createServiceDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createServiceDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      sectorAr: [this.createServiceDto.sectorAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      sectorEn: [this.createServiceDto.sectorEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionAr: [this.createServiceDto.descriptionAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionEn: [this.createServiceDto.descriptionEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      requestLink: [this.createServiceDto.requestLink || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      workDays: [this.createServiceDto.workDays || null],
      cost: [this.createServiceDto.cost || null],
      image: [ null, Validators.required],
      isActive: [this.createServiceDto.isActive || true, Validators.required],
      isExternal: [this.createServiceDto.isExternal || false, Validators.required]
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
      let imageContent = this.createServiceForm.get('image').value;
      if (imageContent) {
        this.createServiceDto.imageName = imageContent.name;
      }
      this.serviceService.create(this.createServiceDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Services, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate(`/admin/data-management/service-audience/${response.data.id.toString()}`);
            });
          }
          else {
            this.globalService.navigate(`/admin/data-management/service-audience/${response.data.id.toString() }`);
          }
        }
      });
    }
  }

  getWizardItems() {
    this.wizardItems = [
      { label: 'البيانات الأساسية' },
      { label: 'الجمهور المستهدف' },
      { label: 'شروط ووثائق الخدمة' }
    ];
  }

}
