import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-electronic-summon-view',
  templateUrl: './electronic-summon-view.component.html'
})
export class ElectronicSummonViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة الاستدعاء الالكتروني");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
