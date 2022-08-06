import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { ReportsService } from '../../../services/reports.service';

@Component({
  selector: 'app-reports-edit',
  templateUrl: './reports-edit.component.html',
  styleUrls: ['./reports-edit.component.scss'],
})
export class ReportsEditComponent implements OnInit {
  form: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  editVM: any;
  oldImage: any;

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
    private reportsService: ReportsService,
    private fileManagerService: FileManagerService,
    private router: Router,
    private globalService: GlobalService,
    private activatedRoute: ActivatedRoute,
    private dateFormatterService: DateFormatterService
  ) {}

  ngOnInit() {
    this.form = this.formBuilder.group({
      Id: [null, Validators.required],
      TitleAr: [null, Validators.required],
      TitleEn: [null],
      DescriptionAr: [null, Validators.required],
      DescriptionEn: [null],
      Date: [null, Validators.required],
      HijriDate: [null, Validators.required],
      Image: [null],
      IsActive: [true],
    });

    this.activatedRoute.queryParamMap.subscribe((params) => {
      this.id = Number(params.get('Id'));
      this.getEdit(this.id);
    });
  }

  getEdit(productId) {
    this.reportsService.getById(productId).subscribe((response) => {
      this.editVM = response.data;
      var date = new Date(this.editVM.Date);
      var ngbDateStructGregorian = {
        day: date.getUTCDate() + 1,
        month: date.getUTCMonth() + 1,
        year: date.getUTCFullYear(),
      };
      this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);

      this.form.patchValue({
        Id: this.editVM.Id,
        TitleAr: this.editVM.TitleAr,
        TitleEn: this.editVM.TitleEn,
        DescriptionAr: this.editVM.DescriptionAr,
        DescriptionEn: this.editVM.DescriptionEn,
        Date: this.startDatePicker.getSelectedDate(),
        IsActive: this.editVM.IsActive,
      });

      this.oldImage = this.editVM.Image;
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
      postedVM.Id = this.editVM.Id;
      postedVM.Date = date;
      this.reportsService.update(postedVM).subscribe((response) => {
        if (response.isSuccess) {
          if (this.form.get('Image').value) {
            this.fileManagerService
              .deleteByEntityName(this.editVM.Id, 'Reports')
              .subscribe((res) => {
                this.fileManagerService
                  .upload(this.editVM.Id, 'Reports', '', [
                    this.form.get('Image').value,
                  ])
                  .subscribe((res) => {
                    this.globalService.messageAlert(
                      MessageType.Success,
                      'تم التعديل بنجاح'
                    );
                    this.globalService.navigate(
                      '/admin/data-management/reports-list'
                    );
                  });
              });
          } else {
            this.globalService.navigate('/admin/data-management/reports-list');
          }
        }
      });
    }
  }
}
