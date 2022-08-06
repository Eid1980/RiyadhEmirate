import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateType } from 'ngx-hijri-gregorian-datepicker';
import { ReportsService } from '../../../services/reports.service';

@Component({
  selector: 'app-reports-add',
  templateUrl: './reports-add.component.html',
  styleUrls: ['./reports-add.component.scss'],
})
export class ReportsAddComponent implements OnInit {
  form: FormGroup;
  isFormSubmitted: boolean;

  // for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 1000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;

  @ViewChild('datePicker') startDatePicker: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;

  constructor(
    private formBuilder: FormBuilder,
    private latestNewsService: ReportsService,
    private fileManagerService: FileManagerService,
    private router: Router,
    private globalService: GlobalService
  ) {}

  ngOnInit() {
    this.form = this.formBuilder.group({
      TitleAr: [null, Validators.required],
      TitleEn: [null],
      DescriptionAr: [null, Validators.required],
      DescriptionEn: [null],
      Date: [null],
      Image: [null, Validators.required],
      IsActive: [true],
    });
  }

  onUpload(event: any) {
    this.form.get('Image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.form.get('Image').setValue(null);
  }

  onSelectGregorianDate() {
    let gregorianDate: Date = this.form.get('Date').value as Date;
    let hijriDate = this.globalService.convertToHijri(gregorianDate, 'ar');
    this.form.get('HijriDate').setValue(hijriDate);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.startDatePicker.getSelectedDate();
    this.isValidDate = false;
    if (this.date == null) {
      this.isValidDate = true;
      return;
    }
    if (this.form.valid) {
      const postedVM = this.form.value;
      postedVM.Date = date;
      this.latestNewsService.create(postedVM).subscribe((response) => {
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService
            .upload(id, 'Reports', '', [this.form.get('Image').value])
            .subscribe((res) => {
              this.globalService.messageAlert(
                MessageType.Success,
                'تم الحفظ بنجاح'
              );
              this.globalService.navigate(
                '/admin/data-management/reports-list'
              );
            });
        }
      });
    }
  }
}
