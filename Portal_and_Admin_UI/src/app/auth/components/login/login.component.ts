import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {

  constructor(private _translateService: TranslationServiceService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setTitle("تسجيل دخول مستخدم");
  }

  // Translations
  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }
  onChangeLang() {
    this._translateService.switchLanguage();
  }
}
