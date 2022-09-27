import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserSessionDto } from '@shared/proxy/accounts/models';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit {
  userInfo = {} as GetUserSessionDto;
  isAuthenticated: boolean;

  constructor(private accountService: AccountService, private _translateService: TranslationServiceService)
  {
  }

  ngOnInit() {
    this.isAuthenticated = this.isUserAuthenticate();
    if (this.isAuthenticated)
      this.userInfo = this.accountService.getCurrentUserInfo();
  }

  logOut() {
    this.accountService.logOut();
  }

  isUserAuthenticate(): boolean {
    if (localStorage.getItem('EmiratesToken') === null || localStorage.getItem('EmiratesToken') === undefined) {
      return false;
    }
    else {
      return true;
    }
  }

  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }

  onChangeLang() {
    this._translateService.switchLanguage();
  }
}
