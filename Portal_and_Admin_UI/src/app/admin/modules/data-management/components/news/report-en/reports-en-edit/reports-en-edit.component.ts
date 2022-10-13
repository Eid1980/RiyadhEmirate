import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateNewsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-reports-en-edit',
  templateUrl: './reports-en-edit.component.html'
})
export class ReportsEnEditComponent implements OnInit {
  updateNewsform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  updateNewsDto = {} as UpdateNewsDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.newsfileSize ? environment.newsfileSize : environment.fileSize;
  acceptType: string = environment.newsallowedExtensions ? environment.newsallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  //#region for datePicker
  @ViewChild('datePicker') startDatePicker: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;
  //#endregion

  constructor(private formBuilder: FormBuilder, private newsService: NewsService,
    private fileManagerService: FileManagerService, private dateFormatterService: DateFormatterService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل بيانات التقرير الاعلامي عربي');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate('/admin/data-management/reports-en-list');
    }
  }

  buildForm() {
    this.updateNewsform = this.formBuilder.group({
      title: [this.updateNewsDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.updateNewsDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsOrigin: [this.updateNewsDto.newsOrigin || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      date: [this.updateNewsDto.date || null],
      image: [null],
      isActive: [this.updateNewsDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.newsService.getById(this.id).subscribe((response) => {
      this.updateNewsDto = response.data as UpdateNewsDto;
      if (this.updateNewsDto.isArabic || this.updateNewsDto.newsTypeId != NewsTypes.Reports) {
        this.globalService.navigate("/admin/data-management/reports-en-list");
      }
      //#region Set Date
      let date = new Date(this.updateNewsDto.date);
      let ngbDateStructGregorian = {
        day: date.getUTCDate(),
        month: date.getUTCMonth() + 1,
        year: date.getUTCFullYear(),
      };
      this.date = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      //#endregion
      this.buildForm();
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
      this.updateNewsDto.date = date;
      this.updateNewsDto.isArabic = false;
      this.updateNewsDto.newsTypeId = NewsTypes.Reports;
      let imageContent = this.updateNewsform.get('image').value;
      if (imageContent) {
        this.updateNewsDto.imageName = imageContent.name;
      }
      this.newsService.update(this.updateNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.News, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate('/admin/data-management/reports-en-list');
            });
          }
          else {
            this.globalService.navigate('/admin/data-management/reports-en-list');
          }
        }
      });
    }
  }
}
