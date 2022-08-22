import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-judgment-execution-preview-step',
  templateUrl: './judgment-execution-preview-step.component.html'
})
export class JudgmentExecutionPreviewStepComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
