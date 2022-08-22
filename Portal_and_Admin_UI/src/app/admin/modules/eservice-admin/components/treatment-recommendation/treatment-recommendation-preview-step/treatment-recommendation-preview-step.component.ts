import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-treatment-recommendation-preview-step',
  templateUrl: './treatment-recommendation-preview-step.component.html'
})
export class TreatmentRecommendationPreviewStepComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
