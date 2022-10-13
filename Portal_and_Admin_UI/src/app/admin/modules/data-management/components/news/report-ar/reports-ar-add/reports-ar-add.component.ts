import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateNewsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { environment } from 'src/environments/environment';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-reports-ar-add',
  templateUrl: './reports-ar-add.component.html'
})
export class ReportsArAddComponent implements OnInit {
  createNewsform: FormGroup;
  isFormSubmitted: boolean;
  createNewsDto = {} as CreateNewsDto;

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
    private fileManagerService: FileManagerService, private _dateFormatterService: DateFormatterService,
    private globalService: GlobalService) {
    this.date = _dateFormatterService.GetTodayHijri();
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة تقرير اعلامي عربي جديد');
    this.buildForm();
  }

  buildForm() {
    this.createNewsform = this.formBuilder.group({
      title: [this.createNewsDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.createNewsDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      newsOrigin: [this.createNewsDto.newsOrigin || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      date: [this.createNewsDto.date || null],
      image: [this.createNewsDto.image || null, Validators.required],
      isActive: [this.createNewsDto.isActive || true, Validators.required]
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
      this.createNewsDto = { ...this.createNewsform.value } as CreateNewsDto;
      this.createNewsDto.date = date;
      this.createNewsDto.isArabic = true;
      this.createNewsDto.newsTypeId = NewsTypes.Reports;
      let imageContent = this.createNewsform.get('image').value;
      if (imageContent) {
        this.createNewsDto.imageName = imageContent.name;
      }
      this.newsService.create(this.createNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.News, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/reports-ar-list");
            });
          }
          else {
            this.globalService.navigate("/admin/data-management/reports-ar-list");
          }
        }
      });
    }
  }
}