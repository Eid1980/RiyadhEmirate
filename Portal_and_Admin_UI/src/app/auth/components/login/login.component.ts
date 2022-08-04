import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@proxy/accounts/account.service';
import { UserLoginDto } from '@proxy/accounts/models';

@Component({
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  userLoginDto = {} as UserLoginDto;
  isFormSubmitted: boolean;
  returnUrl: string;

  constructor(private formBuilder: FormBuilder, private accountService: AccountService,
    private router: Router, private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit() {
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
    this.buildForm();
    /*if (localStorage.getItem('EmiratesToken')) {
      this.router.navigate(['/home']);
      return;
    }*/
  }

  buildForm() {
    this.loginForm = this.formBuilder.group({
      userName: [this.userLoginDto.userName || '', Validators.required],
      password: [this.userLoginDto.password || '', Validators.required]
    });
  }

  onSubmit() {
    this.accountService.login(this.loginForm.value).subscribe(
      (response) => {
        if (response.isSuccess) {
          localStorage.setItem('EmiratesToken', response.data);
          if (this.returnUrl) {
            this.router.navigateByUrl(this.returnUrl);
          } else {
            this.router.navigate(['/home/']);
          }
        } else {
          this.router.navigate(['/auth/login']);
          this.globalService.messageAlert(
            MessageType.Error,
            'اسم المستخدم او كلمة المرور غير صحيحة'
          );
        }
      },
      (error) => {
        this.globalService.messageAlert(
          MessageType.Error,
          'اسم المستخدم او كلمة المرور غير صحيحة'
        );
      }
    );
  }
}
