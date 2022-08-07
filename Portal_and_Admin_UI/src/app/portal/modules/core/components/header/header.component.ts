import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '@proxy/accounts/account.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {
  userInfo: any;

  constructor(private accountService: AccountService, private router: Router) {}

  ngOnInit() {
    this.userInfo = this.accountService.getCurrentUserInfo();
  }

  logOut() {
    localStorage.removeItem('EmiratesToken');
    localStorage.removeItem('userInfo');
    this.router.navigate(['/auth/login']);
  }
}
