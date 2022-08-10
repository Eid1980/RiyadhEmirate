import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { UpdateNewsDto } from '@proxy/news/models';
import { NewsService } from '@proxy/news/news.service';
import { NewsTypes } from '@shared/enums/news-types.enum';

@Component({
  selector: 'app-emirates-news-edit',
  templateUrl: './emirates-news-edit.component.html',
})
export class EmiratesNewsEditComponent implements OnInit {
  updateNewsform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  oldImage: any;
  updateNewsDto = {} as UpdateNewsDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = 1000000;
  acceptType: 'image/*';
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion
  //#region for datePicker
  @ViewChild('datePicker') startDatePicker: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;
  //#endregion

  constructor(
    private formBuilder: FormBuilder,
    private newsService: NewsService,
    private fileManagerService: FileManagerService,
    private globalService: GlobalService,
    private activatedRoute: ActivatedRoute,
    private dateFormatterService: DateFormatterService
  ) {}

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل الخبر');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/emirates-news-list');
    }
  }

  buildForm() {
    this.updateNewsform = this.formBuilder.group({
      titleAr: [this.updateNewsDto.titleAr || '', Validators.required],
      titleEn: [this.updateNewsDto.titleEn || null],
      descriptionAr: [
        this.updateNewsDto.descriptionAr || '',
        Validators.required,
      ],
      descriptionEn: [this.updateNewsDto.descriptionEn || null],
      date: [null],
      image: [null],
      isActive: [this.updateNewsDto.isActive, Validators.required],
    });
  }
  getDetails() {
    this.newsService.getById(this.id).subscribe((response) => {
      this.updateNewsDto = response.data as UpdateNewsDto;
      let date = new Date(this.updateNewsDto.date);
      let ngbDateStructGregorian = {
        day: date.getUTCDate() + 1,
        month: date.getUTCMonth() + 1,
        year: date.getUTCFullYear(),
      };
      this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      //this.updateNewsDto.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      this.buildForm();
      this.oldImage = response.data.image;
    });
  }
  onUpload(event: any) {
    this.updateNewsform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateNewsform.get('image').setValue(null);
  }
  onSelectGregorianDate() {
    let gregorianDate: Date = this.updateNewsform.get('date').value as Date;
    let hijriDate = this.globalService.convertToHijri(gregorianDate, 'ar');
    this.updateNewsform.get('HijriDate').setValue(hijriDate);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.startDatePicker.getSelectedDate();
    this.isValidDate = false;
    if (this.date == null) {
      this.isValidDate = true;
      return;
    }
    if (this.updateNewsform.valid) {
      this.updateNewsDto = { ...this.updateNewsform.value } as UpdateNewsDto;
      this.updateNewsDto.id = this.id;
      this.updateNewsDto.newsTypeId = NewsTypes.EmiratesNews;
      this.updateNewsDto.date = date;

      this.newsService.update(this.updateNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          console.log(this.updateNewsform.get('image').value);
          if (this.updateNewsform.get('image').value) {
            this.fileManagerService
              .deleteByEntityName(this.id, 'News')
              .subscribe((res) => {
                this.fileManagerService
                  .upload(this.id.toString(), 'News', '', [
                    this.updateNewsform.get('image').value,
                  ])
                  .subscribe((res) => {
                    this.globalService.navigate(
                      '/admin/data-management/emirates-news-list'
                    );
                  });
              });
          } else {
            this.globalService.navigate(
              '/admin/data-management/emirates-news-list'
            );
          }
        }
      });
    }
  }
}
