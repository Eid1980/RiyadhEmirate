import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CheckUserRegisterDto, CreateUserDto} from '@shared/proxy/accounts/register.model';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { UserLoginDto } from '@shared/proxy/accounts/models';
import { Router } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  checkUserRegisterForm: FormGroup;
  userRegisterForm: FormGroup;
  isFormSubmitted: boolean = false;
  showCheckUserRegisterForm: boolean = true;
  showUserRegisterForm: boolean = false;

  checkUserRegisterDto = {} as CheckUserRegisterDto;
  createUserDto = {} as CreateUserDto;
  governorates = [] as LookupDto<number>[];
  nationalities = [] as LookupDto<number>[];

  //#region for datePicker
  @ViewChild('birthDate') birthDate: any;
  isValidDate = false;
  selectedDateType = DateType.Hijri;
  //minHigriDate: NgbDateStruct;
  //minGreg: NgbDateStruct;
  maxHigriDate: NgbDateStruct;
  maxGreg: NgbDateStruct;
  dateOfBirth: NgbDateStruct;

  //#endregion

  constructor(
    private formBuilder: FormBuilder,
    private globalService: GlobalService,
    private accountService: AccountService,
    private lookupService: LookupService,
    private router: Router,
    private dateFormatterService: DateFormatterService
  ) {
    //this.minHigriDate = { day: 1, month: 1, year: 1360 };
    let nowDate = new Date();
    let nowDateHijri = dateFormatterService.GetTodayHijri();
    this.maxHigriDate = {
      day: nowDateHijri.day,
      month: nowDateHijri.month,
      year: nowDateHijri.year - 18,
    };
    //this.minGreg = { day: 1, month: 1, year: 1950 };
    this.maxGreg = {
      day: nowDate.getUTCDate() + 1,
      month: nowDate.getUTCMonth() + 1,
      year: nowDate.getUTCFullYear() - 18,
    };
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تسجيل مستخدم جديد');
    this.buildCheckForm();
  }

  buildCheckForm() {
    this.checkUserRegisterForm = this.formBuilder.group({
      nationalId: [this.checkUserRegisterDto.nationalId || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      birthDate: [this.checkUserRegisterDto.birthDate || null],
    });
  }
  buildRegisterForm() {
    this.userRegisterForm = this.formBuilder.group({
      userName: [this.createUserDto.userName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      birthDate: [this.createUserDto.birthDate || null],
      passWord: [this.createUserDto.passWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      confirmPassWord: [this.createUserDto.confirmPassWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      firstNameAr: [this.createUserDto.firstNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      secondNameAr: [this.createUserDto.secondNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      thirdNameAr: [this.createUserDto.thirdNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      lastNameAr: [this.createUserDto.lastNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      firstNameEn: [this.createUserDto.firstNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      secondNameEn: [this.createUserDto.secondNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      thirdNameEn: [this.createUserDto.thirdNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      lastNameEn: [this.createUserDto.lastNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      phoneNumber: [this.createUserDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.createUserDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      passportId: [this.createUserDto.passportId || ''],
      isMale: [this.createUserDto.isMale || null, Validators.required],

      nationalityId: [this.createUserDto.nationalityId || null],
      governorateId: [this.createUserDto.governorateId || null],
      address: [this.createUserDto.address || ''],
    });
  }
  onCheck() {
    this.isFormSubmitted = true;
    this.isValidDate = false;
    if (this.birthDate.getSelectedDate() == 'Invalid date') {
      this.isValidDate = true;
      return;
    }
    if (this.checkUserRegisterForm.valid) {
      this.checkUserRegisterDto = {
        ...this.checkUserRegisterForm.value,
      } as CheckUserRegisterDto;
      this.checkUserRegisterDto.birthDate = this.birthDate.getSelectedDate();

      this.accountService
        .checkUserRegister(this.checkUserRegisterDto)
        .subscribe((response) => {
          this.createUserDto = response.data;
          let date = new Date(response.data.birthDate);
          let ngbDateStructGregorian = {
            day: date.getUTCDate() + 1,
            month: date.getUTCMonth() + 1,
            year: date.getUTCFullYear(),
          };
          this.dateOfBirth = this.dateFormatterService.ToHijri(ngbDateStructGregorian);

          if (response.isSuccess) {
            this.showCheckUserRegisterForm = false;
            this.showUserRegisterForm = true;
            this.isFormSubmitted = false;
            this.fillLookup();
            this.buildRegisterForm();
          }
        });
    }
  }
  onRegister() {
    this.isFormSubmitted = true;
    this.isValidDate = false;
    if (this.birthDate.getSelectedDate() == 'Invalid date') {
      this.isValidDate = true;
      return;
    }
    if (this.checkUserRegisterForm.valid) {
      this.createUserDto = { ...this.userRegisterForm.value } as CreateUserDto;
      this.checkUserRegisterDto.birthDate = this.birthDate.getSelectedDate();
      this.accountService.register(this.createUserDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          //login
          this.login();
        }
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء استكمال البيانات المطلوبة');
    }
  }
  fillLookup() {
    this.lookupService.getGovernorateLookupList().subscribe((response) => {
      this.governorates = response.data;
    });
    this.lookupService.getNationalityLookupList().subscribe((response) => {
      this.nationalities = response.data;
    });
  }
  login() {
    let userLoginDto = {
      userName: this.createUserDto.userName,
      password: this.createUserDto.passWord,
    } as UserLoginDto;
    this.accountService.login(userLoginDto).subscribe(
      (response) => {
        if (response.isSuccess) {
          localStorage.setItem('EmiratesToken', response.data);
          this.router.navigate(['/home/']);
        }
      },
      (error) => {
        this.globalService.navigate('/auth/login');
      }
    );
  }
}
