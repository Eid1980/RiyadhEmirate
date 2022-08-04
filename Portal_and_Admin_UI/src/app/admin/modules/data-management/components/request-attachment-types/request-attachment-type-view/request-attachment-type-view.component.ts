import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetRequestAttachmentTypeDetailsDto } from '@proxy/request-attachment-types/models';
import { RequestAttachmentTypeService } from '@proxy/request-attachment-types/request-attachment-type.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-request-attachment-type-view',
  templateUrl: './request-attachment-type-view.component.html'
})
export class RequestAttachmentTypeViewComponent implements OnInit {
  id: number;
  requestAttachmentTypeDetailsDto: GetRequestAttachmentTypeDetailsDto;

  constructor(private requestAttachmentTypeService: RequestAttachmentTypeService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل مرفق الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.requestAttachmentTypeService.getById(this.id).subscribe((response) => {
      this.requestAttachmentTypeDetailsDto = response.data;
    });
  }

}
