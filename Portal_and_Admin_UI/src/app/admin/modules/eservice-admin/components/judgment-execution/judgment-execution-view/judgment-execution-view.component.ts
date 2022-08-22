import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-judgment-execution-view',
  templateUrl: './judgment-execution-view.component.html'
})
export class JudgmentExecutionViewComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
