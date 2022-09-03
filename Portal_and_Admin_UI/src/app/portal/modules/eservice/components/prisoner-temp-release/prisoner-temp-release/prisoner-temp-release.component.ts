import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { CaseTypeService } from '@proxy/case-types/case-type.service';
import { CreateRequestPrisonerTempReleaseDto, UpdateRequestPrisonerTempReleaseDto } from '@proxy/request-prisoner-temp-release/models';
import { RequestPrisonerTempReleaseService } from '@proxy/request-prisoner-temp-release/request-prisoner-temp-release.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-prisoner-temp-release',
  templateUrl: './prisoner-temp-release.component.html'
})
export class PrisonerTempReleaseComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  prisonerTempReleaseForm: FormGroup;
  createRequestPrisonerTempReleaseDto = {} as CreateRequestPrisonerTempReleaseDto;
  serviceId: number = Service.PrisonerTempRelease;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  caseTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestPrisonerTempReleaseService: RequestPrisonerTempReleaseService,
    private requestTypeService: RequestTypeService, private caseTypeService: CaseTypeService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة الخروج المؤقت لسجين");
    this.buildForm();
    this.fillRequestType();
    this.fillCaseType();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.prisonerTempReleaseForm.valid) {
      if (this.requestId) {
        const updateRequestPrisonerTempReleaseDto = { ...this.prisonerTempReleaseForm.value } as UpdateRequestPrisonerTempReleaseDto;
        updateRequestPrisonerTempReleaseDto.id = this.requestId;
        this.requestPrisonerTempReleaseService.update(updateRequestPrisonerTempReleaseDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/prisoner-temp-release-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestPrisonerTempReleaseDto = { ...this.prisonerTempReleaseForm.value } as CreateRequestPrisonerTempReleaseDto;
        this.requestPrisonerTempReleaseService.create(this.createRequestPrisonerTempReleaseDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/prisoner-temp-release-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.prisonerTempReleaseForm = this.formBuilder.group({
      requestTypeId: [this.createRequestPrisonerTempReleaseDto.requestTypeId || null, Validators.required],
      notes: [this.createRequestPrisonerTempReleaseDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      presonName: [this.createRequestPrisonerTempReleaseDto.presonName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      caseTypeId: [this.createRequestPrisonerTempReleaseDto.caseTypeId || null, Validators.required]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  fillCaseType() {
    this.caseTypeService.getLookupList().subscribe((response) => {
      this.caseTypes = response.data;
    });
  }
  getDetails() {
    this.requestPrisonerTempReleaseService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestPrisonerTempReleaseDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/prisoner-temp-release/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/prisoner-temp-release-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/prisoner-temp-release-preview-step/${this.requestId}` }
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
