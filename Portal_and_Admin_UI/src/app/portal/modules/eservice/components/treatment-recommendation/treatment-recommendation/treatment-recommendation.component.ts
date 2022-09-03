import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { CreateRequestTreatmentRecommendationDto, UpdateRequestTreatmentRecommendationDto } from '@shared/proxy/request-treatment-recommendation/models';
import { RequestTreatmentRecommendationService } from '@shared/proxy/request-treatment-recommendation/request-treatment-recommendation.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-treatment-recommendation',
  templateUrl: './treatment-recommendation.component.html'
})
export class TreatmentRecommendationComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  treatmentRecommendationForm: FormGroup;
  createRequestTreatmentRecommendationDto = {} as CreateRequestTreatmentRecommendationDto;
  serviceId: number = Service.TreatmentRecommendation;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;
  isSameRequester: boolean = true;

  constructor(private formBuilder: FormBuilder, private requestTreatmentRecommendationService: RequestTreatmentRecommendationService,
    private requestTypeService: RequestTypeService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة طلب علاج");
    this.createRequestTreatmentRecommendationDto.patientType = 1;
    this.buildForm();
    this.fillRequestType();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (!this.isSameRequester) {
      this.treatmentRecommendationForm.controls["patientName"].setValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace]);
      this.treatmentRecommendationForm.controls['patientName'].updateValueAndValidity();
      this.treatmentRecommendationForm.controls["patientNationalId"].setValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace]);
      this.treatmentRecommendationForm.controls['patientNationalId'].updateValueAndValidity();
    }
    if (this.treatmentRecommendationForm.valid) {
      if (this.requestId) {
        const updateRequestTreatmentRecommendationDto = { ...this.treatmentRecommendationForm.value } as UpdateRequestTreatmentRecommendationDto;
        updateRequestTreatmentRecommendationDto.id = this.requestId;
        this.requestTreatmentRecommendationService.update(updateRequestTreatmentRecommendationDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/treatment-recommendation-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestTreatmentRecommendationDto = { ...this.treatmentRecommendationForm.value } as CreateRequestTreatmentRecommendationDto;
        this.requestTreatmentRecommendationService.create(this.createRequestTreatmentRecommendationDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/treatment-recommendation-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.treatmentRecommendationForm = this.formBuilder.group({
      requestTypeId: [this.createRequestTreatmentRecommendationDto.requestTypeId || null, Validators.required],
      patientType: [this.createRequestTreatmentRecommendationDto.patientType, Validators.required],
      notes: [this.createRequestTreatmentRecommendationDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      patientName: [this.createRequestTreatmentRecommendationDto.patientName || ''],
      patientNationalId: [this.createRequestTreatmentRecommendationDto.patientNationalId || '']
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  onRequesterTypeChange() {
    let val = this.treatmentRecommendationForm.get('patientType').value;
    if (val == 1) {
      this.isSameRequester = true;
      this.treatmentRecommendationForm.get('patientName').setValue('');
      this.treatmentRecommendationForm.get('patientNationalId').setValue('');
    }
    else {
      this.isSameRequester = false;
    }
  }
  getDetails() {
    this.requestTreatmentRecommendationService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestTreatmentRecommendationDto = response.data;
        if (this.createRequestTreatmentRecommendationDto.patientType == 1) {
          this.isSameRequester = true;
        }
        else {
          this.isSameRequester = false;
        }
        this.buildForm();
      }
      else {
        this.globalService.messageAlert(MessageType.Warning, "لا يمكن التعديل على الطلب في الوقت الحالي")
        this.globalService.navigateToRequesterDashboard();
      }
    });
  }
  getWizardItems() {
    if (this.requestId) {
      this.wizardItems = [
        { label: 'بيانات الطلب', url: `/eservice/treatment-recommendation/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/treatment-recommendation-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/treatment-recommendation-preview-step/${this.requestId}` }
      ];
    }
    else {
      this.wizardItems = [
        { label: 'بيانات الطلب' },
        { label: 'المرفقات' },
        { label: 'ارسال الطلب' }
      ];
    }
  }
}
