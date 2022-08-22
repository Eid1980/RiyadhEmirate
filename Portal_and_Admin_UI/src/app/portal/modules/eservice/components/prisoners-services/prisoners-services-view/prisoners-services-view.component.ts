import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-prisoners-services-view',
  templateUrl: './prisoners-services-view.component.html'
})
export class PrisonersServicesViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمات السجناء");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
