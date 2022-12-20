import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { RequestService } from '@proxy/requests/request.service';
import { ServiceService } from '@proxy/services/service.service';
import { SearchField, SearchModel } from '@proxy/shared/search-model.model';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { GetInboxListDto, InboxSearchDto } from '@proxy/requests/models';
import { DateType } from 'ngx-hijri-gregorian-datepicker';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-inbox-shamel',
  templateUrl: './inbox-shamel.component.html'
})
export class InboxShamelComponent implements OnInit {
  inboxSearchForm: FormGroup;
  inboxListDto = [] as GetInboxListDto[];
  inboxSearchDto = {} as InboxSearchDto;
  searchModel = {} as SearchModel;
  services = [] as LookupDto<number>[];
  //#region for datePicker
  @ViewChild('datePickerFrom') dateFrom: any;
  @ViewChild('datePickerTo') dateTo: any;
  isValidDate = false;
  selectedDateType = DateType.Hijri;
  minGreg: NgbDateStruct;
  minHigriDate: NgbDateStruct;
  //#endregion

  constructor(private requestService: RequestService, private serviceService: ServiceService,
    private formBuilder: FormBuilder, private globalService: GlobalService) {
    this.minGreg = { day: 1, month: 1, year: 1940 };
    this.minHigriDate = { day: 1, month: 1, year: 1360 };
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('متابعة طلبات نظام شامل');
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });

    this.search(true);
  }

  buildForm() {
    this.inboxSearchForm = this.formBuilder.group({
      serviceId: [this.inboxSearchDto.serviceId],
      requestNumber: [this.inboxSearchDto.requestNumber],
      dateFrom: [this.inboxSearchDto.dateFrom || null],
      dateTo: [this.inboxSearchDto.dateTo || null],
      nationalId: [this.inboxSearchDto.nationalId]
    });
  }

  search(all?: boolean) {
    if (all) {
      this.inboxSearchForm.reset();
      this.searchModel.SearchFields = [];
    }
    else {
      this.searchModel.SearchFields = this.getSearchField();
    }
    this.requestService.inboxShamel(this.searchModel).subscribe((response) => {
      this.inboxListDto = response.data.gridItemsVM as GetInboxListDto[];
    });
  }

  getSearchField() {
    let fields = [] as SearchField[];
    this.inboxSearchDto = { ...this.inboxSearchForm.value } as InboxSearchDto;
    this.inboxSearchDto.dateFrom = this.dateFrom.getSelectedDate();
    this.inboxSearchDto.dateTo = this.dateTo.getSelectedDate();
    if (this.inboxSearchDto.requestNumber) {
      fields.push({ FieldName: "RequestNumber", Operator: "Contain", Value: this.inboxSearchDto.requestNumber } as SearchField);
    }
    if (this.inboxSearchDto.nationalId) {
      fields.push({ FieldName: "NationalId", Operator: "Contain", Value: this.inboxSearchDto.nationalId } as SearchField);
    }
    if (this.inboxSearchDto.serviceId) {
      fields.push({ FieldName: "ServiceId", Operator: "Equal", Value: this.inboxSearchDto.serviceId.toString() } as SearchField);
    }
    if (this.inboxSearchDto.dateFrom) {
      fields.push({ FieldName: "CreatedDate", Operator: "GreaterThanOrEqual", Value: this.inboxSearchDto.dateFrom } as SearchField);
    }
    if (this.inboxSearchDto.dateTo) {
      fields.push({ FieldName: "CreatedDate", Operator: "LessThanOrEqual", Value: this.inboxSearchDto.dateTo } as SearchField);
    }
    return fields;
  }
}
