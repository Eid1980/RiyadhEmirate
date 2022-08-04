import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { Router } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss'],
})
export class MenuComponent implements OnInit {
  userInfo: any;
  childs: any[] = [];

  constructor(private accountService: AccountService, private router: Router) {}

  ngOnInit() {
    this.userInfo = this.accountService.getCurrentUserInfo();
  }

  getChildrens(parentId) {
    return this.userInfo.MenueItems.filter(
      (c) => c.ParentId === parentId && c.MenueType === 2
    ) as any[];
  }

  logOut() {
    localStorage.removeItem('EmiratesToken');
    localStorage.removeItem('userInfo');
    this.router.navigate(['/auth/login']);
  }
}
