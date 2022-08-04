import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { ServiceStageService } from '@proxy/service-stages/service-stage.service';
import { GetServiceStageDetailsDto } from '@proxy/service-stages/models';

@Component({
  selector: 'app-service-stage-view',
  templateUrl: './service-stage-view.component.html'
})
export class ServiceStageViewComponent implements OnInit {
  id: number;
  serviceStageDetailsDto: GetServiceStageDetailsDto;

  constructor(private serviceStageService: ServiceStageService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل مرحلة الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.serviceStageService.getById(this.id).subscribe((response) => {
      this.serviceStageDetailsDto = response.data;
    });
  }
}
