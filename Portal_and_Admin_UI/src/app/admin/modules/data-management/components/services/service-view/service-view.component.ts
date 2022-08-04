import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ServiceService } from '@proxy/services/service.service';
import { GetServiceDetailsDto } from '@proxy/services/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-service-view',
  templateUrl: './service-view.component.html'
})
export class ServiceViewComponent implements OnInit {
  id: number;
  serviceDetailsDto: GetServiceDetailsDto;

  constructor(private serviceService: ServiceService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/service-list");
    }
  }

  getDetails() {
    this.serviceService.getById(this.id).subscribe((response) => {
      this.serviceDetailsDto = response.data;
    });
  }

  goToLink() {
    window.open(this.serviceDetailsDto.requestLink, '_blank');
  }
}
