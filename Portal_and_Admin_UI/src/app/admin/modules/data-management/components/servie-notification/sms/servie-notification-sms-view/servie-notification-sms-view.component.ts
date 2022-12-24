import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GlobalService } from "@shared/services/global.service";
import { ServieNotificationService } from "@shared/proxy/servie-notifications/servie-notification.service";
import { GetServieNotificationDetailsDto } from "@shared/proxy/servie-notifications/models";

@Component({
  selector: 'app-servie-notification-sms-view',
  templateUrl: './servie-notification-sms-view.component.html'
})
export class ServieNotificationSmsViewComponent implements OnInit {
  id: number;
  servieNotificationDetailsDto = {} as GetServieNotificationDetailsDto;

  constructor(private servieNotificationService: ServieNotificationService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الرسالة النصية');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/servie-notification-sms-list");
    }
  }

  getDetails() {
    this.servieNotificationService.getById(this.id).subscribe((response) => {
      this.servieNotificationDetailsDto = response.data;
    });
  }
}
