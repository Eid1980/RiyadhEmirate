import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-judgment-execution-view',
  templateUrl: './judgment-execution-view.component.html'
})
export class JudgmentExecutionViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة انفاذ حكم شرعي");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
