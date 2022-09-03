import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDto } from '@shared/proxy/accounts/models';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {
  userInfo = {} as GetUserDto;

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
