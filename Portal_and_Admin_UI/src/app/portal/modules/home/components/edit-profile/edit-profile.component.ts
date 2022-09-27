import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { GetUserProfileData, UpdateUserProfileDto } from '@shared/proxy/accounts/models';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.scss']
})
export class EditProfileComponent implements OnInit {

  editProfileForm: FormGroup;
  isFormSubmitted: boolean;
    //#region for uploader
    @ViewChild('uploader', { static: true }) uploader;
    isMultiple: boolean = false;
    fileSize: number = 10000000;
    acceptType: 'image/*';
    isCustomUpload: boolean = true;
    isDisabled: boolean = false;
    //#endregion
    //#region for datePicker
    @ViewChild('birthDate') birthDate: any;
    isValidDate = false;
    date: NgbDateStruct;
    selectedDateType = DateType.Hijri;
    //#endregion

    maxHigriDate: NgbDateStruct;
    maxGreg: NgbDateStruct;

  userProfileData = {} as GetUserProfileData;

  updateUserProfileDto = {} as UpdateUserProfileDto;

  governorates = [] as LookupDto<number>[];
  nationalities = [] as LookupDto<number>[];

  constructor(private _accountService : AccountService,
    private formBuilder: FormBuilder,
    private fileManagerService: FileManagerService,
    private _dateFormatterService: DateFormatterService,
    private globalService: GlobalService,
    private lookupService: LookupService,
    ) {

      let nowDate = new Date();
      let nowDateHijri = _dateFormatterService.GetTodayHijri();
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
    this.buildForm();

    let userId =  JSON.parse(localStorage.getItem("AuthUser")).id;

    this._accountService.getUserProfileData(userId).subscribe(
      (response) => {
        debugger
        if(response.isSuccess)
        this.userProfileData = response.data
        let date = new Date(this.userProfileData.birthDate);
        let ngbDateStructGregorian = {
          day: date.getUTCDate() + 1,
          month: date.getUTCMonth() + 1,
          year: date.getUTCFullYear(),
        };
        this.date = this._dateFormatterService.ToHijri(ngbDateStructGregorian);
        this.buildForm();
      } , () => {});

      this.fillLookup();
  }

  email: string;
  phoneNumber: string;
  passportId: string;
  nationalityId: number;
  nationalityName: string;
  governorateId: number;
  governorateName: string;
  address: string;


  buildForm() {
    this.editProfileForm = this.formBuilder.group({
      id : [this.userProfileData.id , [Validators.required]],
      //nationalId: [{value: this.userProfileData.nationalId, disabled: false }, [Validators.required]],
      nationalId: [{value: null, disabled: false }, [Validators.required]],
      birthdate: [{ value: this.userProfileData.birthDate, disabled: false }, [Validators.required]],
      isMale: [this.userProfileData.isMale? 1 : 2, [Validators.required]],
      passportId: [{value: this.userProfileData.passportId, disabled: false }, [Validators.required]],
      firstNameAr: [{ value: this.userProfileData.firstNameAr, disabled: false }, [Validators.required]],
      secondNameAr: [{ value: this.userProfileData.secondNameAr, disabled: false }, [Validators.required]],
      thirdNameAr: [{ value: this.userProfileData.thirdNameAr, disabled: false }, [Validators.required]],
      lastNameAr: [{ value: this.userProfileData.lastNameAr, disabled: false }, [Validators.required]],
      firstNameEn: [{value: this.userProfileData.firstNameEn, disabled: false }, [Validators.required]],
      secondNameEn: [{ value: this.userProfileData.secondNameAr, disabled: false }, [Validators.required]],
      thirdNameEn: [{ value: this.userProfileData.thirdNameAr, disabled: false }, [Validators.required]],
      lastNameEn: [{ value: this.userProfileData.lastNameAr, disabled: false }, [Validators.required]],
      image: [null],
      //password: [{ value: '1234', disabled: false }, [Validators.required]],
      phoneNumber: [{ value: this.userProfileData.phoneNumber, disabled: false }, [Validators.required]],
      email: [{ value: this.userProfileData.email, disabled: false }, [Validators.required]],
      nationalityId: [this.userProfileData.nationalityId, [Validators.required]],
      governorateId: [this.userProfileData.governorateId, [Validators.required]],
      address: [{ value: this.userProfileData.address, disabled: false }, [Validators.required]]
    });

  }
  onUpload(event: any) {
    this.editProfileForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.editProfileForm.get('image').setValue(null);
  }
  fillLookup() {
    this.lookupService.getGovernorateLookupList().subscribe((response) => {
      this.governorates = response.data;
    });
    this.lookupService.getNationalityLookupList().subscribe((response) => {
      this.nationalities = response.data;
    });
  }
  onSelectGregorianDate() {
    let gregorianDate: Date = this.editProfileForm.get('date').value as Date;
    let hijriDate = this.globalService.convertToHijri(gregorianDate, 'ar');
    this.editProfileForm.get('HijriDate').setValue(hijriDate);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    //let date = this.startDatePicker.getSelectedDate();
    this.isValidDate = false;
    if (this.birthDate?.getSelectedDate() == 'Invalid date') {
      this.isValidDate = true;
      return;
    }

    if (this.date == null) {
      this.isValidDate = true;
      return;
    }
    if (this.editProfileForm.valid) {
      this.updateUserProfileDto = { ...this.editProfileForm.value } as UpdateUserProfileDto;
      this.updateUserProfileDto.isMale = this.editProfileForm.value.isMale == 1 ? true : false
      this._accountService.updateUserProfile(this.updateUserProfileDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService.upload(id, 'LatestNews', '', [this.editProfileForm.get('image').value]).subscribe(res => {
            this.globalService.navigate("/admin/data-management/latest-news-ar-list");
          })
        }
      });
    }
  }
}
