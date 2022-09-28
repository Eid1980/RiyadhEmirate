import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss'],
})
export class MenuComponent implements OnInit {

  constructor(private accountService: AccountService) {}

  ngOnInit() {
  }

  logOut() {
    this.accountService.logOut();
  }
}
