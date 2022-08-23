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
  selectedDateType = DateType.Hijri;
  maxHigriDate: NgbDateStruct;
  maxGreg: NgbDateStruct;
  date: NgbDateStruct;
  //#endregion

  constructor(private formBuilder: FormBuilder, private requestJudgmentExecutionService: RequestJudgmentExecutionService,
    private requestTypeService: RequestTypeService, private lookupService: LookupService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService,
    private dateFormatterService: DateFormatterService)
  {
    let nowDate = new Date();
    let nowDateHijri = dateFormatterService.GetTodayHijri();
    this.maxHigriDate = {
      day: nowDateHijri.day,
      month: nowDateHijri.month,
      year: nowDateHijri.year,
    };
    this.maxGreg = {
      day: nowDate.getUTCDate() + 1,
      month: nowDate.getUTCMonth() + 1,
      year: nowDate.getUTCFullYear(),
    };
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

    if (!this.isSameRequester) {
      this.judgmentExecutionForm.controls["requesterName"].setValidators(Validators.required);
      this.judgmentExecutionForm.controls['requesterName'].updateValueAndValidity();
      this.judgmentExecutionForm.controls["requesterNationalId"].setValidators(Validators.required);
      this.judgmentExecutionForm.controls['requesterNationalId'].updateValueAndValidity();
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
      notes: [this.createRequestJudgmentExecutionDto.notes || '', Validators.required],
      requesterName: [this.createRequestJudgmentExecutionDto.requesterName || ''],
      requesterNationalId: [this.createRequestJudgmentExecutionDto.requesterNationalId || ''],
      defendantTypeId: [this.createRequestJudgmentExecutionDto.defendantTypeId || null, Validators.required],
      lawsuitNumber: [this.createRequestJudgmentExecutionDto.lawsuitNumber || '', Validators.required],
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
    let val = this.judgmentExecutionForm.get('requesterType').value;
    if (val == 1) {
      this.isSameRequester = true;
      this.judgmentExecutionForm.get('requesterName').setValue('');
      this.judgmentExecutionForm.get('requesterNationalId').setValue('');
    }
    else {
      this.isSameRequester = false;
    }
  }
  getDetails() {
    this.requestJudgmentExecutionService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestJudgmentExecutionDto = response.data;
        if (this.createRequestJudgmentExecutionDto.requesterType == 1) {
          this.isSameRequester = true;
        }
        else {
          this.isSameRequester = false;
        }

        let dt = new Date(this.createRequestJudgmentExecutionDto.lawsuitDate);
        let ngbDateStructGregorian = {
          day: dt.getUTCDate() + 1,
          month: dt.getUTCMonth() + 1,
          year: dt.getUTCFullYear(),
        };
        this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);

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
