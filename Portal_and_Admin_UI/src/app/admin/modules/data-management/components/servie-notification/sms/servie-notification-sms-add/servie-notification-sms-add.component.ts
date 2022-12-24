import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';
import { CreateServieNotificationDto } from '@shared/proxy/servie-notifications/models';
import { ServieNotificationService } from '@shared/proxy/servie-notifications/servie-notification.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-servie-notification-sms-add',
  templateUrl: './servie-notification-sms-add.component.html'
})
export class ServieNotificationSmsAddComponent implements OnInit {
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createServieNotificationDto = {} as CreateServieNotificationDto;
  services = [] as LookupDto<number>[];
  stages = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private servieNotificationService: ServieNotificationService,
    private serviceService: ServiceService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة رسالة نصية جديدة');
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
    this.serviceService.getStagesLookupList().subscribe((response) => {
      this.stages = response.data;
    });
  }

  buildForm() {
    this.createForm = this.formBuilder.group({
      serviceId: [this.createServieNotificationDto.serviceId || null, Validators.required],
      stageId: [this.createServieNotificationDto.stageId || null, Validators.required],
      message: [this.createServieNotificationDto.message || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createServieNotificationDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createServieNotificationDto = { ...this.createForm.value } as CreateServieNotificationDto;
      this.createServieNotificationDto.isSMS = true;
      this.createServieNotificationDto.isEmail = false;
      this.createServieNotificationDto.isDefault = false;
      this.servieNotificationService.create(this.createServieNotificationDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.globalService.navigate('/admin/data-management/servie-notification-sms-list');
        }
      });
    }
  }
}
