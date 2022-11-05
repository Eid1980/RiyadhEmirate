import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { EmiratesPrinceService } from '@shared/proxy/emirates-princes/emirates-prince.service';
import { CreateEmiratesPrinceDto } from '@shared/proxy/emirates-princes/models';
import { DateType } from 'ngx-hijri-gregorian-datepicker';
import { FileManagerService } from '@shared/services/file-manager.service';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { environment } from 'src/environments/environment';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-emirates-prince-add',
  templateUrl: './emirates-prince-add.component.html'
})
export class EmiratesPrinceAddComponent implements OnInit {
  createEmiratesPrinceForm: FormGroup;
  isFormSubmitted: boolean;
  createEmiratesPrinceDto = {} as CreateEmiratesPrinceDto;

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
  @ViewChild('toDatePicker') toDate: any;
  isValidDate = false;
  isGreaterValidDate = false;
  selectedDateType = DateType.Hijri;
  minGreg: NgbDateStruct;
  minHigriDate: NgbDateStruct;
  //#endregion

  constructor(private formBuilder: FormBuilder, private emiratesPrinceService: EmiratesPrinceService,
    private fileManagerService: FileManagerService, private globalService: GlobalService)
  {
    this.minHigriDate = {
      day: 1,
      month: 1,
      year: 1360,
    };
    this.minGreg = { day: 1, month: 1, year: 1940 };
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة أمير منطقة جديد');
    this.buildForm();
  }

  buildForm() {
    this.createEmiratesPrinceForm = this.formBuilder.group({
      nameAr: [this.createEmiratesPrinceDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createEmiratesPrinceDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      behalfToAr: [this.createEmiratesPrinceDto.behalfToAr || ''],
      behalfToEn: [this.createEmiratesPrinceDto.behalfToEn || ''],
      fromDate: [this.createEmiratesPrinceDto.fromDate || null],
      toDate: [this.createEmiratesPrinceDto.toDate || null],
      cv: [this.createEmiratesPrinceDto.cv || ''],
      image: [this.createEmiratesPrinceDto.image || null],
      isActive: [this.createEmiratesPrinceDto.isActive || true, Validators.required]
    });
  }

  onUpload(event: any) {
    this.createEmiratesPrinceForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.createEmiratesPrinceForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    let date = this.fromDate.getSelectedDate();
    this.isValidDate = false;
    if (date == null || date == 'Invalid date') {
      this.isValidDate = true;
      return;
    }
    let toDate = this.toDate.getSelectedDate();
    if (toDate != null && toDate != 'Invalid date') {
      if (date > toDate) {
        this.isGreaterValidDate = true;
        return;
      }
      else {
        this.isGreaterValidDate = false;
      }
    }
    if (this.createEmiratesPrinceForm.valid) {
      this.createEmiratesPrinceDto = { ...this.createEmiratesPrinceForm.value } as CreateEmiratesPrinceDto;
      this.createEmiratesPrinceDto.fromDate = date;
      if (this.toDate.getSelectedDate() != 'Invalid date') {
        this.createEmiratesPrinceDto.toDate = toDate;
      }
      let imageContent = this.createEmiratesPrinceForm.get('image').value;
      if (imageContent) {
        this.createEmiratesPrinceDto.imageName = imageContent.name;
      }
      this.emiratesPrinceService.create(this.createEmiratesPrinceDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Princes, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/emirates-prince-list");
            });
          }
          else {
            this.globalService.navigate("/admin/data-management/emirates-prince-list");
          }
        }
      });
    }
  }
}
