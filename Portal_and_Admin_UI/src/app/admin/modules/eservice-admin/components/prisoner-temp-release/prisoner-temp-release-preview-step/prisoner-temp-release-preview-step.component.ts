import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-prisoner-temp-release-preview-step',
  templateUrl: './prisoner-temp-release-preview-step.component.html'
})
export class PrisonerTempReleasePreviewStepComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
