import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.scss']
})
export class EditProfileComponent implements OnInit {

  editProfileForm = new FormGroup({
    nationalId: new FormControl({ value: '26209070125465', disabled: false }, Validators.required),
    birthdate: new FormControl({ value: '1962/09/07', disabled: false }, Validators.required),
    gender: new FormControl({ value: 'male', disabled: false }, Validators.required),
    passportID: new FormControl({ value: '2958745325412', disabled: false }, Validators.required),
    firstNameAr: new FormControl({ value: 'محمد', disabled: false }, Validators.required),
    secondNameAr: new FormControl({ value: 'احمد', disabled: false }, Validators.required),
    thirdNameAr: new FormControl({ value: 'سامح', disabled: false }, Validators.required),
    lastNameAr: new FormControl({ value: 'يوسف', disabled: false }, Validators.required),
    firstNameEn: new FormControl({ value: 'Mohamed', disabled: false }, Validators.required),
    secondNameEn: new FormControl({ value: 'Ahmed', disabled: false }, Validators.required),
    thirdNameEn: new FormControl({ value: 'Sameh', disabled: false }, Validators.required),
    lastNameEn: new FormControl({ value: 'Yousef', disabled: false }, Validators.required),
    password: new FormControl({ value: '1234', disabled: false }, Validators.required),
    mobileNumber: new FormControl({ value: '01006485202', disabled: false }, Validators.required),
    userEmail: new FormControl({ value: 'xxx@gmail.com', disabled: false }, Validators.required),
    nationality: new FormControl({ value: 'egyptian', disabled: false }, Validators.required),
    gov: new FormControl({ value: 'egypt', disabled: false }, Validators.required),
    address: new FormControl({ value: '11 cairo', disabled: false }, Validators.required)
  });

  constructor() { }

  ngOnInit(): void {
  }

}
