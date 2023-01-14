import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { OpenDataRequestService } from '@shared/proxy/open-data-requests/open-data-request.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateOpenDataRequestDto } from '@shared/proxy/open-data-requests/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { OpenDataCategueryService } from '@shared/proxy/open-data-categueries/open-data-categuery.service';
import { OpenDataReportService } from '@shared/proxy/open-data-reports/open-data-report.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';

@Component({
  selector: 'app-open-data',
  templateUrl: './open-data.component.html'
})
export class OpenDataComponent implements OnInit {
  createOpenDataRequestform: FormGroup;
  isFormSubmitted: boolean;
  createOpenDataRequestDto = {} as CreateOpenDataRequestDto;

  openDataCategoryReport : any = {};

  constructor(private openDataRequestService: OpenDataRequestService, private openDataCategoryService: OpenDataCategueryService,
    private openDataReportService: OpenDataReportService, private fileManagerService: FileManagerService,
    private formBuilder: FormBuilder, private globalService: GlobalService){

  }

  ngOnInit(): void {
    this.globalService.setTitle('البيانات المفتوحة');
    this.buildForm();

    this.openDataCategoryService.getAllCategoryWithReports().subscribe(
      (response) => {
        if(response.isSuccess){
          this.openDataCategoryReport = response.data;
        }
      },
      () => {}
    )
  }

  buildForm() {
    this.createOpenDataRequestform = this.formBuilder.group({
      fullName: [this.createOpenDataRequestDto.fullName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.createOpenDataRequestDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace,Validators.email]],
      title: [this.createOpenDataRequestDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.createOpenDataRequestDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      recaptcha: ['' , Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createOpenDataRequestform.valid) {
      this.createOpenDataRequestDto = { ...this.createOpenDataRequestform.value } as CreateOpenDataRequestDto;
      this.createOpenDataRequestDto.isReplied = false;
      this.openDataRequestService.create(this.createOpenDataRequestDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.createOpenDataRequestform.reset();
          this.isFormSubmitted = false;
        }
      });
    }
  }

  paginate(event , openDataCategoryId: number) {
    console.log(event ,openDataCategoryId)

    let searchModel : SearchModel = {
      PageNumber : event.page + 1,
      PageSize: event.rows,
      SearchFields : [{
        FieldName:"OpenDataCategueryId",
        Operator: "Equal",
        Value: openDataCategoryId.toString()
      }]
    }

    this.getListPage(searchModel, openDataCategoryId);

  }

  getListPage(searchModel : SearchModel, openDataCategoryId: number){
    this.openDataReportService.getListPage(searchModel).subscribe(
      (response:any) => {
        if(response.isSuccess){
          this.openDataCategoryReport.forEach(element => {
            if(element.key.id == openDataCategoryId){
              element.pagingMetaData = response.data.pagingMetaData
              element.dataReports = response.data.gridItemsVM
            }
          });
        }
      },
      (error) => {}
    )
  }

  downloadAttachment(id: string) {
    if (id) {
      this.fileManagerService.getByEntityIdEntityName(id, 'OpenData').subscribe((response) => {
        if (response.id) {
          this.fileManagerService.getById(response.id).subscribe((response) => {
            if (response) {
              this.fileManagerService.downloadAttachment(response.base64File, response.fileName);
            }
            else {
              this.globalService.messageAlert(MessageType.Error, 'فشل في تنزيل المرفق');
            }
          });
        }
      });
    }
  }
}
