import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { RequestElectronicSummonService } from '@shared/proxy/request-electronic-summon/request-electronic-summon.service';
import { CreateRequestElectronicSummonDto, UpdateRequestElectronicSummonDto } from '@shared/proxy/request-electronic-summon/models';

@Component({
  selector: 'app-electronic-summon',
  templateUrl: './electronic-summon.component.html'
})
export class ElectronicSummonComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  electronicSummonForm: FormGroup;
  createRequestElectronicSummonDto = {} as CreateRequestElectronicSummonDto;
  serviceId: number = Service.ElectronicSummon;
  requestId: string;
  requestTypes = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestElectronicSummonService: RequestElectronicSummonService,
    private requestTypeService: RequestTypeService, private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة الاستدعاء الالكتروني");
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
    if (this.electronicSummonForm.valid) {
      if (this.requestId) {
        const updateRequestElectronicSummonDto = { ...this.electronicSummonForm.value } as UpdateRequestElectronicSummonDto;
        updateRequestElectronicSummonDto.id = this.requestId;
        this.requestElectronicSummonService.update(updateRequestElectronicSummonDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/electronic-summon-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestElectronicSummonDto = { ...this.electronicSummonForm.value } as CreateRequestElectronicSummonDto;
        this.requestElectronicSummonService.create(this.createRequestElectronicSummonDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/electronic-summon-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.electronicSummonForm = this.formBuilder.group({
      requestTypeId: [this.createRequestElectronicSummonDto.requestTypeId || null, Validators.required],
      requestTitle: [this.createRequestElectronicSummonDto.requestTitle || '', Validators.required],
      requestContent: [this.createRequestElectronicSummonDto.requestContent || null, Validators.required]
    });
  }
  fillRequestType() {
    this.requestTypeService.getLookupListByServiceId(this.serviceId).subscribe((response) => {
      this.requestTypes = response.data;
    });
  }
  getDetails() {
    this.requestElectronicSummonService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestElectronicSummonDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/electronic-summon/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/electronic-summon-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/electronic-summon-preview-step/${this.requestId}` }
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
