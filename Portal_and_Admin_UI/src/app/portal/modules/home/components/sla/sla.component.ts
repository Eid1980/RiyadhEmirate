import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-sla',
  templateUrl: './sla.component.html'
})
export class SLAComponent implements OnInit {

  constructor(private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("اتفاقية مستوى الخدمة");
  }

}
