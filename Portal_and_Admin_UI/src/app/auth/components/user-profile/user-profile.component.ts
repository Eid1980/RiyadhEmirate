import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html'
})
export class UserProfileComponent implements OnInit {
  constructor() { }

  items: MenuItem[];

  ngOnInit() {
    this.items = [
      {label: 'البيانات الشخصية'},
      {label: 'بيانات الاتصال'},
      {label: 'Step 3'}
  ];
  }
}
