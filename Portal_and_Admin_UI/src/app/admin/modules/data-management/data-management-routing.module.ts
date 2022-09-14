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
import { LatestNewsListComponent } from "./components/latest-news/latest-news-list/latest-news-list.component";
import { LatestNewsAddComponent } from "./components/latest-news/latest-news-add/latest-news-add.component";
import { LatestNewsEditComponent } from "./components/latest-news/latest-news-edit/latest-news-edit.component";
import { LatestNewsViewComponent } from "./components/latest-news/latest-news-view/latest-news-view.component";
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

const routes: Routes = [
  {
    path: "latest-news-list",
    component: LatestNewsListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "latest-news-add",
    component: LatestNewsAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "latest-news-edit/:id",
    component: LatestNewsEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "latest-news-view/:id",
    component: LatestNewsViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "reports-list",
    component: ReportsListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "reports-add",
    component: ReportsAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "reports-edit/:id",
    component: ReportsEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "reports-view/:id",
    component: ReportsViewComponent,
    canActivate: [AuthGuard],
  },

  //#region Poster
  {
    path: "poster-list",
    component: ListPosterComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "poster-add",
    component: AddPosterComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "poster-edit/:id",
    component: EditPosterComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "poster-view/:id",
    component: ViewPosterComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region EmiratesNews
  {
    path: "emirates-news-add",
    component: EmiratesNewsAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "emirates-news-edit/:id",
    component: EmiratesNewsEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "emirates-news-list",
    component: EmiratesNewsListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "emirates-news-view/:id",
    component: EmiratesNewsViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region CaseType
  {
    path: "case-type-add",
    component: CaseTypeAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "case-type-edit/:id",
    component: CaseTypeEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "case-type-list",
    component: CaseTypeListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "case-type-view/:id",
    component: CaseTypeViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region RequestAttachmentType
  {
    path: "request-attachment-type-add",
    component: RequestAttachmentTypeAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-attachment-type-edit/:id",
    component: RequestAttachmentTypeEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-attachment-type-list",
    component: RequestAttachmentTypeListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-attachment-type-view/:id",
    component: RequestAttachmentTypeViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region RequestType
  {
    path: "request-type-add",
    component: RequestTypeAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-type-edit/:id",
    component: RequestTypeEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-type-list",
    component: RequestTypeListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "request-type-view/:id",
    component: RequestTypeViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region Service
  {
    path: "service-list",
    component: ServiceListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-add",
    component: ServiceAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-edit/:id",
    component: ServiceEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-view/:id",
    component: ServiceViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region ServiceStage
  {
    path: "service-stage-list",
    component: ServiceStageListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-stage-add",
    component: ServiceStageAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-stage-edit/:id",
    component: ServiceStageEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "service-stage-view/:id",
    component: ServiceStageViewComponent,
    canActivate: [AuthGuard],
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
