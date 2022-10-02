import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateLatestNewsDto } from '@shared/proxy/latest-news/models';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';
import { ActivatedRoute } from '@angular/router';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-latest-news-en-edit',
  templateUrl: './latest-news-en-edit.component.html'
})
export class LatestNewsEnEditComponent implements OnInit {
  updateNewsform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  oldImage: any;
  updateLatestNewsDto = {} as UpdateLatestNewsDto;
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
  newsCategueries = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private latestNewsService: LatestNewsService,
    private fileManagerService: FileManagerService, private dateFormatterService: DateFormatterService,
    private newsCategueryService: NewsCategueryService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute, public sanitizer: DomSanitizer) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل بيانات الخبر انجليزي');
    this.buildForm();
    this.newsCategueryService.getLookupList().subscribe((response) => {
      this.newsCategueries = response.data;
    });
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/latest-news-en-list');
    }
  }

  buildForm() {
    this.updateNewsform = this.formBuilder.group({
      title: [this.updateLatestNewsDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsCategueryId: [this.updateLatestNewsDto.newsCategueryId || '', [Validators.required]],
      content: [this.updateLatestNewsDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsOrigin: [this.updateLatestNewsDto.newsOrigin || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      date: [null],
      image: [null],
      isActive: [this.updateLatestNewsDto.isActive, Validators.required],
      openComments: [this.updateLatestNewsDto.openComments, Validators.required]
    });
  }

  getDetails() {
    this.latestNewsService.getById(this.id).subscribe((response) => {
      this.updateLatestNewsDto = response.data as UpdateLatestNewsDto;
      if (this.updateLatestNewsDto.isArabic) {
        this.globalService.navigate("/admin/data-management/latest-news-en-list");
      }
      let date = new Date(this.updateLatestNewsDto.date);
      let ngbDateStructGregorian = {
        day: date.getUTCDate(),
        month: date.getUTCMonth() + 1,
        year: date.getUTCFullYear(),
      };
      this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
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
      this.updateLatestNewsDto = { ...this.updateNewsform.value } as UpdateLatestNewsDto;
      this.updateLatestNewsDto.id = this.id;
      this.updateLatestNewsDto.date = date;
      this.updateLatestNewsDto.isArabic = false;

      this.latestNewsService.update(this.updateLatestNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (this.updateNewsform.get('image').value) {
            this.fileManagerService.deleteByEntityName(this.id, 'LatestNews').subscribe((res) => {
              this.fileManagerService.upload(this.id.toString(), 'LatestNews', '', [this.updateNewsform.get('image').value]).subscribe((res) => {
                this.globalService.navigate('/admin/data-management/latest-news-en-list');
              });
            });
          }
          else {
            this.globalService.navigate(
              '/admin/data-management/latest-news-en-list'
            );
          }
        }
      });
    }
  }
}
