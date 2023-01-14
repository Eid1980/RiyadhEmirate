import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-marriage-certificate-view',
  templateUrl: './marriage-certificate-view.component.html'
})
export class MarriageCertificateViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة توثيق زواج");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
