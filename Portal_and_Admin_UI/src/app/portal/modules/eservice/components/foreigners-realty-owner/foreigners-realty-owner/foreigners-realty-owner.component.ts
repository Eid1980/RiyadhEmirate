import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Service } from '@shared/enums/service.enum';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { MenuItem } from 'primeng/api';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { CreateRequestForeignersRealtyOwnerDto, UpdateRequestForeignersRealtyOwnerDto } from '@shared/proxy/request-foreigners-realty-owner/models';
import { RequestForeignersRealtyOwnerService } from '@shared/proxy/request-foreigners-realty-owner/request-foreigners-realty-owner.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-foreigners-realty-owner',
  templateUrl: './foreigners-realty-owner.component.html'
})
export class ForeignersRealtyOwnerComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  foreignersRealtyOwnerForm: FormGroup;
  createRequestForeignersRealtyOwnerDto = {} as CreateRequestForeignersRealtyOwnerDto;
  serviceId: number = Service.ForeignersRealtyOwner;
  requestId: string;
  buildingTypes = [] as LookupDto<number>[];
  governorates = [] as LookupDto<number>[];
  religions = [] as LookupDto<number>[];
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private requestForeignersRealtyOwnerService: RequestForeignersRealtyOwnerService,
    private lookupService: LookupService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة تملك العقار للأجانب");
    this.buildForm();
    this.fillBuildingType();
    this.fillGovernorate();
    this.fillReligion();
    this.requestId = this.activatedRoute.snapshot.params['id'];
    if (this.requestId) {
      this.getDetails();
    }
    this.getWizardItems();
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.foreignersRealtyOwnerForm.valid) {
      if (this.requestId) {
        const updateRequestForeignersRealtyOwnerDto = { ...this.foreignersRealtyOwnerForm.value } as UpdateRequestForeignersRealtyOwnerDto;
        updateRequestForeignersRealtyOwnerDto.id = this.requestId;
        this.requestForeignersRealtyOwnerService.update(updateRequestForeignersRealtyOwnerDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/foreigners-realty-owner-attachments/${this.requestId}`);
        });
      }
      else {
        this.createRequestForeignersRealtyOwnerDto = { ...this.foreignersRealtyOwnerForm.value } as CreateRequestForeignersRealtyOwnerDto;
        this.requestForeignersRealtyOwnerService.create(this.createRequestForeignersRealtyOwnerDto).subscribe((response) => {
          this.globalService.navigate(`/eservice/foreigners-realty-owner-attachments/${response.data}`);
        });
      }
    }
  }

  buildForm() {
    this.foreignersRealtyOwnerForm = this.formBuilder.group({
      buildingTypeId: [this.createRequestForeignersRealtyOwnerDto.buildingTypeId || null, Validators.required],
      governorateId: [this.createRequestForeignersRealtyOwnerDto.governorateId || null, Validators.required],
      district: [this.createRequestForeignersRealtyOwnerDto.district || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      notes: [this.createRequestForeignersRealtyOwnerDto.notes || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      address: [this.createRequestForeignersRealtyOwnerDto.address || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      religionId: [this.createRequestForeignersRealtyOwnerDto.religionId || null, Validators.required]
    });
  }
  fillBuildingType() {
    this.lookupService.getBuildingTypeLookupList().subscribe((response) => {
      this.buildingTypes = response.data;
    });
  }
  fillGovernorate() {
    this.lookupService.getGovernorateLookupList().subscribe((response) => {
      this.governorates = response.data;
    });
  }
  fillReligion() {
    this.lookupService.getReligionLookupList().subscribe((response) => {
      this.religions = response.data;
    });
  }
  getDetails() {
    this.requestForeignersRealtyOwnerService.getById(this.requestId).subscribe((response) => {
      if (response.data.canEdit) {
        this.createRequestForeignersRealtyOwnerDto = response.data;
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
        { label: 'بيانات الطلب', url: `/eservice/foreigners-realty-owner/${this.requestId}` },
        { label: 'المرفقات', url: `/eservice/foreigners-realty-owner-attachments/${this.requestId}` },
        { label: 'ارسال الطلب', url: `/eservice/foreigners-realty-owner-preview-step/${this.requestId}` }
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
