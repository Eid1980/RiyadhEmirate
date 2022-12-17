import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetServiceConditionListDto } from '@shared/proxy/service-condition/models';
import { ServiceConditionService } from '@shared/proxy/service-condition/service-condition.service';
import { GetServiceDetailsDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-services-guide-inner',
  templateUrl: './services-guide-inner.component.html'
})
export class ServicesGuideInnerComponent implements OnInit {
  serviceId : number
  service = {} as GetServiceDetailsDto
  getServiceConditionListDto = [] as GetServiceConditionListDto[];

  constructor(private _serviceService : ServiceService, private _serviceConditionService: ServiceConditionService,
    private _activatedRoute: ActivatedRoute, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل دليل اجراءات الخدمة');
    let query = this._activatedRoute.snapshot.params['id'];
    if (query) {
      this.serviceId = this.globalService.decryptNumber(query.toString());
      if (this.serviceId) {
        this.getServiceById();
        this.getServiceConditions();
      }
      else {
        this.globalService.navigate("/");
      }
    }
    else {
      this.globalService.navigate("/");
    }
  }

  getServiceById(){
    this._serviceService.getById(this.serviceId).subscribe((response) => {
      this.service = response.data
      if (!this.service.isActive) {
        this.globalService.navigate("/");
      }
    });
  }

  getServiceConditions() {
    this._serviceConditionService.getByServiceId(this.serviceId).subscribe((response) => {
      this.getServiceConditionListDto = response.data;
    });
  }

}
