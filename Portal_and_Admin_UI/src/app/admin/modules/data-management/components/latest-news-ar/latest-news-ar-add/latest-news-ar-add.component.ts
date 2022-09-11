import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateLatestNewsDto } from '@shared/proxy/latest-news/models';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';

@Component({
  selector: 'app-latest-news-ar-add',
  templateUrl: './latest-news-ar-add.component.html'
})
export class LatestNewsArAddComponent implements OnInit {
  createNewsform: FormGroup;
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
  @ViewChild('datePicker') startDatePicker: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;
  //#endregion
  createLatestNewsDto = {} as CreateLatestNewsDto;
  newsCategueries = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private latestNewsService: LatestNewsService,
    private fileManagerService: FileManagerService, private _dateFormatterService: DateFormatterService,
    private newsCategueryService: NewsCategueryService, private globalService: GlobalService) {
    this.date = _dateFormatterService.GetTodayHijri();
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة خبر عربي جديد');
    this.buildForm();
    this.newsCategueryService.getLookupList().subscribe((response) => {
      this.newsCategueries = response.data;
    });
  }

  buildForm() {
    this.createNewsform = this.formBuilder.group({
      title: [this.createLatestNewsDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsCategueryId: [this.createLatestNewsDto.newsCategueryId || '', [Validators.required]],
      content: [this.createLatestNewsDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsOrigin: [this.createLatestNewsDto.newsOrigin || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      date: [this.createLatestNewsDto.date || null],
      image: [this.createLatestNewsDto.image || null, Validators.required],
      isActive: [this.createLatestNewsDto.isActive || true, Validators.required],
      openComments: [this.createLatestNewsDto.openComments || false, Validators.required]
    });
  }
  onUpload(event: any) {
    this.createNewsform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.createNewsform.get('image').setValue(null);
  }
  onSelectGregorianDate() {
    let gregorianDate: Date = this.createNewsform.get('date').value as Date;
    let hijriDate = this.globalService.convertToHijri(gregorianDate, 'ar');
    this.createNewsform.get('HijriDate').setValue(hijriDate);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.startDatePicker.getSelectedDate();
    this.isValidDate = false;
    if (this.date == null) {
      this.isValidDate = true;
      return;
    }
    if (this.createNewsform.valid) {
      this.createLatestNewsDto = { ...this.createNewsform.value } as CreateLatestNewsDto;
      this.createLatestNewsDto.date = date;
      this.createLatestNewsDto.isArabic = true;
      this.latestNewsService.create(this.createLatestNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService.upload(id, 'LatestNews', '', [this.createNewsform.get('image').value]).subscribe(res => {
            this.globalService.navigate("/admin/data-management/latest-news-ar-list");
          })
        }
      });
    }
  }
}
