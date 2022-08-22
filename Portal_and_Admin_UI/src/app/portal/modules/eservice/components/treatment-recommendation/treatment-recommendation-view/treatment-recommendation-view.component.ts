import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-treatment-recommendation-view',
  templateUrl: './treatment-recommendation-view.component.html'
})
export class TreatmentRecommendationViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة طلب علاج");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
