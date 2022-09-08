import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetServiceDetailsDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GlobalService } from '@shared/services/global.service';
import { ServiceBenefitService } from '@shared/proxy/service-benefits/service-benefit.service';
import { CreateServiceBenefitDto, GetAllCountDto } from '@shared/proxy/service-benefits/models';
import { CreateServiceRateDto, GetServiceRateDto, GetServiceRateToUserRequestDto } from '@shared/proxy/service-rates/models';
import { ServiceRateService } from '@shared/proxy/service-rates/service-rate.service';
import { ServiceAudienceService } from '@shared/proxy/service-audience/service-audience.service';
import { GetServiceAudienceListDto } from '@shared/proxy/service-audience/models';

@Component({
  selector: 'app-service-details',
  templateUrl: './service-details.component.html'
})
export class ServiceDetailsComponent implements OnInit {
  id: number;
  serviceDetailsDto = {} as GetServiceDetailsDto;
  getServiceAudienceListDto = [] as GetServiceAudienceListDto[];
  getAllCountDto = {} as GetAllCountDto;
  getServiceRateDto = {} as GetServiceRateDto;
  rate: number;
  canRate: boolean = false;

  constructor(private serviceService: ServiceService, private serviceBenefitService: ServiceBenefitService,
    private serviceRateService: ServiceRateService, private serviceAudienceService: ServiceAudienceService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
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
    this.serviceAudienceService.getByServiceId(this.id).subscribe((response) => {
      this.getServiceAudienceListDto = response.data;
    });
    this.getBenefit();
    this.buildRateForm();
  }

  createBenefit(isBenefit: boolean) {
    const createServiceBenefitDto = { serviceId: this.id, isBenefit: isBenefit } as CreateServiceBenefitDto;
    this.serviceBenefitService.create(createServiceBenefitDto).subscribe((response) => {
      if (response.isSuccess) {
        this.globalService.showMessage(response.message);
        this.getBenefit();
      }
    });
  }
  getBenefit() {
    this.serviceBenefitService.getAllCountByServiceId(this.id).subscribe((response) => {
      this.getAllCountDto = response.data;
    });
  }

  rateService() {
    if (this.id && this.canRate) {
      const createServiceRateDto = { serviceId: this.id, starsCount: this.rate } as CreateServiceRateDto;
      this.serviceRateService.create(createServiceRateDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
      });
    }
  }
  buildRateForm() {
    const serviceRateToUserRequestDto = { serviceId: this.id } as GetServiceRateToUserRequestDto;
    this.serviceRateService.getServiceRateToUser(serviceRateToUserRequestDto).subscribe((response) => {
      this.rate = response.data.serviceRate;
      this.canRate = response.data.canRate;
      this.getServiceRateDto = response.data;
    });
  }

}
