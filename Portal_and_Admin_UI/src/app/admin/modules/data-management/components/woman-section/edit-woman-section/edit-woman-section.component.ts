import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateMainPoint, EditPageMainPoint, GetMainPoints } from '@shared/proxy/about-us/models';
import { EditWomanSectionDto, GetWomanSectionDto } from '@shared/proxy/woman-section/models';
import { WomanSectionService } from '@shared/proxy/woman-section/woman-section.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-edit-woman-section',
  templateUrl: './edit-woman-section.component.html',
  styleUrls: ['./edit-woman-section.component.scss']
})
export class EditWomanSectionComponent implements OnInit {

  aboutUsDetaislForm: FormGroup;
  aboutUsMainPointsForm: FormGroup;
  getMainPoints: GetMainPoints;
  aboutUsDetails = {} as GetWomanSectionDto;

  isFormSubmitted: boolean;
  isAboutUsFormSubmitted: boolean;

  isUpdate: boolean = false;

  constructor(private _womanSectionService: WomanSectionService,
    private _formBuilder: FormBuilder,
    private _globalService: GlobalService) {

    this.isFormSubmitted = false;
    this.isAboutUsFormSubmitted = false;
  }

  ngOnInit(): void {
    this.buildForm();
    this.getPageContent();
  }

  buildForm() {
    this.aboutUsMainPointsForm = this._formBuilder.group({
      id: [this.getMainPoints?.id],
      nameAr: [this.getMainPoints?.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.getMainPoints?.order || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });

    this.aboutUsDetaislForm = this._formBuilder.group({
      id: [this.aboutUsDetails.id],
      descriptionAr: [this.aboutUsDetails.descriptionAr, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      descriptionEn: [this.aboutUsDetails.descriptionEn, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      mainPoints: this.aboutUsMainPointsForm
    })
  }

  getPageContent() {
    this._womanSectionService.getAboutUs().subscribe(
      (response: any) => {
        this.aboutUsDetails = response.data[0]
        this.buildForm();
      },
      (error) => {
      }
    )
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.aboutUsMainPointsForm.valid) {
      if (this.aboutUsMainPointsForm.value?.id == 0 || this.aboutUsMainPointsForm.value?.id == null) {

        let aboutUsFormValues = this.aboutUsMainPointsForm.value
        let createMainPoint: CreateMainPoint = { nameAr: aboutUsFormValues.nameAr, nameEn: '', pageContentType: '', order: aboutUsFormValues.order };

        this._womanSectionService.createMainPoint(createMainPoint).subscribe(
          (response) => {
            this._globalService.showMessage(response.message);
            if (response.isSuccess) {
              let mainPoint : GetMainPoints = {id : response.data, nameAr: createMainPoint.nameAr, nameEn: createMainPoint.nameEn ,order: createMainPoint.order, pageContentType: '' }

              this.isFormSubmitted = false;
              this.aboutUsMainPointsForm.reset();

              this.aboutUsDetails.mainPoints.push(mainPoint)

            }
          },
          (error) => { }
        );
      }
      else {

        let updateMainPoint = { ...this.aboutUsMainPointsForm.value } as EditPageMainPoint;
        updateMainPoint.nameEn = updateMainPoint.nameAr

        this._womanSectionService.updateMainPoint(updateMainPoint).subscribe((response) => {
          this._globalService.showMessage(response.message);
           if (response.isSuccess) {
             this.clear();
             this.getPageContent();
           }
        });
      }
    }
  }

  editAboutUsDescription() {
    this.isAboutUsFormSubmitted = true;
    if (this.aboutUsDetaislForm.value.descriptionAr.toString().trim() == '') {
      return
    }
    else {

      let editAboutUs: EditWomanSectionDto = {
        id: this.aboutUsDetaislForm.value.id,
        descriptionAr: this.aboutUsDetaislForm.value.descriptionAr,
        descriptionEn: this.aboutUsDetaislForm.value.descriptionEn,
      }

      this._womanSectionService.update(editAboutUs).subscribe(
        (response) => {
          this._globalService.showMessage(response.message);
          this.getPageContent();
        },
        (error) => { }
      );
    }
  }

  fillData(id: number) {
    let currentPoint = this.aboutUsDetails.mainPoints.filter(p => p.id == id)[0];

    this.aboutUsMainPointsForm.setValue({
      id: `${currentPoint.id}`,
      nameAr: `${currentPoint.nameAr}`,
      order: `${currentPoint.order}`
    });

    this.isUpdate = true;
  };


  delete(id: number) {
    this._globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this._globalService.confirmSubmit = () => this.isconfirm(id);
  }

  isconfirm(id: number) {
    this._womanSectionService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this._globalService.clearMessages();
        this.getPageContent();
      }
      this._globalService.showMessage(result.message);
    });
  }

  clear() {
    this.aboutUsMainPointsForm.reset();
    this.isFormSubmitted = false;
    this.isUpdate = false;
  }
}
