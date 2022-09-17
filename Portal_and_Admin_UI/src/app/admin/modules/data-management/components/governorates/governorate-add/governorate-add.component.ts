import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateGovernorateDto } from '@shared/proxy/governorates/models';
import { GovernorateService } from '@shared/proxy/governorates/governorate.service';
import { FileManagerService } from '@shared/services/file-manager.service';

@Component({
  selector: 'app-governorate-add',
  templateUrl: './governorate-add.component.html'
})
export class GovernorateAddComponent implements OnInit {
  createGovernorateForm: FormGroup;
  isFormSubmitted: boolean;
  createGovernorateDto = {} as CreateGovernorateDto;
  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 10000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private caseTypeService: GovernorateService,
    private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة محافظة جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createGovernorateForm = this.formBuilder.group({
      nameAr: [this.createGovernorateDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createGovernorateDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionAr: [this.createGovernorateDto.descriptionAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionEn: [this.createGovernorateDto.descriptionEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      phoneNumber: [this.createGovernorateDto.phoneNumber || ''],
      locationLink: [this.createGovernorateDto.locationLink || ''],
      portalLink: [this.createGovernorateDto.portalLink || ''],
      image: [null, Validators.required],
      isActive: [this.createGovernorateDto.isActive || true, Validators.required]
    });
  }

  onUpload(event: any) {
    this.createGovernorateForm.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createGovernorateForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createGovernorateForm.valid) {
      this.createGovernorateDto = { ...this.createGovernorateForm.value } as CreateGovernorateDto;
      this.caseTypeService.create(this.createGovernorateDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            let id = response.data.toString();
            this.fileManagerService.upload(id, 'Governorate', '', [this.createGovernorateForm.get('image').value]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/governorate-list");
            });
          }
        });
    }
  }
}
