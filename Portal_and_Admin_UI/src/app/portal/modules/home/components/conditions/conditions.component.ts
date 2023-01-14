import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-conditions',
  templateUrl: './conditions.component.html'
})
export class ConditionsComponent implements OnInit {

  constructor(private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("شروط الاستخدام");
  }

}
