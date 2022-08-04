import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataManagementRoutingModule } from './data-management-routing.module';
import { AddPosterComponent } from './components/poster/add-poster/add-poster.component';
import { EditPosterComponent } from './components/poster/edit-poster/edit-poster.component';
import { ListPosterComponent } from './components/poster/list-poster/list-poster.component';
import { EmiratesNewsAddComponent } from './components/emirates-news/emirates-news-add/emirates-news-add.component';
import { EmiratesNewsListComponent } from './components/emirates-news/emirates-news-list/emirates-news-list.component';
import { EmiratesNewsEditComponent } from './components/emirates-news/emirates-news-edit/emirates-news-edit.component';
import { EmiratesNewsViewComponent } from './components/emirates-news/emirates-news-view/emirates-news-view.component';
import { LatestNewsAddComponent } from './components/latest-news/latest-news-add/latest-news-add.component';
import { LatestNewsListComponent } from './components/latest-news/latest-news-list/latest-news-list.component';
import { LatestNewsEditComponent } from './components/latest-news/latest-news-edit/latest-news-edit.component';
import { LatestNewsViewComponent } from './components/latest-news/latest-news-view/latest-news-view.component';
import { ReportsAddComponent } from './components/reports/reports-add/reports-add.component';
import { ReportsEditComponent } from './components/reports/reports-edit/reports-edit.component';
import { ReportsListComponent } from './components/reports/reports-list/reports-list.component';
import { ReportsViewComponent } from './components/reports/reports-view/reports-view.component';
import { ServiceAddComponent } from './components/services/service-add/service-add.component';
import { ServiceEditComponent } from './components/services/service-edit/service-edit.component';
import { ServiceListComponent } from './components/services/service-list/service-list.component';
import { ServiceViewComponent } from './components/services/service-view/service-view.component';
import { RequestAttachmentTypeAddComponent } from './components/request-attachment-types/request-attachment-type-add/request-attachment-type-add.component';
import { RequestAttachmentTypeEditComponent } from './components/request-attachment-types/request-attachment-type-edit/request-attachment-type-edit.component';
import { RequestAttachmentTypeListComponent } from './components/request-attachment-types/request-attachment-type-list/request-attachment-type-list.component';
import { RequestAttachmentTypeViewComponent } from './components/request-attachment-types/request-attachment-type-view/request-attachment-type-view.component';
import { RequestTypeAddComponent } from './components/request-types/request-type-add/request-type-add.component';
import { RequestTypeEditComponent } from './components/request-types/request-type-edit/request-type-edit.component';
import { RequestTypeListComponent } from './components/request-types/request-type-list/request-type-list.component';
import { RequestTypeViewComponent } from './components/request-types/request-type-view/request-type-view.component';
import { CaseTypeAddComponent } from './components/case-type/case-type-add/case-type-add.component';
import { CaseTypeEditComponent } from './components/case-type/case-type-edit/case-type-edit.component';
import { CaseTypeListComponent } from './components/case-type/case-type-list/case-type-list.component';
import { CaseTypeViewComponent } from './components/case-type/case-type-view/case-type-view.component';
import { ServiceStageAddComponent } from './components/service-stages/service-stage-add/service-stage-add.component';
import { ServiceStageEditComponent } from './components/service-stages/service-stage-edit/service-stage-edit.component';
import { ServiceStageListComponent } from './components/service-stages/service-stage-list/service-stage-list.component';
import { ServiceStageViewComponent } from './components/service-stages/service-stage-view/service-stage-view.component';
import { SharedModule } from '@shared/shared.module';

@NgModule({
  declarations: [
    AddPosterComponent,
    EditPosterComponent,
    ListPosterComponent,
    EmiratesNewsAddComponent,
    EmiratesNewsListComponent,
    EmiratesNewsEditComponent,
    EmiratesNewsViewComponent,
    LatestNewsAddComponent,
    LatestNewsListComponent,
    LatestNewsEditComponent,
    LatestNewsViewComponent,
    ReportsAddComponent,
    ReportsEditComponent,
    ReportsListComponent,
    ReportsViewComponent,
    ServiceAddComponent,
    ServiceEditComponent,
    ServiceListComponent,
    ServiceViewComponent,
    RequestAttachmentTypeAddComponent,
    RequestAttachmentTypeEditComponent,
    RequestAttachmentTypeListComponent,
    RequestAttachmentTypeViewComponent,
    RequestTypeAddComponent,
    RequestTypeEditComponent,
    RequestTypeListComponent,
    RequestTypeViewComponent,
    CaseTypeAddComponent,
    CaseTypeEditComponent,
    CaseTypeListComponent,
    CaseTypeViewComponent,
    ServiceStageAddComponent,
    ServiceStageEditComponent,
    ServiceStageListComponent,
    ServiceStageViewComponent,
  ],
  imports: [CommonModule, DataManagementRoutingModule, SharedModule],
})
export class DataManagementModule {}
