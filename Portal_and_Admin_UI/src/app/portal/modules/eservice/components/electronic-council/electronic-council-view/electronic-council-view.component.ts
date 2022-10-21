import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-electronic-council-view',
  templateUrl: './electronic-council-view.component.html'
})
export class ElectronicCouncilViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة المجلس الالكتروني");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
