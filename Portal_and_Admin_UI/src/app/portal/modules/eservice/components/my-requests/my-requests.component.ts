import { Component, OnInit, ViewChild } from '@angular/core';
import { RequestService } from '@proxy/requests/request.service';
import { GlobalService } from '@shared/services/global.service';
import { LookupDto } from '@proxy/shared/lookup-dto.model';
import { ServiceService } from '@proxy/services/service.service';
import { GetMyRequestListDto, MyRequestSearchDto } from '@proxy/requests/models';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SearchField, SearchModel } from '@proxy/shared/search-model.model';
import { DateType } from 'ngx-hijri-gregorian-datepicker';
import { DynamicSearchService } from '@shared/proxy/shared/dynamic-search.service';
import { PagingMetaData } from '@shared/models/paging-meta-data.model';
import { PageListSetting } from '@shared/interfaces/page-list-setting';

@Component({
  selector: 'app-my-requests',
  templateUrl: './my-requests.component.html'
})
export class MyRequestsComponent implements OnInit {
  myRequestSearchForm: FormGroup;
  myRequestListDto = [] as GetMyRequestListDto[];
  myRequestSearchDto = {} as MyRequestSearchDto;
  searchModel = {} as SearchModel;
  services = [] as LookupDto<number>[];
  stages = [] as LookupDto<number>[];
  //#region for datePicker
  @ViewChild('datePickerFrom') dateFrom: any;
  @ViewChild('datePickerTo') dateTo: any;
  isValidDate = false;
  selectedDateType = DateType.Hijri;
  //#endregion

  pagingMetaData: PagingMetaData;
  PageListSetting: PageListSetting;

  constructor(private requestService: RequestService,
    private serviceService: ServiceService,
    private formBuilder: FormBuilder,
    public dynamicSearchService: DynamicSearchService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('طلباتي');
    this.buildForm();
    this.serviceService.getLookupList().subscribe((response) => {
      this.services = response.data;
    });
    this.serviceService.getStagesLookupList().subscribe((response) => {
      this.stages = response.data;
    });

    this.search(true);
  }

  buildForm() {
    this.myRequestSearchForm = this.formBuilder.group({
      serviceId: [this.myRequestSearchDto.serviceId],
      requestNumber: [this.myRequestSearchDto.requestNumber],
      stageId: [this.myRequestSearchDto.stageId]
    });
  }
  search(all?: boolean) {
    if (all) {
      this.myRequestSearchForm.reset();
      this.searchModel.SearchFields = [];
    }
    else {
      this.searchModel.SearchFields = this.getSearchField();
    }
    this.requestService.myRequests(this.searchModel).subscribe((response) => {
      this.myRequestListDto = response.data.gridItemsVM as GetMyRequestListDto[];
      this.pagingMetaData = response.data.pagingMetaData;
    });
  }

  getSearchField() {
    let fields = [] as SearchField[];
    this.myRequestSearchDto = { ...this.myRequestSearchForm.value } as MyRequestSearchDto;
    this.myRequestSearchDto.dateFrom = this.dateFrom.getSelectedDate();
    this.myRequestSearchDto.dateTo = this.dateTo.getSelectedDate();
    if (this.myRequestSearchDto.requestNumber) {
      fields.push({ FieldName: "RequestNumber", Operator: "Contain", Value: this.myRequestSearchDto.requestNumber } as SearchField);
    }
    if (this.myRequestSearchDto.serviceId) {
      fields.push({ FieldName: "ServiceId", Operator: "Equal", Value: this.myRequestSearchDto.serviceId.toString() } as SearchField);
    }
    if (this.myRequestSearchDto.stageId) {
      fields.push({ FieldName: "StageId", Operator: "Equal", Value: this.myRequestSearchDto.stageId.toString() } as SearchField);
    }
    if (this.myRequestSearchDto.dateFrom) {
      fields.push({ FieldName: "CreatedDate", Operator: "GreaterThanOrEqual", Value: this.myRequestSearchDto.dateFrom } as SearchField);
    }
    if (this.myRequestSearchDto.dateTo) {
      fields.push({ FieldName: "CreatedDate", Operator: "LessThanOrEqual", Value: this.myRequestSearchDto.dateTo } as SearchField);
    }
    return fields;
  }

  onTableLazyLoad(event: any) {
    this.dynamicSearchService.lazy(event, this.searchModel, () =>
      this.search()
    );
  }

}
