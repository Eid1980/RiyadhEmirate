import { Component, OnInit } from '@angular/core';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GetServiceListDto } from '@shared/proxy/services/models';

@Component({
  selector: 'app-services-list',
  templateUrl: './services-list.component.html'
})
export class ServicesListComponent implements OnInit {
  services = [] as GetServiceListDto[];

  constructor(private serviceService: ServiceService) { }

  ngOnInit(): void {
    this.getServices();
  }

  getServices() {
    this.serviceService.getAll().subscribe((result) => {
      this.services = result.data;
    });
  }
}
