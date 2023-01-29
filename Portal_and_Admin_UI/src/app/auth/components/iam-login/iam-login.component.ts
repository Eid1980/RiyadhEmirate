import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { IamLoginResponse } from '@shared/enums/iam-login-response.enum';
import { CheckIamUserRequestDto } from '@shared/proxy/accounts/models';

@Component({
  selector: 'app-iam-login',
  templateUrl: './iam-login.component.html'
})
export class IamLoginComponent implements OnInit {
  nationalId: string;
  checkIamUserRequestDto = {} as CheckIamUserRequestDto;

  constructor(private accountService: AccountService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.nationalId = this.activatedRoute.snapshot.params['id'];
    if (this.nationalId) {
      this.checkIamUserRequestDto = { nationalId: this.nationalId } as CheckIamUserRequestDto;
      this.checkIamUser();
    } else {
      this.globalService.navigate('/auth/login');
    }
  }

  checkIamUser() {
    this.accountService.checkIamUser(this.checkIamUserRequestDto).subscribe(response => {
      if (response.data.iamLoginResponse == IamLoginResponse.Success) {
        localStorage.setItem('EmiratesToken', response.data.tokenHandler);
        this.accountService.getAuthUser().subscribe((res) => {
          localStorage.setItem('AuthUser', JSON.stringify(res.data));
          this.globalService.navigate('/');
        });
      }
      else if (response.data.iamLoginResponse == IamLoginResponse.UserDataNotComplete) {
        this.globalService.navigateParams('/auth/complete-data', {key: this.globalService.encryptNumber(response.data.userId) });
      }
      else {
        this.globalService.navigate('/auth/login');
      }
    });
  }

}
