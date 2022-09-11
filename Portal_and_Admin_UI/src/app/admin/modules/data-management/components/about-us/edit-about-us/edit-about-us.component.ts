import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { PageContentTypeEnum } from '@shared/enums/page-content-type-enum';
import { AboutUsService } from '@shared/proxy/about-us/about-us.service';
import { GetMainPoints } from '@shared/proxy/about-us/models';

@Component({
  selector: 'app-edit-about-us',
  templateUrl: './edit-about-us.component.html',
  styleUrls: ['./edit-about-us.component.scss']
})
export class EditAboutUsComponent implements OnInit {

  aboutUsMainPoints: FormGroup;
  getMainPoints: GetMainPoints;
  getMainPointsList = [] as GetMainPoints[];


  isFormSubmitted: boolean;

  isUpdate: boolean = false;

  constructor(private _aboutUsService: AboutUsService,
    private _formBuilder: FormBuilder) { }

  ngOnInit(): void {

    this.buildForm();
  }

  buildForm() {
    this.aboutUsMainPoints = this._formBuilder.group({
      id: [this.getMainPoints.id],
      point: [this.getMainPoints.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.getMainPoints.order || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.aboutUsMainPoints.valid) {
      if (this.getMainPoints.id == 0) {
        this.getMainPoints = { ...this.aboutUsMainPoints.value } as GetMainPoints;
        this.getMainPoints.pageContentType = PageContentTypeEnum.AboutUs.toString();
        /*this._aboutUsService.create(this.createServiceConditionDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.clear();
            this.getServiceConditions();
          }
        });*/
      }
      else {
        /* this.updateServiceConditionDto = { ...this.serviceConditionForm.value } as UpdateServiceConditionDto;
         this.updateServiceConditionDto.id = this.serviceConditionId;
         this.updateServiceConditionDto.serviceId = this.id;
         this.serviceConditionService.update(this.updateServiceConditionDto).subscribe((response) => {
           this.globalService.showMessage(response.message);
           if (response.isSuccess) {
             this.clear();
             this.getServiceConditions();
           }
         });
       }*/
      }
    }
  }

  fillData(id: number) {
    /*this.serviceConditionService.getById(id).subscribe((response) => {
      this.serviceConditionForm.setValue({
        condition: `${response.data.condition}`,
        order: `${response.data.order}`
      });
      this.isUpdate = true;
      this.serviceConditionId = id;
    });*/
  }

  delete(id: number) {
    /*this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);*/
  }

  clear() {
    this.aboutUsMainPoints.reset();
    this.isFormSubmitted = false;
    this.isUpdate = false;
  }

}
