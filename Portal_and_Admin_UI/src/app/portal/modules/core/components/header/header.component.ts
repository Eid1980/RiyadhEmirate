import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDto } from '@shared/proxy/accounts/models';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit {
  userInfo: GetUserDto;
  isAuthenticated: boolean;

  constructor(
    private accountService: AccountService,
    private _translateService: TranslationServiceService,
    private router: Router) {}

  ngOnInit() {
    this.isAuthenticated = this.isUserAuthenticate();
    if (this.isAuthenticated)
      this.userInfo = this.accountService.getCurrentUserInfo();
  }

  logOut() {
    localStorage.removeItem('EmiratesToken');
    localStorage.removeItem('userInfo');
    this.router.navigate(['/auth/login']);
  }

  isUserAuthenticate(): boolean {
    if (
      localStorage.getItem('EmiratesToken') === null ||
      localStorage.getItem('EmiratesToken') === undefined
    ) {
      return false;
    } else {
      return true;
    }
  }

  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }

  onChangeLang() {
    debugger
    this._translateService.switchLanguage();
  }
}
