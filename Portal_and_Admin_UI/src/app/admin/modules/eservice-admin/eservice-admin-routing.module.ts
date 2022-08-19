import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@shared/guards/auth.guard';
import { ElectronicSummonActionComponent } from './components/electronic-summon/electronic-summon-action/electronic-summon-action.component';
import { ElectronicSummonPreviewStepComponent } from './components/electronic-summon/electronic-summon-preview-step/electronic-summon-preview-step.component';
import { ElectronicSummonViewComponent } from './components/electronic-summon/electronic-summon-view/electronic-summon-view.component';
import { InboxShamelComponent } from './components/inbox-shamel/inbox-shamel.component';
import { InboxComponent } from './components/inbox/inbox.component';
import { LandsInfringementActionComponent } from './components/lands-infringement/lands-infringement-action/lands-infringement-action.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';
import { PrisonerTempReleaseActionComponent } from './components/prisoner-temp-release/prisoner-temp-release-action/prisoner-temp-release-action.component';
import { PrisonerTempReleasePreviewStepComponent } from './components/prisoner-temp-release/prisoner-temp-release-preview-step/prisoner-temp-release-preview-step.component';
import { PrisonerTempReleaseViewComponent } from './components/prisoner-temp-release/prisoner-temp-release-view/prisoner-temp-release-view.component';
import { PrisonersServicesActionComponent } from './components/prisoners-services/prisoners-services-action/prisoners-services-action.component';
import { PrisonersServicesPreviewStepComponent } from './components/prisoners-services/prisoners-services-preview-step/prisoners-services-preview-step.component';
import { PrisonersServicesViewComponent } from './components/prisoners-services/prisoners-services-view/prisoners-services-view.component';

const routes: Routes = [
  {
    path: 'inbox',
    component: InboxComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'inbox-shamel',
    component: InboxShamelComponent,
    canActivate: [AuthGuard],
  },

  //#region PrisonersServices
  {
    path: 'prisoners-services-admin-preview-step/:id',
    component: PrisonersServicesPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services-admin-view/:id',
    component: PrisonersServicesViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoners-services-action/:id',
    component: PrisonersServicesActionComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region ElectronicSummon
  {
    path: 'electronic-summon-admin-preview-step/:id',
    component: ElectronicSummonPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon-admin-view/:id',
    component: ElectronicSummonViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon-action/:id',
    component: ElectronicSummonActionComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region LandsInfringement
  {
    path: 'lands-infringement-admin-preview-step/:id',
    component: LandsInfringementPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement-admin-view/:id',
    component: LandsInfringementViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'lands-infringement-action/:id',
    component: LandsInfringementActionComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region PrisonerTempRelease
  {
    path: 'prisoner-temp-release-admin-preview-step/:id',
    component: PrisonerTempReleasePreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release-admin-view/:id',
    component: PrisonerTempReleaseViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'prisoner-temp-release-action/:id',
    component: PrisonerTempReleaseActionComponent,
    canActivate: [AuthGuard],
  },
  //#endregion
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EServiceAdminRoutingModule {}
