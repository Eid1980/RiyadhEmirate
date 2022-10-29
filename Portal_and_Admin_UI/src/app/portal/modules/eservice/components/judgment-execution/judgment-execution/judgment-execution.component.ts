import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { CreateRequestJudgmentExecutionDto, UpdateRequestJudgmentExecutionDto } from '@shared/proxy/request-judgment-execution/models';
import { RequestJudgmentExecutionService } from '@shared/proxy/request-judgment-execution/request-judgment-execution.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { NationalityIDValidator } from '@shared/custom-validators/nationalityId.validator';


@Component({
  selector: 'app-judgment-execution',
  templateUrl: './judgment-execution.component.html'
})
export class JudgmentExecutionComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  judgmentExecutionForm: FormGroup;
  createRequestJudgmentExecutionDto = {} as CreateRequestJudgmentExecutionDto;
  serviceId: number = Service.JudgmentExecution;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  defendantTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;
  isSameRequester: boolean = true;
  //#region for datePicker
  @ViewChild('lawsuitDate') lawsuitDate: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;
  //#endregion

  constructor(private formBuilder: FormBuilder, private requestJudgmentExecutionService: RequestJudgmentExecutionService,
    private requestTypeService: RequestTypeService, private lookupService: LookupService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService,
    private dateFormatterService: DateFormatterService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة انفاذ حكم شرعي");
    this.createRequestJudgmentExecutionDto.requesterType = 1;
    this.buildForm();
    this.fillRequestType();
    this.fillDefendantType();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    this.isValidDate = false;
    if (this.lawsuitDate.getSelectedDate() == 'Invalid date') {
      this.isValidDate = true;
      return;
    }
    if (this.judgmentExecutionForm.valid) {
      if (this.requestId) {
        const updateRequestJudgmentExecutionDto = { ...this.judgmentExecutionForm.value } as UpdateRequestJudgmentExecutionDto;
        updateRequestJudgmentExecutionDto.id = this.requestId;
        updateRequestJudgmentExecutionDto.lawsuitDate = this.lawsuitDate.getSelectedDate();
        this.requestJudgmentExecutionService.update(updateRequestJudgmentExecutionDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/judgment-execution-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestJudgmentExecutionDto = { ...this.judgmentExecutionForm.value } as CreateRequestJudgmentExecutionDto;
        this.createRequestJudgmentExecutionDto.lawsuitDate = this.lawsuitDate.getSelectedDate();
        this.requestJudgmentExecutionService.create(this.createRequestJudgmentExecutionDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/judgment-execution-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.judgmentExecutionForm = this.formBuilder.group({
      requestTypeId: [this.createRequestJudgmentExecutionDto.requestTypeId || null],
      requesterType: [this.createRequestJudgmentExecutionDto.requesterType, Validators.required],
      notes: [this.createRequestJudgmentExecutionDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      requesterName: [this.createRequestJudgmentExecutionDto.requesterName || ''],
      requesterNationalId: [this.createRequestJudgmentExecutionDto.requesterNationalId || ''],
      defendantTypeId: [this.createRequestJudgmentExecutionDto.defendantTypeId || null, Validators.required],
      lawsuitNumber: [this.createRequestJudgmentExecutionDto.lawsuitNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      lawsuitDate: [this.createRequestJudgmentExecutionDto.lawsuitDate || '']
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  fillDefendantType() {
    this.lookupService.getDefendantTypeLookupList().subscribe((response) => {
      this.defendantTypes = response.data;
    });
  }
  onRequesterTypeChange() {
    this.updateValidations(this.judgmentExecutionForm.get('requesterType').value);
  }
  updateValidations(requesterType: number) {
    if (requesterType == 1) {
      this.isSameRequester = true;
      this.judgmentExecutionForm.get('requesterName').setValue('');
      this.judgmentExecutionForm.get('requesterNationalId').setValue('');
      this.judgmentExecutionForm.controls["requesterName"].removeValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace]);
      this.judgmentExecutionForm.controls['requesterName'].updateValueAndValidity();
      this.judgmentExecutionForm.controls["requesterNationalId"].removeValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace, NationalityIDValidator.validateNationalityID]);
      this.judgmentExecutionForm.controls['requesterNationalId'].updateValueAndValidity();
    }
    else {
      this.isSameRequester = false;
      this.judgmentExecutionForm.controls["requesterName"].setValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace]);
      this.judgmentExecutionForm.controls['requesterName'].updateValueAndValidity();
      this.judgmentExecutionForm.controls["requesterNationalId"].setValidators([Validators.required, WhiteSpaceValidator.noWhiteSpace, NationalityIDValidator.validateNationalityID]);
      this.judgmentExecutionForm.controls['requesterNationalId'].updateValueAndValidity();
    }
  }
  getDetails() {
    this.requestJudgmentExecutionService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestJudgmentExecutionDto = response.data;
        //#region Set Date
        let date = new Date(this.createRequestJudgmentExecutionDto.lawsuitDate);
        let ngbDateStructGregorian = {
          day: date.getUTCDate(),
          month: date.getUTCMonth() + 1,
          year: date.getUTCFullYear(),
        };
        this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      //#endregion
        this.buildForm();
        this.updateValidations(this.createRequestJudgmentExecutionDto.requesterType);
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
        { label: 'بيانات الطلب', url: `/eservice/judgment-execution/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/judgment-execution-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/judgment-execution-preview-step/${this.requestId}` }
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
