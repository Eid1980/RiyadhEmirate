import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@shared/guards/auth.guard';
import { Role } from '@shared/enums/role.enum';
import { ElectronicCouncilActionComponent } from './components/electronic-council/electronic-council-action/electronic-council-action.component';
import { ElectronicCouncilStepViewComponent } from './components/electronic-council/electronic-council-step-view/electronic-council-step-view.component';
import { ElectronicCouncilViewComponent } from './components/electronic-council/electronic-council-view/electronic-council-view.component';
import { ElectronicSummonActionComponent } from './components/electronic-summon/electronic-summon-action/electronic-summon-action.component';
import { ElectronicSummonPreviewStepComponent } from './components/electronic-summon/electronic-summon-preview-step/electronic-summon-preview-step.component';
import { ElectronicSummonViewComponent } from './components/electronic-summon/electronic-summon-view/electronic-summon-view.component';
import { ForeignersRealtyOwnerActionComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-action/foreigners-realty-owner-action.component';
import { ForeignersRealtyOwnerPreviewStepComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-preview-step/foreigners-realty-owner-preview-step.component';
import { ForeignersRealtyOwnerViewComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-view/foreigners-realty-owner-view.component';
import { InboxShamelComponent } from './components/inbox-shamel/inbox-shamel.component';
import { InboxComponent } from './components/inbox/inbox.component';
import { JudgmentExecutionActionComponent } from './components/judgment-execution/judgment-execution-action/judgment-execution-action.component';
import { JudgmentExecutionPreviewStepComponent } from './components/judgment-execution/judgment-execution-preview-step/judgment-execution-preview-step.component';
import { JudgmentExecutionViewComponent } from './components/judgment-execution/judgment-execution-view/judgment-execution-view.component';
import { LandsInfringementActionComponent } from './components/lands-infringement/lands-infringement-action/lands-infringement-action.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';
import { MarriageCertificateActionComponent } from './components/marriage-certificate/marriage-certificate-action/marriage-certificate-action.component';
import { MarriageCertificatePreviewStepComponent } from './components/marriage-certificate/marriage-certificate-preview-step/marriage-certificate-preview-step.component';
import { MarriageCertificateViewComponent } from './components/marriage-certificate/marriage-certificate-view/marriage-certificate-view.component';
import { PrisonerTempReleaseActionComponent } from './components/prisoner-temp-release/prisoner-temp-release-action/prisoner-temp-release-action.component';
import { PrisonerTempReleasePreviewStepComponent } from './components/prisoner-temp-release/prisoner-temp-release-preview-step/prisoner-temp-release-preview-step.component';
import { PrisonerTempReleaseViewComponent } from './components/prisoner-temp-release/prisoner-temp-release-view/prisoner-temp-release-view.component';
import { PrisonersServicesActionComponent } from './components/prisoners-services/prisoners-services-action/prisoners-services-action.component';
import { PrisonersServicesPreviewStepComponent } from './components/prisoners-services/prisoners-services-preview-step/prisoners-services-preview-step.component';
import { PrisonersServicesViewComponent } from './components/prisoners-services/prisoners-services-view/prisoners-services-view.component';
import { TreatmentRecommendationActionComponent } from './components/treatment-recommendation/treatment-recommendation-action/treatment-recommendation-action.component';
import { TreatmentRecommendationPreviewStepComponent } from './components/treatment-recommendation/treatment-recommendation-preview-step/treatment-recommendation-preview-step.component';
import { TreatmentRecommendationViewComponent } from './components/treatment-recommendation/treatment-recommendation-view/treatment-recommendation-view.component';
import { RequestSearchComponent } from './components/request-search/request-search.component';

const routes: Routes = [
  {
    path: 'inbox',
    component: InboxComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview]
    }
  },
  {
    path: 'inbox-shamel',
    component: InboxShamelComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.ShamelRequestReview]
    }
  },
  {
    path: 'request-search',
    component: RequestSearchComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },

  //#region PrisonersServices
  {
    path: 'prisoners-services-admin-preview-step/:id',
    component: PrisonersServicesPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'prisoners-services-admin-view/:id',
    component: PrisonersServicesViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'prisoners-services-action/:id',
    component: PrisonersServicesActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region ElectronicSummon
  {
    path: 'electronic-summon-admin-preview-step/:id',
    component: ElectronicSummonPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'electronic-summon-admin-view/:id',
    component: ElectronicSummonViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'electronic-summon-action/:id',
    component: ElectronicSummonActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region MarriageCertificate
  {
    path: 'marriage-certificate-admin-preview-step/:id',
    component: MarriageCertificatePreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'marriage-certificate-admin-view/:id',
    component: MarriageCertificateViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'marriage-certificate-action/:id',
    component: MarriageCertificateActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region ElectronicCouncilBooard
  {
    path: 'electronic-council-admin-preview-step/:id',
    component: ElectronicCouncilStepViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'electronic-council-admin-view/:id',
    component: ElectronicCouncilViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'electronic-council-action/:id',
    component: ElectronicCouncilActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region LandsInfringement
  {
    path: 'lands-infringement-admin-preview-step/:id',
    component: LandsInfringementPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'lands-infringement-admin-view/:id',
    component: LandsInfringementViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'lands-infringement-action/:id',
    component: LandsInfringementActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region JudgmentExecution
  {
    path: 'judgment-execution-admin-preview-step/:id',
    component: JudgmentExecutionPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'judgment-execution-admin-view/:id',
    component: JudgmentExecutionViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'judgment-execution-action/:id',
    component: JudgmentExecutionActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region PrisonerTempRelease
  {
    path: 'prisoner-temp-release-admin-preview-step/:id',
    component: PrisonerTempReleasePreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'prisoner-temp-release-admin-view/:id',
    component: PrisonerTempReleaseViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'prisoner-temp-release-action/:id',
    component: PrisonerTempReleaseActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region ForeignersRealtyOwner
  {
    path: 'foreigners-realty-owner-admin-preview-step/:id',
    component: ForeignersRealtyOwnerPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'foreigners-realty-owner-admin-view/:id',
    component: ForeignersRealtyOwnerViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'foreigners-realty-owner-action/:id',
    component: ForeignersRealtyOwnerActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion

  //#region TreatmentRecommendation
  {
    path: 'treatment-recommendation-admin-preview-step/:id',
    component: TreatmentRecommendationPreviewStepComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'treatment-recommendation-admin-view/:id',
    component: TreatmentRecommendationViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  {
    path: 'treatment-recommendation-action/:id',
    component: TreatmentRecommendationActionComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.RequestReview, Role.ShamelRequestReview]
    }
  },
  //#endregion
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EServiceAdminRoutingModule { }
