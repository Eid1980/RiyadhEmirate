import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateUserDto} from '@shared/proxy/accounts/register.model';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { UserLoginDto } from '@shared/proxy/accounts/models';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MessageType } from '@shared/enums/message-type.enum';
import { NationalityIDValidator } from '@shared/custom-validators/nationalityId.validator';
import { MobileNumberValidator } from '@shared/custom-validators/mobileNumber.validator';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  userRegisterForm: FormGroup;
  isFormSubmitted: boolean = false;
  showCheckUserRegisterForm: boolean = true;

  createUserDto = {} as CreateUserDto;
  nationalities = [] as LookupDto<number>[];

  //#region for datePicker
  @ViewChild('birthDate') birthDate: any;
  isValidDate = false;
  selectedDateType = DateType.Hijri;
  //minHigriDate: NgbDateStruct;
  minGreg: NgbDateStruct;
  minHigriDate: NgbDateStruct;
  maxHigriDate: NgbDateStruct;
  maxGreg: NgbDateStruct;
  dateOfBirth: NgbDateStruct;
  //#endregion

  constructor(
    private formBuilder: FormBuilder,
    private globalService: GlobalService,
    private accountService: AccountService,
    private lookupService: LookupService,
    private dateFormatterService: DateFormatterService
  ) {
    //this.minHigriDate = { day: 1, month: 1, year: 1360 };
    let nowDate = new Date();
    let nowDateHijri = dateFormatterService.GetTodayHijri();
    this.minHigriDate = {
      day: 1,
      month: 1,
      year: 1360,
    };
    this.maxHigriDate = {
      day: nowDateHijri.day,
      month: nowDateHijri.month,
      year: nowDateHijri.year - 18,
    };
    this.minGreg = { day: 1, month: 1, year: 1940 };
    this.maxGreg = {
      day: nowDate.getUTCDate() + 1,
      month: nowDate.getUTCMonth() + 1,
      year: nowDate.getUTCFullYear() - 18,
    };
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تسجيل مستخدم جديد');
    this.fillLookup();
    this.buildRegisterForm();
  }
  buildRegisterForm() {
    this.userRegisterForm = this.formBuilder.group({
      userName: [this.createUserDto.userName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, NationalityIDValidator.validateNationalityID]],
      birthDate: [this.createUserDto.birthDate || null],
      passWord: [this.createUserDto.passWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.pattern('^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,20}$')]],
      confirmPassWord: [this.createUserDto.confirmPassWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.pattern('^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,20}$')]],

      firstNameAr: [this.createUserDto.firstNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      secondNameAr: [this.createUserDto.secondNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      thirdNameAr: [this.createUserDto.thirdNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      lastNameAr: [this.createUserDto.lastNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      firstNameEn: [this.createUserDto.firstNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      secondNameEn: [this.createUserDto.secondNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      thirdNameEn: [this.createUserDto.thirdNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      lastNameEn: [this.createUserDto.lastNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      phoneNumber: [this.createUserDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      email: [this.createUserDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],

      passportId: [this.createUserDto.passportId || ''],
      isMale: [this.createUserDto.isMale || null, Validators.required],

      nationalityId: [this.createUserDto.nationalityId || null],
      address: [this.createUserDto.address || ''],
    }, {
      validators: this.comparePassword('passWord', 'confirmPassWord')
    });
  }

  comparePassword(controlName: string, matchControlName: string) {
    return (formGroup: FormGroup) => {
      const control = formGroup.controls[controlName];
      const matchControl = formGroup.controls[matchControlName];
      if (matchControl.errors && !matchControl.errors.notMatch) {
        return;
      }
      if (control.value !== matchControl.value) {
        matchControl.setErrors({ notMatch: true });
      }
      else {
        matchControl.setErrors(null);
      }
    }
  }

  onRegister() {
    this.isFormSubmitted = true;
    this.isValidDate = false;
    if (this.birthDate?.getSelectedDate() == 'Invalid date') {
      this.isValidDate = true;
      return;
    }
    if (this.userRegisterForm.valid) {
      this.createUserDto = { ...this.userRegisterForm.value } as CreateUserDto;
      this.createUserDto.birthDate = this.birthDate.getSelectedDate();
      this.accountService.register(this.createUserDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.login();
        }
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء استكمال البيانات المطلوبة');
    }
  }
  fillLookup() {
    this.lookupService.getNationalityLookupList().subscribe((response) => {
      this.nationalities = response.data;
    });
  }
  login() {
    let userLoginDto = { userName: this.createUserDto.userName, password: this.createUserDto.passWord } as UserLoginDto;
    this.accountService.login(userLoginDto).subscribe((response) => {
        if (response.isSuccess) {
          localStorage.setItem('EmiratesToken', response.data);
          this.globalService.navigate('/home/');
        }
      },
      (error) => {
        this.globalService.navigate('/auth/login');
      }
    );
  }
}
