import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { Role } from '../../../../../shared/enums/role.enum';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss'],
})
export class MenuComponent implements OnInit {
  roleIds = [] as number[];
  superSystemAdmin: number = Role.SuperSystemAdmin;
  systemAdmin: number = Role.SystemAdmin;
  newsPermission: number = Role.NewsPermission;
  settingPermission: number = Role.SettingPermission;
  usersPermission: number = Role.UsersPermission;
  requestReview: number = Role.RequestReview;
  shamelRequestReview: number = Role.ShamelRequestReview;

  constructor(private accountService: AccountService) {
  }

  ngOnInit() {
    let roles = this.accountService.getCurrentUserInfo().roleIds;
    if (roles) {
      this.roleIds = roles.split(',').map(function (item) {
        return parseInt(item, 10);
      });;
    }
  }

  logOut() {
    this.accountService.logOut();
  }

}
