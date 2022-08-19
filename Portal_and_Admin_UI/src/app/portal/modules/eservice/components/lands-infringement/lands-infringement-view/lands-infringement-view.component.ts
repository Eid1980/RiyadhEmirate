import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-lands-infringement-view',
  templateUrl: './lands-infringement-view.component.html'
})
export class LandsInfringementViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة التعدي على الأراضي الحكومية");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
