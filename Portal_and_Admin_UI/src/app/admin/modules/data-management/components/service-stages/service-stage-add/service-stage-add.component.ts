import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { CreateServiceStageDto } from '@proxy/service-stages/models';
import { ServiceService } from '@proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceStageService } from '@proxy/service-stages/service-stage.service';

@Component({
  selector: 'app-service-stage-add',
  templateUrl: './service-stage-add.component.html',
})
export class ServiceStageAddComponent implements OnInit {
  createServiceStageForm: FormGroup;
  isFormSubmitted: boolean;
  createServiceStageDto = {} as CreateServiceStageDto;
  services = [] as LookupDto<number>[];
  stages = [] as LookupDto<number>[];

  constructor(
    private formBuilder: FormBuilder,
    private serviceStageService: ServiceStageService,
    private serviceService: ServiceService,
    private globalService: GlobalService
  ) {}

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مرحلة على خدمة');
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
    this.serviceService.getStagesLookupList().subscribe((response) => {
      this.stages = response.data;
    });
  }

  buildForm() {
    this.createServiceStageForm = this.formBuilder.group({
      serviceId: [
        this.createServiceStageDto.serviceId || null,
        Validators.required
      ],
      stageId: [
        this.createServiceStageDto.stageId || null,
        Validators.required
      ],
      requesterUrl: [this.createServiceStageDto.requesterUrl],
      adminUrl: [this.createServiceStageDto.adminUrl],
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createServiceStageForm.valid) {
      this.createServiceStageDto = {
        ...this.createServiceStageForm.value,
      } as CreateServiceStageDto;
      this.serviceStageService
        .create(this.createServiceStageDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate(
              '/admin/data-management/service-stage-list'
            );
          }
        });
    }
  }
}
