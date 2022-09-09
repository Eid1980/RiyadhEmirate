import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { GlobalService } from '@shared/services/global.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateServiceConditionDto, GetServiceConditionListDto, UpdateServiceConditionDto } from '@shared/proxy/service-condition/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { ServiceConditionService } from '@shared/proxy/service-condition/service-condition.service';

@Component({
  selector: 'app-service-condition',
  templateUrl: './service-condition.component.html'
})
export class ServiceConditionComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 2;
  id: number;
  serviceConditionId: number = 0;
  serviceConditionForm: FormGroup;
  isFormSubmitted: boolean;
  getServiceConditionListDto = [] as GetServiceConditionListDto[];
  createServiceConditionDto = {} as CreateServiceConditionDto;
  updateServiceConditionDto = {} as UpdateServiceConditionDto;
  isUpdate: boolean = false;

  constructor(private formBuilder: FormBuilder, private serviceConditionService: ServiceConditionService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('استكمال بيانات الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    this.getServiceConditions();
    this.getWizardItems();
  }

  buildForm() {
    this.serviceConditionForm = this.formBuilder.group({
      condition: [this.createServiceConditionDto.condition || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.createServiceConditionDto.order || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  onSubmit() {
    this.isFormSubmitted = true;
    if (this.serviceConditionForm.valid) {
      if (this.serviceConditionId == 0) {
        this.createServiceConditionDto = { ...this.serviceConditionForm.value } as CreateServiceConditionDto;
        this.createServiceConditionDto.serviceId = this.id;
        this.serviceConditionService.create(this.createServiceConditionDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.clear();
            this.getServiceConditions();
          }
        });
      }
      else {
        this.updateServiceConditionDto = { ...this.serviceConditionForm.value } as UpdateServiceConditionDto;
        this.updateServiceConditionDto.id = this.serviceConditionId;
        this.updateServiceConditionDto.serviceId = this.id;
        this.serviceConditionService.update(this.updateServiceConditionDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.clear();
            this.getServiceConditions();
          }
        });
      }
    }
  }

  getServiceConditions() {
    this.serviceConditionService.getByServiceId(this.id).subscribe((response) => {
      this.getServiceConditionListDto = response.data;
    });
  }

  fillData(id: number) {
    this.serviceConditionService.getById(id).subscribe((response) => {
      this.serviceConditionForm.setValue({
        condition: `${response.data.condition}`,
        order: `${response.data.order}`
      });
      this.isUpdate = true;
      this.serviceConditionId = id;
    });
  }

  delete(id: number) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.serviceConditionService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.getServiceConditions();
      }
      this.globalService.showMessage(result.message);
    });
  }

  clear() {
    this.serviceConditionForm.reset();
    this.isFormSubmitted = false;
    this.isUpdate = false;
    this.serviceConditionId = 0;
  }
  getWizardItems() {
    this.wizardItems = [
      { label: 'البيانات الأساسية', url: `/data-management/service-edit/${this.id}` },
      { label: 'الجمهور المستهدف', url: `/data-management/service-audience/${this.id}` },
      { label: 'شروط ووثائق الخدمة', url: `/data-management/service-condition/${this.id}` }
    ];
  }

}
