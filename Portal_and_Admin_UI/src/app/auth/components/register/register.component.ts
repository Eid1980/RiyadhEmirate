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
  date: NgbDateStruct;
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
      nationalId: [
        this.checkUserRegisterDto.nationalId || '',
        Validators.required,
      ],
      birthDate: [this.checkUserRegisterDto.birthDate || ''],
    });
  }
  buildRegisterForm() {
    this.userRegisterForm = this.formBuilder.group({
      userName: [this.createUserDto.userName || '', Validators.required],
      birthDate: [this.createUserDto.birthDate || ''],
      passWord: [this.createUserDto.passWord || '', Validators.required],
      confirmPassWord: [
        this.createUserDto.confirmPassWord || '',
        Validators.required,
      ],

      firstNameAr: [this.createUserDto.firstNameAr || '', Validators.required],
      secondNameAr: [
        this.createUserDto.secondNameAr || '',
        Validators.required,
      ],
      thirdNameAr: [this.createUserDto.thirdNameAr || '', Validators.required],
      lastNameAr: [this.createUserDto.lastNameAr || '', Validators.required],

      firstNameEn: [this.createUserDto.firstNameEn || '', Validators.required],
      secondNameEn: [
        this.createUserDto.secondNameEn || '',
        Validators.required,
      ],
      thirdNameEn: [this.createUserDto.thirdNameEn || '', Validators.required],
      lastNameEn: [this.createUserDto.lastNameEn || '', Validators.required],

      phoneNumber: [this.createUserDto.phoneNumber || '', Validators.required],
      email: [this.createUserDto.email || '', Validators.required],

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

          let dt = new Date(this.checkUserRegisterDto.birthDate);
          let ngbDateStructGregorian = {
            day: dt.getUTCDate() + 1,
            month: dt.getUTCMonth() + 1,
            year: dt.getUTCFullYear(),
          };
          this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);

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
