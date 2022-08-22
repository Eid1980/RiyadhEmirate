import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-foreigners-realty-owner-preview-step',
  templateUrl: './foreigners-realty-owner-preview-step.component.html'
})
export class ForeignersRealtyOwnerPreviewStepComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
