import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { ListPosterComponent } from "./components/poster/list-poster/list-poster.component";
import { AddPosterComponent } from "./components/poster/add-poster/add-poster.component";
import { EditPosterComponent } from "./components/poster/edit-poster/edit-poster.component";
import { ServiceViewComponent } from "./components/services/service-view/service-view.component";
import { ServiceEditComponent } from "./components/services/service-edit/service-edit.component";
import { ServiceAddComponent } from "./components/services/service-add/service-add.component";
import { ServiceListComponent } from "./components/services/service-list/service-list.component";
import { RequestAttachmentTypeAddComponent } from "./components/request-attachment-types/request-attachment-type-add/request-attachment-type-add.component";
import { RequestAttachmentTypeEditComponent } from "./components/request-attachment-types/request-attachment-type-edit/request-attachment-type-edit.component";
import { RequestAttachmentTypeListComponent } from "./components/request-attachment-types/request-attachment-type-list/request-attachment-type-list.component";
import { RequestAttachmentTypeViewComponent } from "./components/request-attachment-types/request-attachment-type-view/request-attachment-type-view.component";
import { RequestTypeAddComponent } from "./components/request-types/request-type-add/request-type-add.component";
import { RequestTypeEditComponent } from "./components/request-types/request-type-edit/request-type-edit.component";
import { RequestTypeListComponent } from "./components/request-types/request-type-list/request-type-list.component";
import { RequestTypeViewComponent } from "./components/request-types/request-type-view/request-type-view.component";
import { CaseTypeAddComponent } from "./components/case-type/case-type-add/case-type-add.component";
import { CaseTypeEditComponent } from "./components/case-type/case-type-edit/case-type-edit.component";
import { CaseTypeListComponent } from "./components/case-type/case-type-list/case-type-list.component";
import { CaseTypeViewComponent } from "./components/case-type/case-type-view/case-type-view.component";
import { ServiceStageAddComponent } from "./components/service-stages/service-stage-add/service-stage-add.component";
import { ServiceStageEditComponent } from "./components/service-stages/service-stage-edit/service-stage-edit.component";
import { ServiceStageListComponent } from "./components/service-stages/service-stage-list/service-stage-list.component";
import { ServiceStageViewComponent } from "./components/service-stages/service-stage-view/service-stage-view.component";
import { ViewPosterComponent } from "./components/poster/view-poster/view-poster.component";
import { ServiceConditionComponent } from "./components/services/service-condition/service-condition.component";
import { ServiceAudienceComponent } from "./components/services/service-audience/service-audience.component";
import { NewsCategueryAddComponent } from "./components/news-categueries/news-categuery-add/news-categuery-add.component";
import { NewsCategueryEditComponent } from "./components/news-categueries/news-categuery-edit/news-categuery-edit.component";
import { NewsCategueryListComponent } from "./components/news-categueries/news-categuery-list/news-categuery-list.component";
import { NewsCategueryViewComponent } from "./components/news-categueries/news-categuery-view/news-categuery-view.component";
import { LatestNewsArListComponent } from "./components/news/latest-news-ar/latest-news-ar-list/latest-news-ar-list.component";
import { LatestNewsArAddComponent } from "./components/news/latest-news-ar/latest-news-ar-add/latest-news-ar-add.component";
import { LatestNewsArEditComponent } from "./components/news/latest-news-ar/latest-news-ar-edit/latest-news-ar-edit.component";
import { LatestNewsArViewComponent } from "./components/news/latest-news-ar/latest-news-ar-view/latest-news-ar-view.component";
import { LatestNewsEnEditComponent } from "./components/news/latest-news-en/latest-news-en-edit/latest-news-en-edit.component";
import { LatestNewsEnListComponent } from "./components/news/latest-news-en/latest-news-en-list/latest-news-en-list.component";
import { LatestNewsEnAddComponent } from "./components/news/latest-news-en/latest-news-en-add/latest-news-en-add.component";
import { LatestNewsEnViewComponent } from "./components/news/latest-news-en/latest-news-en-view/latest-news-en-view.component";
import { LatestNewsEnCommentsComponent } from "./components/news/latest-news-en/latest-news-en-comments/latest-news-en-comments.component";
import { LatestNewsArCommentsComponent } from "./components/news/latest-news-ar/latest-news-ar-comments/latest-news-ar-comments.component";
import { EditAboutUsComponent } from "./components/about-us/edit-about-us/edit-about-us.component";
import { EditWomanSectionComponent } from "./components/woman-section/edit-woman-section/edit-woman-section.component";
import { GovernorateAddComponent } from "./components/governorates/governorate-add/governorate-add.component";
import { GovernorateEditComponent } from "./components/governorates/governorate-edit/governorate-edit.component";
import { GovernorateListComponent } from "./components/governorates/governorate-list/governorate-list.component";
import { GovernorateViewComponent } from "./components/governorates/governorate-view/governorate-view.component";
import { Role } from "@shared/enums/role.enum";
import { EmiratesPrinceViewComponent } from "./components/emirates-prince/emirates-prince-view/emirates-prince-view.component";
import { EmiratesPrinceListComponent } from "./components/emirates-prince/emirates-prince-list/emirates-prince-list.component";
import { EmiratesPrinceEditComponent } from "./components/emirates-prince/emirates-prince-edit/emirates-prince-edit.component";
import { EmiratesPrinceAddComponent } from "./components/emirates-prince/emirates-prince-add/emirates-prince-add.component";
import { GovernorateNewsArListComponent } from "./components/news/governorate-news-ar/governorate-news-ar-list/governorate-news-ar-list.component";
import { GovernorateNewsArAddComponent } from "./components/news/governorate-news-ar/governorate-news-ar-add/governorate-news-ar-add.component";
import { GovernorateNewsArEditComponent } from "./components/news/governorate-news-ar/governorate-news-ar-edit/governorate-news-ar-edit.component";
import { GovernorateNewsArViewComponent } from "./components/news/governorate-news-ar/governorate-news-ar-view/governorate-news-ar-view.component";
import { GovernorateNewsEnListComponent } from "./components/news/governorate-news-en/governorate-news-en-list/governorate-news-en-list.component";
import { GovernorateNewsEnAddComponent } from "./components/news/governorate-news-en/governorate-news-en-add/governorate-news-en-add.component";
import { GovernorateNewsEnEditComponent } from "./components/news/governorate-news-en/governorate-news-en-edit/governorate-news-en-edit.component";
import { GovernorateNewsEnViewComponent } from "./components/news/governorate-news-en/governorate-news-en-view/governorate-news-en-view.component";
import { ReportsArListComponent } from "./components/news/report-ar/reports-ar-list/reports-ar-list.component";
import { ReportsArAddComponent } from "./components/news/report-ar/reports-ar-add/reports-ar-add.component";
import { ReportsArEditComponent } from "./components/news/report-ar/reports-ar-edit/reports-ar-edit.component";
import { ReportsArViewComponent } from "./components/news/report-ar/reports-ar-view/reports-ar-view.component";
import { ReportsEnListComponent } from "./components/news/report-en/reports-en-list/reports-en-list.component";
import { ReportsEnAddComponent } from "./components/news/report-en/reports-en-add/reports-en-add.component";
import { ReportsEnEditComponent } from "./components/news/report-en/reports-en-edit/reports-en-edit.component";
import { ReportsEnViewComponent } from "./components/news/report-en/reports-en-view/reports-en-view.component";
import { AuctionAddComponent } from "./components/auction/auction-add/auction-add.component";
import { AuctionListComponent } from "./components/auction/auction-list/auction-list.component";
import { AuctionEditComponent } from "./components/auction/auction-edit/auction-edit.component";
import { AuctionViewComponent } from "./components/auction/auction-view/auction-view.component";
import { OpenDataCategueryListComponent } from "./components/open-data-categuery/open-data-categuery-list/open-data-categuery-list.component";
import { OpenDataCategueryAddComponent } from "./components/open-data-categuery/open-data-categuery-add/open-data-categuery-add.component";
import { OpenDataCategueryEditComponent } from "./components/open-data-categuery/open-data-categuery-edit/open-data-categuery-edit.component";
import { OpenDataCategueryViewComponent } from "./components/open-data-categuery/open-data-categuery-view/open-data-categuery-view.component";
import { OpenDataReportViewComponent } from "./components/open-data-report/open-data-report-view/open-data-report-view.component";
import { OpenDataReportEditComponent } from "./components/open-data-report/open-data-report-edit/open-data-report-edit.component";
import { OpenDataReportAddComponent } from "./components/open-data-report/open-data-report-add/open-data-report-add.component";
import { OpenDataReportListComponent } from "./components/open-data-report/open-data-report-list/open-data-report-list.component";
import { PrisonAddComponent } from "./components/prison/prison-add/prison-add.component";
import { PrisonEditComponent } from "./components/prison/prison-edit/prison-edit.component";
import { PrisonListComponent } from "./components/prison/prison-list/prison-list.component";
import { PrisonViewComponent } from "./components/prison/prison-view/prison-view.component";

const routes: Routes = [

  //#region GovernorateNewsAr
  {
    path: "governorate-news-ar-list",
    component: GovernorateNewsArListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-ar-add",
    component: GovernorateNewsArAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-ar-edit/:id",
    component: GovernorateNewsArEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-ar-view/:id",
    component: GovernorateNewsArViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion
  //#region GovernorateNewsEn
  {
    path: "governorate-news-en-list",
    component: GovernorateNewsEnListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-en-add",
    component: GovernorateNewsEnAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-en-edit/:id",
    component: GovernorateNewsEnEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "governorate-news-en-view/:id",
    component: GovernorateNewsEnViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion

  //#region LatestNewsAr
  {
    path: "latest-news-ar-list",
    component: LatestNewsArListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-ar-add",
    component: LatestNewsArAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-ar-edit/:id",
    component: LatestNewsArEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-ar-view/:id",
    component: LatestNewsArViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-ar-comments",
    component: LatestNewsArCommentsComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion
  //#region LatestNewsEn
  {
    path: "latest-news-en-list",
    component: LatestNewsEnListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-en-add",
    component: LatestNewsEnAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-en-edit/:id",
    component: LatestNewsEnEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-en-view/:id",
    component: LatestNewsEnViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "latest-news-en-comments",
    component: LatestNewsEnCommentsComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion

  //#region ReportsAr
  {
    path: "reports-ar-list",
    component: ReportsArListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-ar-add",
    component: ReportsArAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-ar-edit/:id",
    component: ReportsArEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-ar-view/:id",
    component: ReportsArViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion
  //#region ReportsEn
  {
    path: "reports-en-list",
    component: ReportsEnListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-en-add",
    component: ReportsEnAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-en-edit/:id",
    component: ReportsEnEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-en-view/:id",
    component: ReportsEnViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion


  //#region EmiratesPrince
  {
    path: "emirates-prince-add",
    component: EmiratesPrinceAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-prince-edit/:id",
    component: EmiratesPrinceEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-prince-list",
    component: EmiratesPrinceListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-prince-view/:id",
    component: EmiratesPrinceViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  //#endregion

  //#region OpenDataCateguery
  {
    path: "open-data-categuery-list",
    component: OpenDataCategueryListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-categuery-add",
    component: OpenDataCategueryAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-categuery-edit/:id",
    component: OpenDataCategueryEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-categuery-view/:id",
    component: OpenDataCategueryViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region OpenDataReport
  {
    path: "open-data-report-list",
    component: OpenDataReportListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-report-add",
    component: OpenDataReportAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-report-edit/:id",
    component: OpenDataReportEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "open-data-report-view/:id",
    component: OpenDataReportViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region Poster
  {
    path: "poster-list",
    component: ListPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-add",
    component: AddPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-edit/:id",
    component: EditPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-view/:id",
    component: ViewPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region Auction
  {
    path: "auction-list",
    component: AuctionListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "auction-add",
    component: AuctionAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "auction-edit/:id",
    component: AuctionEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "auction-view/:id",
    component: AuctionViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region CaseType
  {
    path: "case-type-add",
    component: CaseTypeAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "case-type-edit/:id",
    component: CaseTypeEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "case-type-list",
    component: CaseTypeListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "case-type-view/:id",
    component: CaseTypeViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region Prison
  {
    path: "prison-add",
    component: PrisonAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "prison-edit/:id",
    component: PrisonEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "prison-list",
    component: PrisonListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "prison-view/:id",
    component: PrisonViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region Governorate
  {
    path: "governorate-add",
    component: GovernorateAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "governorate-edit/:id",
    component: GovernorateEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "governorate-list",
    component: GovernorateListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "governorate-view/:id",
    component: GovernorateViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region NewsCateguery
  {
    path: "news-categuery-add",
    component: NewsCategueryAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "news-categuery-edit/:id",
    component: NewsCategueryEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "news-categuery-list",
    component: NewsCategueryListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "news-categuery-view/:id",
    component: NewsCategueryViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion


  //#region RequestAttachmentType
  {
    path: "request-attachment-type-add",
    component: RequestAttachmentTypeAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-attachment-type-edit/:id",
    component: RequestAttachmentTypeEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-attachment-type-list",
    component: RequestAttachmentTypeListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-attachment-type-view/:id",
    component: RequestAttachmentTypeViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  //#endregion

  //#region RequestType
  {
    path: "request-type-add",
    component: RequestTypeAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-type-edit/:id",
    component: RequestTypeEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-type-list",
    component: RequestTypeListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "request-type-view/:id",
    component: RequestTypeViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  //#endregion

  //#region Service
  {
    path: "service-list",
    component: ServiceListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "service-add",
    component: ServiceAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  {
    path: "service-edit/:id",
    component: ServiceEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "service-audience/:id",
    component: ServiceAudienceComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "service-condition/:id",
    component: ServiceConditionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  {
    path: "service-view/:id",
    component: ServiceViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin]
    }
  },
  //#endregion

  //#region ServiceStage
  {
    path: "service-stage-list",
    component: ServiceStageListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  {
    path: "service-stage-add",
    component: ServiceStageAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  {
    path: "service-stage-edit/:id",
    component: ServiceStageEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  {
    path: "service-stage-view/:id",
    component: ServiceStageViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  //#endregion


  //#region AboutUs
  {
    path: "edit-about-us",
    component: EditAboutUsComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },

  {
    path: "edit-woman-section",
    component: EditWomanSectionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  {
    path: "",
    redirectTo: "index",
    pathMatch: "full",
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DataManagementRoutingModule { }
