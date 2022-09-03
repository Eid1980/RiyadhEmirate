import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { CreateRequestMarriageCertificateDto, UpdateRequestMarriageCertificateDto } from '@shared/proxy/request-marriage-certificate/models';
import { RequestMarriageCertificateService } from '@shared/proxy/request-marriage-certificate/request-marriage-certificate.service';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-marriage-certificate',
  templateUrl: './marriage-certificate.component.html'
})
export class MarriageCertificateComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  marriageCertificateForm: FormGroup;
  createRequestMarriageCertificateDto = {} as CreateRequestMarriageCertificateDto;
  serviceId: number = Service.PrisonersServices;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  maritalStatus = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestMarriageCertificateService: RequestMarriageCertificateService,
    private requestTypeService: RequestTypeService, private lookupService: LookupService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة توثيق الزواج");
    this.buildForm();
    this.fillRequestType();
    this.fillMaritalStatus();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.marriageCertificateForm.valid) {
      if (this.requestId) {
        const updateRequestMarriageCertificateDto = { ...this.marriageCertificateForm.value } as UpdateRequestMarriageCertificateDto;
        updateRequestMarriageCertificateDto.id = this.requestId;
        this.requestMarriageCertificateService.update(updateRequestMarriageCertificateDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/marriage-certificate-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestMarriageCertificateDto = { ...this.marriageCertificateForm.value } as CreateRequestMarriageCertificateDto;
        this.requestMarriageCertificateService.create(this.createRequestMarriageCertificateDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/marriage-certificate-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.marriageCertificateForm = this.formBuilder.group({
      requestTypeId: [this.createRequestMarriageCertificateDto.requestTypeId || null, Validators.required],
      notes: [this.createRequestMarriageCertificateDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      employeeSide: [this.createRequestMarriageCertificateDto.employeeSide || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      jobOccupation: [this.createRequestMarriageCertificateDto.jobOccupation || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      maritalStatusId: [this.createRequestMarriageCertificateDto.maritalStatusId || null, Validators.required],
      childrenCount: [this.createRequestMarriageCertificateDto.childrenCount || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  fillMaritalStatus() {
    this.lookupService.getMaritalStatusLookupList().subscribe((response) => {
      this.maritalStatus = response.data;
    });
  }
  getDetails() {
    this.requestMarriageCertificateService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestMarriageCertificateDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/marriage-certificate/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/marriage-certificate-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/marriage-certificate-preview-step/${this.requestId}` }
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
