import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateServiceStageDto } from '@proxy/service-stages/models';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { ServiceStageService } from '@proxy/service-stages/service-stage.service';
import { ServiceService } from '@proxy/services/service.service';

@Component({
  selector: 'app-service-stage-edit',
  templateUrl: './service-stage-edit.component.html',
})
export class ServiceStageEditComponent implements OnInit {
  id: number;
  updateServiceStageForm: FormGroup;
  isFormSubmitted: boolean;
  updateServiceStageDto = {} as UpdateServiceStageDto;
  services = [] as LookupDto<number>[];
  stages = [] as LookupDto<number>[];

  constructor(
    private formBuilder: FormBuilder,
    private serviceStageService: ServiceStageService,
    private serviceService: ServiceService,
    private activatedRoute: ActivatedRoute,
    private globalService: GlobalService
  ) {}

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل مرحلة على خدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.id) {
      this.getDetails();
      this.serviceService.getLookupList().subscribe((response) => {
        this.services = response.data;
      });
      this.serviceService.getStagesLookupList().subscribe((response) => {
        this.stages = response.data;
      });
    } else {
      this.globalService.navigate('/admin/data-management/service-stage-list');
    }
  }

  buildForm() {
    this.updateServiceStageForm = this.formBuilder.group({
      serviceId: [
        this.updateServiceStageDto.serviceId || null,
        Validators.required,
      ],
      stageId: [
        this.updateServiceStageDto.stageId || null,
        Validators.required,
      ],
      requesterUrl: [this.updateServiceStageDto.requesterUrl],
      adminUrl: [this.updateServiceStageDto.adminUrl],
    });
  }

  getDetails() {
    this.serviceStageService.getById(this.id).subscribe((response) => {
      this.updateServiceStageDto = response.data as UpdateServiceStageDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateServiceStageForm.valid) {
      this.updateServiceStageDto = {
        ...this.updateServiceStageForm.value,
      } as UpdateServiceStageDto;
      this.updateServiceStageDto.id = this.id;
      this.serviceStageService
        .update(this.updateServiceStageDto)
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
