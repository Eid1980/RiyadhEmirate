import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@shared/guards/auth.guard';
import { PrisonerTempReleaseComponent } from './components/prisoner-temp-release/prisoner-temp-release/prisoner-temp-release.component';
import { PrisonerTempReleaseViewComponent } from './components/prisoner-temp-release/prisoner-temp-release-view/prisoner-temp-release-view.component';
import { RequesterDashboardComponent } from './components/requester-dashboard/requester-dashboard.component';
import { PrisonerTempReleaseAttachmentsComponent } from './components/prisoner-temp-release/prisoner-temp-release-attachments/prisoner-temp-release-attachments.component';
import { PrisonerTempReleasePreviewStepComponent } from './components/prisoner-temp-release/prisoner-temp-release-preview-step/prisoner-temp-release-preview-step.component';
import { MyRequestsComponent } from './components/my-requests/my-requests.component';
import { PrisonersServicesComponent } from './components/prisoners-services/prisoners-services/prisoners-services.component';
import { PrisonersServicesAttachmentsComponent } from './components/prisoners-services/prisoners-services-attachments/prisoners-services-attachments.component';
import { PrisonersServicesPreviewStepComponent } from './components/prisoners-services/prisoners-services-preview-step/prisoners-services-preview-step.component';
import { PrisonersServicesViewComponent } from './components/prisoners-services/prisoners-services-view/prisoners-services-view.component';
import { ServiceDetailsComponent } from './components/service-details/service-details.component';
import { ServicesListComponent } from './components/services-list/services-list.component';
import { LandsInfringementComponent } from './components/lands-infringement/lands-infringement/lands-infringement.component';
import { LandsInfringementAttachmentsComponent } from './components/lands-infringement/lands-infringement-attachments/lands-infringement-attachments.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';

const routes: Routes = [
  { path: 'services-list', component: ServicesListComponent },
  { path: 'services/:id', component: ServiceDetailsComponent },
  {
    path: 'my-requests',
    component: MyRequestsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'requester-dashboard',
    component: RequesterDashboardComponent,
    canActivate: [AuthGuard],
  },

  //#region PrisonersServices
  {
    path: 'prisoners-services',
    component: PrisonersServicesComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services/:id',
    component: PrisonersServicesComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services-attachments/:id',
    component: PrisonersServicesAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services-preview-step/:id',
    component: PrisonersServicesPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services-view/:id',
    component: PrisonersServicesViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region PrisonerTempRelease
  {
    path: 'prisoner-temp-release',
    component: PrisonerTempReleaseComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release/:id',
    component: PrisonerTempReleaseComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release-attachments/:id',
    component: PrisonerTempReleaseAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release-preview-step/:id',
    component: PrisonerTempReleasePreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release-view/:id',
    component: PrisonerTempReleaseViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region LandsInfringement
  {
    path: 'lands-infringement',
    component: LandsInfringementComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement/:id',
    component: LandsInfringementComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement-attachments/:id',
    component: LandsInfringementAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement-preview-step/:id',
    component: LandsInfringementPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement-view/:id',
    component: LandsInfringementViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  { path: '', redirectTo: 'services-list', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EServiceRoutingModule {}
