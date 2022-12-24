import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataManagementRoutingModule } from './data-management-routing.module';
import { AddPosterComponent } from './components/poster/add-poster/add-poster.component';
import { EditPosterComponent } from './components/poster/edit-poster/edit-poster.component';
import { ListPosterComponent } from './components/poster/list-poster/list-poster.component';
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
import { LatestNewsArAddComponent } from './components/news/latest-news-ar/latest-news-ar-add/latest-news-ar-add.component';
import { LatestNewsArEditComponent } from './components/news/latest-news-ar/latest-news-ar-edit/latest-news-ar-edit.component';
import { LatestNewsArListComponent } from './components/news/latest-news-ar/latest-news-ar-list/latest-news-ar-list.component';
import { LatestNewsArViewComponent } from './components/news/latest-news-ar/latest-news-ar-view/latest-news-ar-view.component';
import { LatestNewsEnViewComponent } from './components/news/latest-news-en/latest-news-en-view/latest-news-en-view.component';
import { LatestNewsEnAddComponent } from './components/news/latest-news-en/latest-news-en-add/latest-news-en-add.component';
import { LatestNewsEnListComponent } from './components/news/latest-news-en/latest-news-en-list/latest-news-en-list.component';
import { LatestNewsEnEditComponent } from './components/news/latest-news-en/latest-news-en-edit/latest-news-en-edit.component';
import { LatestNewsArCommentsComponent } from './components/news/latest-news-ar/latest-news-ar-comments/latest-news-ar-comments.component';
import { LatestNewsEnCommentsComponent } from './components/news/latest-news-en/latest-news-en-comments/latest-news-en-comments.component';
import { AddAboutUsComponent } from './components/about-us/add-about-us/add-about-us.component';
import { EditAboutUsComponent } from './components/about-us/edit-about-us/edit-about-us.component';
import { EditWomanSectionComponent } from './components/woman-section/edit-woman-section/edit-woman-section.component';
import { GovernorateAddComponent } from './components/governorates/governorate-add/governorate-add.component';
import { GovernorateListComponent } from './components/governorates/governorate-list/governorate-list.component';
import { GovernorateEditComponent } from './components/governorates/governorate-edit/governorate-edit.component';
import { GovernorateViewComponent } from './components/governorates/governorate-view/governorate-view.component';
import { EmiratesPrinceListComponent } from './components/emirates-prince/emirates-prince-list/emirates-prince-list.component';
import { EmiratesPrinceAddComponent } from './components/emirates-prince/emirates-prince-add/emirates-prince-add.component';
import { EmiratesPrinceEditComponent } from './components/emirates-prince/emirates-prince-edit/emirates-prince-edit.component';
import { EmiratesPrinceViewComponent } from './components/emirates-prince/emirates-prince-view/emirates-prince-view.component';
import { GovernorateNewsArAddComponent } from './components/news/governorate-news-ar/governorate-news-ar-add/governorate-news-ar-add.component';
import { GovernorateNewsArEditComponent } from './components/news/governorate-news-ar/governorate-news-ar-edit/governorate-news-ar-edit.component';
import { GovernorateNewsArListComponent } from './components/news/governorate-news-ar/governorate-news-ar-list/governorate-news-ar-list.component';
import { GovernorateNewsArViewComponent } from './components/news/governorate-news-ar/governorate-news-ar-view/governorate-news-ar-view.component';
import { GovernorateNewsEnViewComponent } from './components/news/governorate-news-en/governorate-news-en-view/governorate-news-en-view.component';
import { GovernorateNewsEnListComponent } from './components/news/governorate-news-en/governorate-news-en-list/governorate-news-en-list.component';
import { GovernorateNewsEnEditComponent } from './components/news/governorate-news-en/governorate-news-en-edit/governorate-news-en-edit.component';
import { GovernorateNewsEnAddComponent } from './components/news/governorate-news-en/governorate-news-en-add/governorate-news-en-add.component';
import { ReportsArAddComponent } from './components/news/report-ar/reports-ar-add/reports-ar-add.component';
import { ReportsArEditComponent } from './components/news/report-ar/reports-ar-edit/reports-ar-edit.component';
import { ReportsArListComponent } from './components/news/report-ar/reports-ar-list/reports-ar-list.component';
import { ReportsArViewComponent } from './components/news/report-ar/reports-ar-view/reports-ar-view.component';
import { ReportsEnViewComponent } from './components/news/report-en/reports-en-view/reports-en-view.component';
import { ReportsEnListComponent } from './components/news/report-en/reports-en-list/reports-en-list.component';
import { ReportsEnEditComponent } from './components/news/report-en/reports-en-edit/reports-en-edit.component';
import { ReportsEnAddComponent } from './components/news/report-en/reports-en-add/reports-en-add.component';
import { AuctionAddComponent } from './components/auction/auction-add/auction-add.component';
import { AuctionEditComponent } from './components/auction/auction-edit/auction-edit.component';
import { AuctionListComponent } from './components/auction/auction-list/auction-list.component';
import { AuctionViewComponent } from './components/auction/auction-view/auction-view.component';
import { OpenDataReportAddComponent } from './components/open-data-report/open-data-report-add/open-data-report-add.component';
import { OpenDataReportEditComponent } from './components/open-data-report/open-data-report-edit/open-data-report-edit.component';
import { OpenDataReportListComponent } from './components/open-data-report/open-data-report-list/open-data-report-list.component';
import { OpenDataReportViewComponent } from './components/open-data-report/open-data-report-view/open-data-report-view.component';
import { OpenDataCategueryAddComponent } from './components/open-data-categuery/open-data-categuery-add/open-data-categuery-add.component';
import { OpenDataCategueryEditComponent } from './components/open-data-categuery/open-data-categuery-edit/open-data-categuery-edit.component';
import { OpenDataCategueryListComponent } from './components/open-data-categuery/open-data-categuery-list/open-data-categuery-list.component';
import { OpenDataCategueryViewComponent } from './components/open-data-categuery/open-data-categuery-view/open-data-categuery-view.component';
import { PrisonAddComponent } from './components/prison/prison-add/prison-add.component';
import { PrisonEditComponent } from './components/prison/prison-edit/prison-edit.component';
import { PrisonListComponent } from './components/prison/prison-list/prison-list.component';
import { PrisonViewComponent } from './components/prison/prison-view/prison-view.component';
import { NationalityListComponent } from './components/nationality/nationality-list/nationality-list.component';
import { NationalityAddComponent } from './components/nationality/nationality-add/nationality-add.component';
import { NationalityEditComponent } from './components/nationality/nationality-edit/nationality-edit.component';
import { NationalityViewComponent } from './components/nationality/nationality-view/nationality-view.component';
import { ServieNotificationEmailAddComponent } from './components/servie-notification/email/servie-notification-email-add/servie-notification-email-add.component';
import { ServieNotificationEmailEditComponent } from './components/servie-notification/email/servie-notification-email-edit/servie-notification-email-edit.component';
import { ServieNotificationEmailListComponent } from './components/servie-notification/email/servie-notification-email-list/servie-notification-email-list.component';
import { ServieNotificationEmailViewComponent } from './components/servie-notification/email/servie-notification-email-view/servie-notification-email-view.component';
import { ServieNotificationSmsAddComponent } from './components/servie-notification/sms/servie-notification-sms-add/servie-notification-sms-add.component';
import { ServieNotificationSmsEditComponent } from './components/servie-notification/sms/servie-notification-sms-edit/servie-notification-sms-edit.component';
import { ServieNotificationSmsViewComponent } from './components/servie-notification/sms/servie-notification-sms-view/servie-notification-sms-view.component';
import { ServieNotificationSmsListComponent } from './components/servie-notification/sms/servie-notification-sms-list/servie-notification-sms-list.component';

@NgModule({
  declarations: [
    AddPosterComponent,
    EditPosterComponent,
    ListPosterComponent,
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
    GovernorateAddComponent,
    GovernorateListComponent,
    GovernorateEditComponent,
    GovernorateViewComponent,
    EmiratesPrinceListComponent,
    EmiratesPrinceAddComponent,
    EmiratesPrinceEditComponent,
    EmiratesPrinceViewComponent,
    GovernorateNewsArAddComponent,
    GovernorateNewsArEditComponent,
    GovernorateNewsArListComponent,
    GovernorateNewsArViewComponent,
    GovernorateNewsEnViewComponent,
    GovernorateNewsEnListComponent,
    GovernorateNewsEnEditComponent,
    GovernorateNewsEnAddComponent,
    ReportsArAddComponent,
    ReportsArEditComponent,
    ReportsArListComponent,
    ReportsArViewComponent,
    ReportsEnViewComponent,
    ReportsEnListComponent,
    ReportsEnEditComponent,
    ReportsEnAddComponent,
    AuctionAddComponent,
    AuctionEditComponent,
    AuctionListComponent,
    AuctionViewComponent,
    OpenDataReportAddComponent,
    OpenDataReportEditComponent,
    OpenDataReportListComponent,
    OpenDataReportViewComponent,
    OpenDataCategueryAddComponent,
    OpenDataCategueryEditComponent,
    OpenDataCategueryListComponent,
    OpenDataCategueryViewComponent,
    PrisonAddComponent,
    PrisonEditComponent,
    PrisonListComponent,
    PrisonViewComponent,
    NationalityListComponent,
    NationalityAddComponent,
    NationalityEditComponent,
    NationalityViewComponent,
    ServieNotificationEmailAddComponent,
    ServieNotificationEmailEditComponent,
    ServieNotificationEmailListComponent,
    ServieNotificationEmailViewComponent,
    ServieNotificationSmsAddComponent,
    ServieNotificationSmsEditComponent,
    ServieNotificationSmsViewComponent,
    ServieNotificationSmsListComponent,
  ],
  imports: [StepsModule, CommonModule, DataManagementRoutingModule, SharedModule],
})
export class DataManagementModule {}
