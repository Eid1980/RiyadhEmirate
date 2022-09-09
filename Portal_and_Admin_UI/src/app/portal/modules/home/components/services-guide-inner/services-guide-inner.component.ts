import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { GetServiceDetailsDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';

@Component({
  selector: 'app-services-guide-inner',
  templateUrl: './services-guide-inner.component.html',
  styleUrls: ['./services-guide-inner.component.scss']
})
export class ServicesGuideInnerComponent implements OnInit {

  serviceId : number

  service = {} as GetServiceDetailsDto

  constructor(private _serviceService : ServiceService,
    private _activatedRoute: ActivatedRoute,
    public sanitizer: DomSanitizer) { }

  ngOnInit(): void {
    this.serviceId = this._activatedRoute.snapshot.params['id'];

    this.getServiceById();

  }

  getServiceById(){
    this._serviceService.getById(this.serviceId).subscribe(
      (response) => {
        this.service = response.data
      },
      (error) => {}
    )
  }

}
