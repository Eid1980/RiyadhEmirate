import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { GetServiceConditionListDto } from '@shared/proxy/service-condition/models';
import { ServiceConditionService } from '@shared/proxy/service-condition/service-condition.service';
import { GetServiceDetailsDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';

@Component({
  selector: 'app-services-guide-inner',
  templateUrl: './services-guide-inner.component.html'
})
export class ServicesGuideInnerComponent implements OnInit {
  serviceId : number
  service = {} as GetServiceDetailsDto
  getServiceConditionListDto = [] as GetServiceConditionListDto[];

  constructor(private _serviceService : ServiceService, private _serviceConditionService: ServiceConditionService,
    private _activatedRoute: ActivatedRoute, public sanitizer: DomSanitizer)
  {
  }

  ngOnInit(): void {
    this.serviceId = this._activatedRoute.snapshot.params['id'];
    this.getServiceById();
    this.getServiceConditions();

  }

  getServiceById(){
    this._serviceService.getById(this.serviceId).subscribe((response) => {
      this.service = response.data
    });
  }

  getServiceConditions() {
    this._serviceConditionService.getByServiceId(this.serviceId).subscribe((response) => {
      this.getServiceConditionListDto = response.data;
    });
  }

}
