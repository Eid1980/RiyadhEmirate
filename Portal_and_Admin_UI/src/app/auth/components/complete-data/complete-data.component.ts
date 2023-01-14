import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { CompleteDataDto } from '@shared/proxy/accounts/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MobileNumberValidator } from '@shared/custom-validators/mobileNumber.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { IamLoginResponse } from '@shared/enums/iam-login-response.enum';

@Component({
  selector: 'app-complete-data',
  templateUrl: './complete-data.component.html'
})
export class CompleteDataComponent implements OnInit {
  id: number;
  completeDataForm: FormGroup;
  isFormSubmitted: boolean;
  completeDataDto = {} as CompleteDataDto;
  nationalities = [] as LookupDto<number>[];
  governorates = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private accountService: AccountService,
    private lookupService: LookupService, private globalService: GlobalService,
    private _activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('استكمال بيانات المستخدم');
    let query = this._activatedRoute.snapshot.params['key'];
    if (query) {
      this.id = this.globalService.decryptNumber(query.toString());
      if (!this.id) {
        this.globalService.navigate("/auth/login");
      }
    }
    else {
      this.globalService.navigate("/auth/login");
    }
    this.fillLookup();
    this.buildForm();
  }

  buildForm() {
    this.completeDataForm = this.formBuilder.group({
      phoneNumber: [this.completeDataDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      email: [this.completeDataDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],
      nationalityId: [this.completeDataDto.nationalityId || null],
      governorateId: [this.completeDataDto.governorateId || null],
      address: [this.completeDataDto.address || '']
    });
  }

  fillLookup() {
    this.lookupService.getNationalityLookupList().subscribe((response) => {
      this.nationalities = response.data;
    });
    this.lookupService.getGovernorateLookupList().subscribe((response) => {
      this.governorates = response.data;
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.completeDataForm.valid) {
      this.completeDataDto = { ...this.completeDataForm.value } as CompleteDataDto;
      this.completeDataDto.userId = this.id;
      this.accountService.completeUserData(this.completeDataDto).subscribe((response) => {
        if (response.data.iamLoginResponse == IamLoginResponse.Success) {
          localStorage.setItem('EmiratesToken', response.data.tokenHandler);
          this.accountService.getAuthUser().subscribe((res) => {
            localStorage.setItem('AuthUser', JSON.stringify(res.data));
            this.globalService.navigate('/');
          });
        }
        else {
          this.globalService.navigate('/auth/login');
        }
      });
    }
  }
}
