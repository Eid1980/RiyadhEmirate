import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DomSanitizer } from '@angular/platform-browser';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { GovernorateService } from '@shared/proxy/governorates/governorate.service';
import { UpdateGovernorateDto } from '@shared/proxy/governorates/models';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-governorate-edit',
  templateUrl: './governorate-edit.component.html'
})
export class GovernorateEditComponent implements OnInit {
  updateGovernorateform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  updateGovernorateDto = {} as UpdateGovernorateDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.governoratesfileSize ? environment.governoratesfileSize : environment.fileSize;
  acceptType: string = environment.governoratesallowedExtensions ? environment.governoratesallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private governorateService: GovernorateService,
    private fileManagerService: FileManagerService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute, public sanitizer: DomSanitizer) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل المحافظة');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/governorate-list');
    }
  }

  buildForm() {
    this.updateGovernorateform = this.formBuilder.group({
      nameAr: [this.updateGovernorateDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateGovernorateDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionAr: [this.updateGovernorateDto.descriptionAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionEn: [this.updateGovernorateDto.descriptionEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      phoneNumber: [this.updateGovernorateDto.phoneNumber || ''],
      locationLink: [this.updateGovernorateDto.locationLink || ''],
      portalLink: [this.updateGovernorateDto.portalLink || ''],
      image: [null],
      isActive: [this.updateGovernorateDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.governorateService.getById(this.id).subscribe((response) => {
      this.updateGovernorateDto = response.data as UpdateGovernorateDto;
      this.buildForm();
    });
  }
  onUpload(event: any) {
    this.updateGovernorateform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateGovernorateform.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateGovernorateform.valid) {
      this.updateGovernorateDto = { ...this.updateGovernorateform.value } as UpdateGovernorateDto;
      this.updateGovernorateDto.id = this.id;
      let imageContent = this.updateGovernorateform.get('image').value;
      if (imageContent) {
        this.updateGovernorateDto.imageName = imageContent.name;
      }
      this.governorateService.update(this.updateGovernorateDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Governorates, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate('/admin/data-management/governorate-list');
            });
          }
          else {
            this.globalService.navigate('/admin/data-management/governorate-list');
          }
        }
      });
    }
  }
}
