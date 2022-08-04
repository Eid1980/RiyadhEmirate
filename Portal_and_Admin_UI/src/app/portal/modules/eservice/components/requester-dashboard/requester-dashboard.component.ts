import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { RequestService } from '@proxy/requests/request.service';

@Component({
  selector: 'app-requester-dashboard',
  templateUrl: './requester-dashboard.component.html'
})
export class RequesterDashboardComponent implements OnInit {
  constructor(private requestService: RequestService, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('طلباتي');
  }

}
