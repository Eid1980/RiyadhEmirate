import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { GlobalService } from '@shared/services/global.service';
import { UpdatePosterDto } from '@shared/proxy/posters/models';
import { FileManagerService } from '@shared/services/file-manager.service';
import { DomSanitizer } from '@angular/platform-browser';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-edit-poster',
  templateUrl: './edit-poster.component.html'
})
export class EditPosterComponent implements OnInit {
  updatePosterform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  oldImage: any;
  updatePosterDto = {} as UpdatePosterDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 10000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private posterService: PosterService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService,
    public sanitizer: DomSanitizer
  ) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل الاعلان');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/poster-list");
    }
  }

  buildForm() {
    this.updatePosterform = this.formBuilder.group({
      titleAr: [this.updatePosterDto.titleAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      titleEn: [this.updatePosterDto.titleEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.updatePosterDto.order || '', Validators.required],
      image: [null],
      isActive: [this.updatePosterDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.posterService.getById(this.id).subscribe((response) => {
      this.updatePosterDto = response.data as UpdatePosterDto;
      this.buildForm();
      this.oldImage = response.data.image;
    });
  }
  onUpload(event: any) {
    this.updatePosterform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updatePosterform.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updatePosterform.valid) {
      this.updatePosterDto = { ...this.updatePosterform.value } as UpdatePosterDto;
      this.updatePosterDto.id = this.id;

      this.posterService.update(this.updatePosterDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (this.updatePosterform.get('image').value) {
            this.fileManagerService.deleteByEntityName(this.id, 'Poster').subscribe(res => {
              this.fileManagerService.upload(this.id.toString(), 'Poster', '', [this.updatePosterform.get('image').value]).subscribe(res => {
                this.globalService.navigate("/admin/data-management/poster-list");
              })
            })
          }
          else {
            this.globalService.navigate("/admin/data-management/poster-list");
          }
        }
      });
    }
  }
}
