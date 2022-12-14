import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { LatestNewsService } from '../../../services/latest-news.service';

@Component({
  selector: 'app-latest-news-edit',
  templateUrl: './latest-news-edit.component.html',
  styleUrls: ['./latest-news-edit.component.scss'],
})
export class LatestNewsEditComponent implements OnInit {
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
    private latestNewsService: LatestNewsService,
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
      Date: [null],
      Image: [null],
      IsActive: [true],
    });

    /*this.activatedRoute.queryParamMap.subscribe((params) => {
      debugger
      this.id = Number(params.get('id'));
      this.getEdit(this.id);
    });*/

    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getEdit(this.id);
    }
  }

  getEdit(productId) {
    this.latestNewsService.getById(productId).subscribe((response) => {
      debugger
      this.editVM = response.data;
      var date = new Date(this.editVM.Date);
      var ngbDateStructGregorian = {
        day: date.getUTCDate() + 1,
        month: date.getUTCMonth() + 1,
        year: date.getUTCFullYear(),
      };
      this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      this.form.patchValue({
        Id: this.editVM.id,
        TitleAr: this.editVM.titleAr,
        TitleEn: this.editVM.titleEn,
        DescriptionAr: this.editVM.descriptionAr,
        DescriptionEn: this.editVM.descriptionEn,
        Date: this.startDatePicker.getSelectedDate(),
        IsActive: this.editVM.isActive,
      });

      this.oldImage = this.editVM.Image;
    });
  }

  onUpload(event: any) {
    this.form.get('Image').setValue(event.files[0]);
  }

  onRemove(event) {
    debugger;
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
      this.latestNewsService.update(postedVM).subscribe((response) => {
        if (response.isSuccess) {
          debugger;
          if (this.form.get('Image').value) {
            this.fileManagerService
              .deleteByEntityName(this.editVM.Id, 'LatestNews')
              .subscribe((res) => {
                this.fileManagerService
                  .upload(this.editVM.Id, 'LatestNews', '', [
                    this.form.get('Image').value,
                  ])
                  .subscribe((res) => {
                    this.globalService.messageAlert(
                      MessageType.Success,
                      '???? ?????????????? ??????????'
                    );
                    this.globalService.navigate(
                      '/admin/data-management/latest-news-list'
                    );
                  });
              });
          } else {
            this.globalService.navigate(
              '/admin/data-management/latest-news-list'
            );
          }
        }
      });
    }
  }
}
