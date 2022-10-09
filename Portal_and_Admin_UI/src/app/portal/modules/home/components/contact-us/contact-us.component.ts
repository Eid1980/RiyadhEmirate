import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html'
})
export class ContactUsComponent implements OnInit {

  constructor(private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("تواصل معنا");
  }

}
