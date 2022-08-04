import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { DateType } from 'ngx-hijri-gregorian-datepicker';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { NewsService } from '@proxy/news/news.service';
import { CreateNewsDto } from '@proxy/news/models';

@Component({
  selector: 'app-emirates-news-add',
  templateUrl: './emirates-news-add.component.html'
})
export class EmiratesNewsAddComponent implements OnInit {
  createNewsform: FormGroup;
  isFormSubmitted: boolean;
  //#region for uploader
  @ViewChild('uploader',{static:true}) uploader;
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
  createNewsDto = {} as CreateNewsDto;

  constructor(private formBuilder: FormBuilder, private newsService: NewsService,
    private fileManagerService: FileManagerService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة خبر جديد');
    this.buildForm();
  }

  buildForm() {
    this.createNewsform = this.formBuilder.group({
      titleAr: [this.createNewsDto.titleAr || '', Validators.required],
      titleEn: [this.createNewsDto.titleEn || null],
      descriptionAr: [this.createNewsDto.descriptionAr || '', Validators.required],
      descriptionEn: [this.createNewsDto.descriptionEn || null],
      date: [this.createNewsDto.date || null],
      image: [this.createNewsDto.image || null, Validators.required],
      isActive: [this.createNewsDto.isActive || true, Validators.required],
      NewsTypeId : [NewsTypes.EmiratesNews]
    });
  }

  onUpload(event: any) {
    this.createNewsform.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createNewsform.get('image').setValue(null);
  }

  onSelectGregorianDate(){
    let gregorianDate: Date = this.createNewsform.get('date').value as Date;
    let hijriDate = this.globalService.convertToHijri(gregorianDate,'ar');
    this.createNewsform.get('HijriDate').setValue(hijriDate);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.startDatePicker.getSelectedDate();
    this.isValidDate = false;
    if(this.date == null){
      this.isValidDate = true;
      return;
    }
    if (this.createNewsform.valid) {
      this.createNewsDto = { ...this.createNewsform.value } as CreateNewsDto;
      this.createNewsDto.date = date;
      this.createNewsDto.newsType = NewsTypes.EmiratesNews;
      this.newsService.create(this.createNewsDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          let id = response.data.toString();
          this.fileManagerService.upload(id, 'News', '', [this.createNewsform.get('image').value]).subscribe(res =>{
            this.globalService.navigate("/admin/data-management/emirates-news-list");
          })
        }
      });
    }
  }
}
