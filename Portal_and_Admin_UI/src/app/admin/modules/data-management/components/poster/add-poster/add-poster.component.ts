import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { CreatePosterDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';

@Component({
  selector: 'app-add-poster',
  templateUrl: './add-poster.component.html'
})
export class AddPosterComponent implements OnInit {
  createPosterform: FormGroup;
  isFormSubmitted: boolean;
  createPosterDto = {} as CreatePosterDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 1000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private posterService: PosterService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة اعلان جديد');
    this.buildForm();
  }

  buildForm() {
    this.createPosterform = this.formBuilder.group({
      titleAr: [this.createPosterDto.titleAr || '', Validators.required],
      titleEn: [this.createPosterDto.titleEn || '', Validators.required],
      order: [this.createPosterDto.order || '', Validators.required],
      image: [this.createPosterDto.image || null, Validators.required],
      isActive: [this.createPosterDto.isActive || true, Validators.required]
    });
  }

  onUpload(event: any) {
    this.createPosterform.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createPosterform.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createPosterform.valid) {
      this.createPosterDto = { ...this.createPosterform.value } as CreatePosterDto;
      this.posterService.create(this.createPosterDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService.upload(id, 'Poster', '', [this.createPosterform.get('image').value]).subscribe(res => {
            this.globalService.navigate('/admin/data-management/poster-list');
          })
        }
      });
    }
  }
}
