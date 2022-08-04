import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetRequestTypeDetailsDto } from '@proxy/request-types/models';
import { RequestTypeService } from '@proxy/request-types/request-type.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-request-type-view',
  templateUrl: './request-type-view.component.html'
})
export class RequestTypeViewComponent implements OnInit {
  id: number;
  requestTypeDetailsDto: GetRequestTypeDetailsDto;

  constructor(private requestTypeService: RequestTypeService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل نوع الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.requestTypeService.getById(this.id).subscribe((response) => {
      this.requestTypeDetailsDto = response.data;
    });
  }

}
