import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-prisoner-temp-release-view',
  templateUrl: './prisoner-temp-release-view.component.html'
})
export class PrisonerTempReleaseViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة الخروج المؤقت لسجين");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
