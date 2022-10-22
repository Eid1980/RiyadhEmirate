import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateRequestElectronicCouncilDto, UpdateRequestElectronicCouncilDto } from '@shared/proxy/request-electronic-council/models';
import { RequestElectronicCouncilService } from '@shared/proxy/request-electronic-council/request-electronic-coucil.service';

@Component({
  selector: 'app-electronic-council',
  templateUrl: './electronic-council.component.html'
})
export class ElectronicCouncilComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  electronicCouncilForm: FormGroup;
  createRequestElectronicCouncilDto = {} as CreateRequestElectronicCouncilDto;
  serviceId: number = Service.ElectronicBoard;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestElectronicCouncilService: RequestElectronicCouncilService,
    private requestTypeService: RequestTypeService, private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("المجلس الالكتروني");
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
    if (this.electronicCouncilForm.valid) {
      if (this.requestId) {
        const updateRequestElectronicCouncilDto = { ...this.electronicCouncilForm.value } as UpdateRequestElectronicCouncilDto;
        updateRequestElectronicCouncilDto.id = this.requestId;
        this.requestElectronicCouncilService.update(updateRequestElectronicCouncilDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/electronic-council-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestElectronicCouncilDto = { ...this.electronicCouncilForm.value } as CreateRequestElectronicCouncilDto;
        this.requestElectronicCouncilService.create(this.createRequestElectronicCouncilDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/electronic-council-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.electronicCouncilForm = this.formBuilder.group({
      requestTypeId: [this.createRequestElectronicCouncilDto.requestTypeId || null, Validators.required],
      requestTitle: [this.createRequestElectronicCouncilDto.requestTitle || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      requestContent: [this.createRequestElectronicCouncilDto.requestContent || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  getDetails() {
    this.requestElectronicCouncilService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestElectronicCouncilDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/electronic-council/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/electronic-council-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/electronic-council-preview-step/${this.requestId}` }
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
