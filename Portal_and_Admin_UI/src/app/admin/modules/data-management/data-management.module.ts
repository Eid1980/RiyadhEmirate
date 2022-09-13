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
import { StepsModule } from 'primeng/steps';
import { ViewPosterComponent } from './components/poster/view-poster/view-poster.component';
import { ServiceAudienceComponent } from './components/services/service-audience/service-audience.component';
import { ServiceConditionComponent } from './components/services/service-condition/service-condition.component';
import { NewsCategueryAddComponent } from './components/news-categueries/news-categuery-add/news-categuery-add.component';
import { NewsCategueryEditComponent } from './components/news-categueries/news-categuery-edit/news-categuery-edit.component';
import { NewsCategueryListComponent } from './components/news-categueries/news-categuery-list/news-categuery-list.component';
import { NewsCategueryViewComponent } from './components/news-categueries/news-categuery-view/news-categuery-view.component';
import { LatestNewsArAddComponent } from './components/latest-news-ar/latest-news-ar-add/latest-news-ar-add.component';
import { LatestNewsArEditComponent } from './components/latest-news-ar/latest-news-ar-edit/latest-news-ar-edit.component';
import { LatestNewsArListComponent } from './components/latest-news-ar/latest-news-ar-list/latest-news-ar-list.component';
import { LatestNewsArViewComponent } from './components/latest-news-ar/latest-news-ar-view/latest-news-ar-view.component';
import { LatestNewsEnViewComponent } from './components/latest-news-en/latest-news-en-view/latest-news-en-view.component';
import { LatestNewsEnAddComponent } from './components/latest-news-en/latest-news-en-add/latest-news-en-add.component';
import { LatestNewsEnListComponent } from './components/latest-news-en/latest-news-en-list/latest-news-en-list.component';
import { LatestNewsEnEditComponent } from './components/latest-news-en/latest-news-en-edit/latest-news-en-edit.component';
import { AddAboutUsComponent } from './components/about-us/add-about-us/add-about-us.component';
import { EditAboutUsComponent } from './components/about-us/edit-about-us/edit-about-us.component';
import { LatestNewsArCommentsComponent } from './components/latest-news-ar/latest-news-ar-comments/latest-news-ar-comments.component';
import { LatestNewsEnCommentsComponent } from './components/latest-news-en/latest-news-en-comments/latest-news-en-comments.component';
import { EditWomanSectionComponent } from './components/woman-section/edit-woman-section/edit-woman-section.component';

@NgModule({
  declarations: [
    AddPosterComponent,
    EditPosterComponent,
    ListPosterComponent,
    EmiratesNewsAddComponent,
    EmiratesNewsListComponent,
    EmiratesNewsEditComponent,
    EmiratesNewsViewComponent,
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
    ViewPosterComponent,
    ServiceAudienceComponent,
    ServiceConditionComponent,
    NewsCategueryAddComponent,
    NewsCategueryEditComponent,
    NewsCategueryListComponent,
    NewsCategueryViewComponent,
    LatestNewsArAddComponent,
    LatestNewsArEditComponent,
    LatestNewsArListComponent,
    LatestNewsArViewComponent,
    LatestNewsEnViewComponent,
    LatestNewsEnAddComponent,
    LatestNewsEnListComponent,
    LatestNewsEnEditComponent,
    AddAboutUsComponent,
    EditAboutUsComponent,
    LatestNewsArCommentsComponent,
    LatestNewsEnCommentsComponent,
    EditWomanSectionComponent,
  ],
  imports: [StepsModule, CommonModule, DataManagementRoutingModule, SharedModule],
})
export class DataManagementModule {}
