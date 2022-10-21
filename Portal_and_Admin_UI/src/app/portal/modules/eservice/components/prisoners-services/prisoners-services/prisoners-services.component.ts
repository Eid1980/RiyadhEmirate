import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { CaseTypeService } from '@proxy/case-types/case-type.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { RequestPrisonersServicesService } from '@proxy/request-prisoners-services/request-prisoners-services.service';
import { CreateRequestPrisonersServiceDto, UpdateRequestPrisonersServiceDto } from '@proxy/request-prisoners-services/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { PrisonService } from '@shared/proxy/prisons/prison.service';

@Component({
  selector: 'app-prisoners-services',
  templateUrl: './prisoners-services.component.html'
})
export class PrisonersServicesComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  prisonersServicesForm: FormGroup;
  createRequestPrisonersServiceDto = {} as CreateRequestPrisonersServiceDto;
  serviceId: number = Service.PrisonersServices;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  prisons = [] as LookupDto<number>[];
  caseTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestPrisonersServicesService: RequestPrisonersServicesService,
    private requestTypeService: RequestTypeService, private caseTypeService: CaseTypeService, private prisonService: PrisonService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمات السجناء");
    this.buildForm();
    this.fillRequestType();
    this.fillPresons();
    this.fillCaseType();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.prisonersServicesForm.valid) {
      if (this.requestId) {
        const updateRequestPrisonersServiceDto = { ...this.prisonersServicesForm.value } as UpdateRequestPrisonersServiceDto;
        updateRequestPrisonersServiceDto.id = this.requestId;
        this.requestPrisonersServicesService.update(updateRequestPrisonersServiceDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/prisoners-services-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestPrisonersServiceDto = { ...this.prisonersServicesForm.value } as CreateRequestPrisonersServiceDto;
        this.requestPrisonersServicesService.create(this.createRequestPrisonersServiceDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/prisoners-services-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.prisonersServicesForm = this.formBuilder.group({
      requestTypeId: [this.createRequestPrisonersServiceDto.requestTypeId || null, Validators.required],
      notes: [this.createRequestPrisonersServiceDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      prisonId: [this.createRequestPrisonersServiceDto.prisonId || null, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      caseTypeId: [this.createRequestPrisonersServiceDto.caseTypeId || null, Validators.required]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  fillPresons() {
    this.prisonService.getLookupList().subscribe((response) => {
      this.prisons = response.data;
    });
  }
  fillCaseType() {
    this.caseTypeService.getLookupList().subscribe((response) => {
      this.caseTypes = response.data;
    });
  }
  getDetails() {
    this.requestPrisonersServicesService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestPrisonersServiceDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/prisoners-services/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/prisoners-services-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/prisoners-services-preview-step/${this.requestId}` }
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
