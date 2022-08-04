import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ServiceRateService } from '@proxy/service-rates/service-rate.service';
import { CreateServiceRateDto, GetServiceRateToUserRequestDto } from '@proxy/service-rates/models';
import { GlobalService } from '../../services/global.service';

@Component({
  selector: 'app-rate-service',
  templateUrl: './rate-service.component.html'
})
export class RateServiceComponent implements OnInit {
  @Output() canRateEvent = new EventEmitter<boolean>();
  @Input() showServiceRate: boolean = false;
  @Input() serviceId: number;
  @Input() redirectUrl: string;
  rate: number;
  canRate: boolean = false;

  constructor(private serviceRateService: ServiceRateService, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
  }

  buildForm() {
    const serviceRateToUserRequestDto = { serviceId: this.serviceId } as GetServiceRateToUserRequestDto;
    this.serviceRateService.getServiceRateToUser(serviceRateToUserRequestDto).subscribe((response) => {
      this.rate = response.data.serviceRate;
      this.canRate = response.data.canRate;
      this.canRateEvent.emit(this.canRate);
    });
  }

  rateService() {
    if (this.serviceId) {
      const createServiceRateDto = { serviceId: this.serviceId, starsCount: this.rate } as CreateServiceRateDto;
      this.serviceRateService.create(createServiceRateDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        this.showServiceRate = false;
      });
    }
  }
  redirectTo() {
    if (this.redirectUrl) {
      this.globalService.navigate(this.redirectUrl);
    }
  }
}
