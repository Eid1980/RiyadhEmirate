import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
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
import { ServiceConditionService } from '@shared/proxy/service-condition/service-condition.service';
import { GetServiceConditionListDto } from '@shared/proxy/service-condition/models';
import { DomSanitizer } from '@angular/platform-browser';
// import * as html2pdf from 'html2pdf.js';
declare let $: any;

@Component({
  selector: 'app-service-details',
  templateUrl: './service-details.component.html'
})
export class ServiceDetailsComponent implements OnInit {
  id: number;
  serviceDetailsDto = {} as GetServiceDetailsDto;
  getServiceAudienceListDto = [] as GetServiceAudienceListDto[];
  getServiceConditionListDto = [] as GetServiceConditionListDto[];
  getAllCountDto = {} as GetAllCountDto;
  getServiceRateDto = {} as GetServiceRateDto;
  rate: number;
  canRate: boolean = false;
  imageExplain: any;
  reportUrl: string;

  @ViewChild("serviceDetails") serviceDetailsDiv: ElementRef;


  constructor(private serviceService: ServiceService, private serviceBenefitService: ServiceBenefitService,
    private serviceRateService: ServiceRateService, private serviceAudienceService: ServiceAudienceService,
    private serviceConditionService: ServiceConditionService, public sanitizer: DomSanitizer,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    debugger
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/service-list");
    }
  }

  getDetails() {
    this.serviceService.getById(this.id).subscribe((response) => {
      debugger
      this.serviceDetailsDto = response.data;
      if (!this.serviceDetailsDto.isActive) {
        this.globalService.navigate("/admin/data-management/service-list");
      }
    });
    this.serviceAudienceService.getByServiceId(this.id).subscribe((response) => {
      this.getServiceAudienceListDto = response.data;
    });
    this.getServiceCondition();
    this.getBenefit();
    this.serviceService.getServiceExplainAttachment(this.id).subscribe((response) => {
      this.imageExplain = response.data;
    });
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
  getServiceCondition() {
    this.serviceConditionService.getByServiceId(this.id).subscribe((response) => {
      this.getServiceConditionListDto = response.data;
    });
  }

  rateService() {
    if (this.id && this.canRate) {
      const createServiceRateDto = { serviceId: this.id, starsCount: this.rate } as CreateServiceRateDto;
      this.serviceRateService.create(createServiceRateDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        this.buildRateForm();
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

  print() {
    var opt = {
      margin: 1,
      filename: 'output.pdf',
      image: { type: 'jpeg', quality: 0.98 },
      html2canvas: { scale: 3 },
      jsPDF: { unit: 'in', format: 'letter', orientation: 'landscape' },
    };

    // html2pdf()
    //   .set(opt)
    //   .from(this.serviceDetailsDiv.nativeElement)
    //   .toPdf()
    //   .save();
    /*.output('blob')
    .then((data: Blob) => {
      this.reportUrl = URL.createObjectURL(data);
      $('#report').attr('src', this.reportUrl);
    });*/
  }

}
