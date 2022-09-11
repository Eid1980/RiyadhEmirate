import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { PageContentTypeEnum } from '@shared/enums/page-content-type-enum';
import { AboutUsService } from '@shared/proxy/about-us/about-us.service';
import { CreateMainPoint, GetAboutUsDto, GetMainPoints } from '@shared/proxy/about-us/models';

@Component({
  selector: 'app-edit-about-us',
  templateUrl: './edit-about-us.component.html',
  styleUrls: ['./edit-about-us.component.scss']
})
export class EditAboutUsComponent implements OnInit {

  aboutUsMainPointsForm: FormGroup;
  getMainPoints: GetMainPoints;
  getMainPointsList = [] as GetMainPoints[];
  adoutUsDetails  = {} as GetAboutUsDto;


  isFormSubmitted: boolean;

  isUpdate: boolean = false;

  constructor(private _aboutUsService: AboutUsService,
    private _formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.buildForm();

    this.getPageContent();
  }

  buildForm() {
    this.aboutUsMainPointsForm = this._formBuilder.group({
      id: [this.getMainPoints?.id],
      point: [this.getMainPoints?.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.getMainPoints?.order || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }

  getPageContent(){
    debugger
    this._aboutUsService.getAboutUs().subscribe(
      (response : any) => {
        debugger
        this.adoutUsDetails = response.data[0]
      },
      (error) => {

      }
    )

  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.aboutUsMainPointsForm.valid) {
      if (this.getMainPoints?.id == 0) {
        this.getMainPoints = { ...this.aboutUsMainPointsForm.value } as GetMainPoints;
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

        let aboutUsFormValues = this.aboutUsMainPointsForm.value
        let createMainPoint : CreateMainPoint = {nameAr : aboutUsFormValues.point, nameEn: '' , pageContentType: '' , order : aboutUsFormValues.order};

        this._aboutUsService.createMainPoint(createMainPoint).subscribe(
          (response) => {

            this.getPageContent();
          },
          (error) => {}
        );

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
    this.aboutUsMainPointsForm.reset();
    this.isFormSubmitted = false;
    this.isUpdate = false;
  }

}
