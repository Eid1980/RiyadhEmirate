import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MenuItem } from 'primeng/api';
import { Service } from '@shared/enums/service.enum';
import { ActivatedRoute } from '@angular/router';
import { CreateRequestLandsInfringementDto, UpdateRequestLandsInfringementDto } from '@shared/proxy/request-lands-infringement/models';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { RequestTypeService } from '@shared/proxy/request-types/request-type.service';
import { GlobalService } from '@shared/services/global.service';
import { RequestLandsInfringementService } from '@shared/proxy/request-lands-infringement/request-lands-infringement.service';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-lands-infringement',
  templateUrl: './lands-infringement.component.html'
})
export class LandsInfringementComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  landsInfringementForm: FormGroup;
  createRequestLandsInfringementDto = {} as CreateRequestLandsInfringementDto;
  serviceId: number = Service.LandsInfringement;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  governorates = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestLandsInfringementService: RequestLandsInfringementService,
    private requestTypeService: RequestTypeService, private lookupService: LookupService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة التعدي على الاراضي الحكومية");
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
    if (this.landsInfringementForm.valid) {
      if (this.requestId) {
        const updateRequestPrisonerTempReleaseDto = { ...this.landsInfringementForm.value } as UpdateRequestLandsInfringementDto;
        updateRequestPrisonerTempReleaseDto.id = this.requestId;
        this.requestLandsInfringementService.update(updateRequestPrisonerTempReleaseDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/lands-infringement-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestLandsInfringementDto = { ...this.landsInfringementForm.value } as CreateRequestLandsInfringementDto;
        this.requestLandsInfringementService.create(this.createRequestLandsInfringementDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/lands-infringement-attachments/${response.data}`);
        });
      }
    }
  }
  buildForm() {
    this.landsInfringementForm = this.formBuilder.group({
      requestTypeId: [this.createRequestLandsInfringementDto.requestTypeId || null, Validators.required],
      governorateId: [this.createRequestLandsInfringementDto.governorateId || null, Validators.required],
      estimatedSpace: [this.createRequestLandsInfringementDto.estimatedSpace || ''],
      infringerDescription: [this.createRequestLandsInfringementDto.infringerDescription || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      address: [this.createRequestLandsInfringementDto.address || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      longitude: [this.createRequestLandsInfringementDto.longitude || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      latitude: [this.createRequestLandsInfringementDto.latitude || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      infringerName: [this.createRequestLandsInfringementDto.infringerName || ''],
      notes: [this.createRequestLandsInfringementDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  fillCaseType() {
    this.lookupService.getGovernorateLookupList().subscribe((response) => {
      this.governorates = response.data;
    });
  }
  getDetails() {
    this.requestLandsInfringementService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestLandsInfringementDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/lands-infringement/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/lands-infringement-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/lands-infringement-preview-step/${this.requestId}` }
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
