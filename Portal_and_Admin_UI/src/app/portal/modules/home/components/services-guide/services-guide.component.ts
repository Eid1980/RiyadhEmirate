import { Component, OnInit } from '@angular/core';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-services-guide',
  templateUrl: './services-guide.component.html'
})
export class ServicesGuideComponent implements OnInit {
  services: GetServiceListDto[] = [];

  constructor(private serviceService: ServiceService, private globalService: GlobalService) {
  }
  ngOnInit(): void {
    this.getServices();
  }
  getServices() {
    this.globalService.setTitle('دليل اجراءات الخدمات');
    this.serviceService.getAll().subscribe((result) => {
      this.services = result.data.filter(i => i.isExternal === false);
    });
  }

}
