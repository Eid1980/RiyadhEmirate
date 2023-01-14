import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-privacy',
  templateUrl: './privacy.component.html'
})
export class PrivacyComponent implements OnInit {

  constructor(private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("سياسة الخصوصية");

    window.scroll({
      top: 0,
      left: 0,
      behavior: 'smooth'
    });
  }

}
