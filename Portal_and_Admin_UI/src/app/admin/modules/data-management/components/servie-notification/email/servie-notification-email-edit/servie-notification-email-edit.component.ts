import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';
import { UpdateServieNotificationDto } from '@shared/proxy/servie-notifications/models';
import { ServieNotificationService } from '@shared/proxy/servie-notifications/servie-notification.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-servie-notification-email-edit',
  templateUrl: './servie-notification-email-edit.component.html'
})
export class ServieNotificationEmailEditComponent implements OnInit {
  id: number;
  updateForm: FormGroup;
  isFormSubmitted: boolean;
  updateServieNotificationDto = {} as UpdateServieNotificationDto;
  services = [] as LookupDto<number>[];
  stages = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private servieNotificationService: ServieNotificationService,
    private serviceService: ServiceService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل رسالة بريد الكتروني');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/ervie-notification-email-list");
    }
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
    this.serviceService.getStagesLookupList().subscribe((response) => {
      this.stages = response.data;
    });
  }

  buildForm() {
    this.updateForm = this.formBuilder.group({
      serviceId: [this.updateServieNotificationDto.serviceId || null, Validators.required],
      stageId: [this.updateServieNotificationDto.stageId || null, Validators.required],
      message: [this.updateServieNotificationDto.message || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateServieNotificationDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.servieNotificationService.getById(this.id).subscribe((response) => {
      this.updateServieNotificationDto = response.data as UpdateServieNotificationDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateForm.valid) {
      this.updateServieNotificationDto = { ...this.updateForm.value } as UpdateServieNotificationDto;
      this.updateServieNotificationDto.id = this.id;
      this.servieNotificationService.update(this.updateServieNotificationDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.globalService.navigate('/admin/data-management/servie-notification-email-list');
        }
      });
    }
  }

}
