import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { ApiResponse } from '@shared/proxy/shared/api-response.model';

@Component({
  selector: 'app-services-guide',
  templateUrl: './services-guide.component.html'
})
export class ServicesGuideComponent implements OnInit {

  services: GetServiceListDto[] = [];

  constructor(
    private _serviceService: ServiceService,
    public sanitizer: DomSanitizer
  ) { }

  ngOnInit(): void {
    this.getServices();

  }

  getServices() {
    this._serviceService
      .getAll()
      .subscribe((result: ApiResponse<GetServiceListDto[]>) => {
        this.services = result.data;
      });
  }

}
