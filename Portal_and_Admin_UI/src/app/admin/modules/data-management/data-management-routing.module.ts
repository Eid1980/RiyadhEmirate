import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { ListPosterComponent } from "./components/poster/list-poster/list-poster.component";
import { AddPosterComponent } from "./components/poster/add-poster/add-poster.component";
import { EditPosterComponent } from "./components/poster/edit-poster/edit-poster.component";
import { EmiratesNewsAddComponent } from "./components/emirates-news/emirates-news-add/emirates-news-add.component";
import { EmiratesNewsListComponent } from "./components/emirates-news/emirates-news-list/emirates-news-list.component";
import { EmiratesNewsEditComponent } from "./components/emirates-news/emirates-news-edit/emirates-news-edit.component";
import { EmiratesNewsViewComponent } from "./components/emirates-news/emirates-news-view/emirates-news-view.component";
import { ReportsListComponent } from "./components/reports/reports-list/reports-list.component";
import { ReportsAddComponent } from "./components/reports/reports-add/reports-add.component";
import { ReportsEditComponent } from "./components/reports/reports-edit/reports-edit.component";
import { ReportsViewComponent } from "./components/reports/reports-view/reports-view.component";
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
import { LatestNewsArListComponent } from "./components/latest-news-ar/latest-news-ar-list/latest-news-ar-list.component";
import { LatestNewsArAddComponent } from "./components/latest-news-ar/latest-news-ar-add/latest-news-ar-add.component";
import { LatestNewsArEditComponent } from "./components/latest-news-ar/latest-news-ar-edit/latest-news-ar-edit.component";
import { LatestNewsArViewComponent } from "./components/latest-news-ar/latest-news-ar-view/latest-news-ar-view.component";
import { LatestNewsEnEditComponent } from "./components/latest-news-en/latest-news-en-edit/latest-news-en-edit.component";
import { LatestNewsEnListComponent } from "./components/latest-news-en/latest-news-en-list/latest-news-en-list.component";
import { LatestNewsEnAddComponent } from "./components/latest-news-en/latest-news-en-add/latest-news-en-add.component";
import { LatestNewsEnViewComponent } from "./components/latest-news-en/latest-news-en-view/latest-news-en-view.component";
import { EditAboutUsComponent } from "./components/about-us/edit-about-us/edit-about-us.component";
import { EditWomanSectionComponent } from "./components/woman-section/edit-woman-section/edit-woman-section.component";
import { LatestNewsEnCommentsComponent } from "./components/latest-news-en/latest-news-en-comments/latest-news-en-comments.component";
import { LatestNewsArCommentsComponent } from "./components/latest-news-ar/latest-news-ar-comments/latest-news-ar-comments.component";
import { GovernorateAddComponent } from "./components/governorates/governorate-add/governorate-add.component";
import { GovernorateEditComponent } from "./components/governorates/governorate-edit/governorate-edit.component";
import { GovernorateListComponent } from "./components/governorates/governorate-list/governorate-list.component";
import { GovernorateViewComponent } from "./components/governorates/governorate-view/governorate-view.component";
import { Role } from "@shared/enums/role.enum";
import { EmiratesPrinceViewComponent } from "./components/emirates-prince/emirates-prince-view/emirates-prince-view.component";
import { EmiratesPrinceListComponent } from "./components/emirates-prince/emirates-prince-list/emirates-prince-list.component";
import { EmiratesPrinceEditComponent } from "./components/emirates-prince/emirates-prince-edit/emirates-prince-edit.component";
import { EmiratesPrinceAddComponent } from "./components/emirates-prince/emirates-prince-add/emirates-prince-add.component";

const routes: Routes = [
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

  //#region EmiratesNews
  {
    path: "emirates-news-add",
    component: EmiratesNewsAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-news-edit/:id",
    component: EmiratesNewsEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-news-list",
    component: EmiratesNewsListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "emirates-news-view/:id",
    component: EmiratesNewsViewComponent,
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

  //#region Reports
  {
    path: "reports-list",
    component: ReportsListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-add",
    component: ReportsAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-edit/:id",
    component: ReportsEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
    }
  },
  {
    path: "reports-view/:id",
    component: ReportsViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.NewsPermission]
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
