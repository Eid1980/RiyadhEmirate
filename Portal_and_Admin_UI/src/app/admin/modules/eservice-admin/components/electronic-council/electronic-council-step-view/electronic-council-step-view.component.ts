import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-electronic-council-step-view',
  templateUrl: './electronic-council-step-view.component.html',
  styleUrls: ['./electronic-council-step-view.component.scss']
})
export class ElectronicCouncilStepViewComponent implements OnInit {

  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    debugger
    console.log('preview-step')
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
