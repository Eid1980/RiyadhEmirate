import { Component, Input, OnInit } from '@angular/core';
import { GetServiceConditionListDto } from '@shared/proxy/service-condition/models';
import { ServiceConditionService } from '@shared/proxy/service-condition/service-condition.service';

@Component({
  selector: 'app-service-conditions',
  templateUrl: './service-conditions.component.html'
})
export class ServiceConditionsComponent implements OnInit {
  @Input() serviceId: number;
  getServiceConditionListDto = [] as GetServiceConditionListDto[];

  constructor(private serviceConditionService: ServiceConditionService)
  {
  }

  ngOnInit(): void {
  }

  getServiceCondition() {
    this.serviceConditionService.getByServiceId(this.serviceId).subscribe((response) => {
      this.getServiceConditionListDto = response.data;
    });
  }
}
