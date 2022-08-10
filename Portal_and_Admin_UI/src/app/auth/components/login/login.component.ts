import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@proxy/accounts/account.service';
import { UserLoginDto } from '@proxy/accounts/models';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  userLoginDto = {} as UserLoginDto;
  isFormSubmitted: boolean;
  returnUrl: string;

  constructor(
    private formBuilder: FormBuilder,
    private _accountService: AccountService,
    private router: Router,
    private globalService: GlobalService,
    private _translateService: TranslationServiceService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
    this.buildForm();
  }

  buildForm() {
    this.loginForm = this.formBuilder.group({
      userName: [this.userLoginDto.userName, Validators.required],
      password: [this.userLoginDto.password, Validators.required],
    });
  }

  onSubmit() {
    this._accountService.login(this.loginForm.value).subscribe(
      (response) => {
        if (response.isSuccess) {
          localStorage.setItem('EmiratesToken', response.data);
          this._accountService.getAuthUser().subscribe(
            (res) => {
              localStorage.setItem('AuthUser', JSON.stringify(res.data));
            },
            (err) => {}
          );

          if (this.returnUrl) {
            this.router.navigateByUrl(this.returnUrl);
          } else {
            this.router.navigate(['/home/']);
          }
        } else {
          this.globalService.messageAlert(
            MessageType.Error,
            this._translateService.instant(
              'login.messages.invalidUsernameOrPassword'
            )
          );
        }
      },
      (error) => {
        this.globalService.messageAlert(
          MessageType.Error,
          this._translateService.instant(
            'login.messages.invalidUsernameOrPassword'
          )
        );
      }
    );
  }

  // Translations
  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }

  onChangeLang() {
    this._translateService.switchLanguage();
  }
}
