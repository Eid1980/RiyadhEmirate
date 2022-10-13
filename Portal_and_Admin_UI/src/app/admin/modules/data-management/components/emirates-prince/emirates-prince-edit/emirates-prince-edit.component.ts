import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { EmiratesPrinceService } from '@shared/proxy/emirates-princes/emirates-prince.service';
import { UpdateEmiratesPrinceDto } from '@shared/proxy/emirates-princes/models';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { FileManagerService } from '@shared/services/file-manager.service';
import { ActivatedRoute } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-emirates-prince-edit',
  templateUrl: './emirates-prince-edit.component.html'
})
export class EmiratesPrinceEditComponent implements OnInit {
  updateEmiratesPrinceForm: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  updateEmiratesPrinceDto = {} as UpdateEmiratesPrinceDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.princesfileSize ? environment.princesfileSize : environment.fileSize;
  acceptType: string = environment.princesallowedExtensions ? environment.princesallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  //#region for datePicker
  @ViewChild('fromDatePicker') fromDate: any;
  dateFrom: NgbDateStruct;
  @ViewChild('toDatePicker') toDate: any;
  dateTo: NgbDateStruct;
  isValidDate = false;
  selectedDateType = DateType.Hijri;
  //#endregion

  constructor(private formBuilder: FormBuilder, private emiratesPrinceService: EmiratesPrinceService,
    private fileManagerService: FileManagerService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute, private dateFormatterService: DateFormatterService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل بيانات أمير المنطقة');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate('/admin/data-management/emirates-prince-list');
    }
  }

  buildForm() {
    this.updateEmiratesPrinceForm = this.formBuilder.group({
      nameAr: [this.updateEmiratesPrinceDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateEmiratesPrinceDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      behalfToAr: [this.updateEmiratesPrinceDto.behalfToAr || ''],
      behalfToEn: [this.updateEmiratesPrinceDto.behalfToEn || ''],
      fromDate: [this.updateEmiratesPrinceDto.fromDate || null],
      toDate: [this.updateEmiratesPrinceDto.toDate || null],
      cv: [this.updateEmiratesPrinceDto.cv || ''],
      image: [null],
      isActive: [this.updateEmiratesPrinceDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.emiratesPrinceService.getById(this.id).subscribe((response) => {
      this.updateEmiratesPrinceDto = response.data as UpdateEmiratesPrinceDto;
      //#region Set FromDate
      let from_date = new Date(this.updateEmiratesPrinceDto.fromDate);
      let ngbDateStructGregorian = {
        day: from_date.getUTCDate(),
        month: from_date.getUTCMonth() + 1,
        year: from_date.getUTCFullYear(),
      };
      this.dateFrom = this.dateFormatterService.ToHijri(ngbDateStructGregorian);
      //#endregion
      //#region Set ToDate
      if (this.updateEmiratesPrinceDto.toDate) {
        let to_date = new Date(this.updateEmiratesPrinceDto.toDate);
        let ngbDateStructGregorian_to = {
          day: to_date.getUTCDate(),
          month: to_date.getUTCMonth() + 1,
          year: to_date.getUTCFullYear(),
        };
        this.dateTo = this.dateFormatterService.ToHijri(ngbDateStructGregorian_to);
      }
      //#endregion
      this.buildForm();
    });
  }
  onUpload(event: any) {
    this.updateEmiratesPrinceForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateEmiratesPrinceForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.fromDate.getSelectedDate();
    this.isValidDate = false;
    if (date == null) {
      this.isValidDate = true;
      return;
    }
    if (this.updateEmiratesPrinceForm.valid) {
      this.updateEmiratesPrinceDto = { ...this.updateEmiratesPrinceForm.value } as UpdateEmiratesPrinceDto;
      this.updateEmiratesPrinceDto.id = this.id;
      this.updateEmiratesPrinceDto.fromDate = date;
      if (this.toDate.getSelectedDate() != 'Invalid date') {
        this.updateEmiratesPrinceDto.toDate = this.toDate.getSelectedDate();
      }
      let imageContent = this.updateEmiratesPrinceForm.get('image').value;
      if (imageContent) {
        this.updateEmiratesPrinceDto.imageName = imageContent.name;
      }
      this.emiratesPrinceService.update(this.updateEmiratesPrinceDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Princes, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/emirates-prince-list");
            });
          }
          else {
            this.globalService.navigate('/admin/data-management/emirates-prince-list');
          }
        }
      });
    }
  }
}