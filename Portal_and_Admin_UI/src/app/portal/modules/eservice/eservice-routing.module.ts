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
import { LandsInfringementComponent } from './components/lands-infringement/lands-infringement/lands-infringement.component';
import { LandsInfringementAttachmentsComponent } from './components/lands-infringement/lands-infringement-attachments/lands-infringement-attachments.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';
import { ElectronicSummonComponent } from './components/electronic-summon/electronic-summon/electronic-summon.component';
import { ElectronicSummonAttachmentsComponent } from './components/electronic-summon/electronic-summon-attachments/electronic-summon-attachments.component';
import { ElectronicSummonPreviewStepComponent } from './components/electronic-summon/electronic-summon-preview-step/electronic-summon-preview-step.component';
import { ElectronicSummonViewComponent } from './components/electronic-summon/electronic-summon-view/electronic-summon-view.component';
import { MarriageCertificateComponent } from './components/marriage-certificate/marriage-certificate/marriage-certificate.component';
import { MarriageCertificateAttachmentsComponent } from './components/marriage-certificate/marriage-certificate-attachments/marriage-certificate-attachments.component';
import { MarriageCertificatePreviewStepComponent } from './components/marriage-certificate/marriage-certificate-preview-step/marriage-certificate-preview-step.component';
import { MarriageCertificateViewComponent } from './components/marriage-certificate/marriage-certificate-view/marriage-certificate-view.component';
import { JudgmentExecutionComponent } from './components/judgment-execution/judgment-execution/judgment-execution.component';
import { JudgmentExecutionAttachmentsComponent } from './components/judgment-execution/judgment-execution-attachments/judgment-execution-attachments.component';
import { JudgmentExecutionPreviewStepComponent } from './components/judgment-execution/judgment-execution-preview-step/judgment-execution-preview-step.component';
import { JudgmentExecutionViewComponent } from './components/judgment-execution/judgment-execution-view/judgment-execution-view.component';
import { ForeignersRealtyOwnerComponent } from './components/foreigners-realty-owner/foreigners-realty-owner/foreigners-realty-owner.component';
import { ForeignersRealtyOwnerAttachmentsComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-attachments/foreigners-realty-owner-attachments.component';
import { ForeignersRealtyOwnerPreviewStepComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-preview-step/foreigners-realty-owner-preview-step.component';
import { ForeignersRealtyOwnerViewComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-view/foreigners-realty-owner-view.component';
import { TreatmentRecommendationComponent } from './components/treatment-recommendation/treatment-recommendation/treatment-recommendation.component';
import { TreatmentRecommendationAttachmentsComponent } from './components/treatment-recommendation/treatment-recommendation-attachments/treatment-recommendation-attachments.component';
import { TreatmentRecommendationPreviewStepComponent } from './components/treatment-recommendation/treatment-recommendation-preview-step/treatment-recommendation-preview-step.component';
import { TreatmentRecommendationViewComponent } from './components/treatment-recommendation/treatment-recommendation-view/treatment-recommendation-view.component';
import { ElectronicCouncilViewComponent } from './components/electronic-council/electronic-council-view/electronic-council-view.component';
import { ElectronicCouncilPreviewStepComponent } from './components/electronic-council/electronic-council-preview-step/electronic-council-preview-step.component';
import { ElectronicCouncilAttachmentsComponent } from './components/electronic-council/electronic-council-attachments/electronic-council-attachments.component';
import { ElectronicCouncilComponent } from './components/electronic-council/electronic-council/electronic-council.component';

const routes: Routes = [
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

    //#region ElectronicCouncil
    {
      path: 'electronic-council',
      component: ElectronicCouncilComponent,
      canActivate: [AuthGuard],
    },
    {
      path: 'electronic-council/:id',
      component: ElectronicCouncilComponent,
      canActivate: [AuthGuard],
    },
    {
      path: 'electronic-council-attachments/:id',
      component: ElectronicCouncilAttachmentsComponent,
      canActivate: [AuthGuard],
    },
    {
      path: 'electronic-council-preview-step/:id',
      component: ElectronicCouncilPreviewStepComponent,
      canActivate: [AuthGuard],
    },
    {
      path: 'electronic-council-view/:id',
      component: ElectronicCouncilViewComponent,
      canActivate: [AuthGuard],
    },
    //#endregion

  //#region ElectronicSummon
  {
    path: 'electronic-summon',
    component: ElectronicSummonComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon/:id',
    component: ElectronicSummonComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon-attachments/:id',
    component: ElectronicSummonAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon-preview-step/:id',
    component: ElectronicSummonPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'electronic-summon-view/:id',
    component: ElectronicSummonViewComponent,
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

  //#region MarriageCertificate
  {
    path: 'marriage-certificate',
    component: MarriageCertificateComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'marriage-certificate/:id',
    component: MarriageCertificateComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'marriage-certificate-attachments/:id',
    component: MarriageCertificateAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'marriage-certificate-preview-step/:id',
    component: MarriageCertificatePreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'marriage-certificate-view/:id',
    component: MarriageCertificateViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region JudgmentExecution
  {
    path: 'judgment-execution',
    component: JudgmentExecutionComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'judgment-execution/:id',
    component: JudgmentExecutionComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'judgment-execution-attachments/:id',
    component: JudgmentExecutionAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'judgment-execution-preview-step/:id',
    component: JudgmentExecutionPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'judgment-execution-view/:id',
    component: JudgmentExecutionViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region ForeignersRealtyOwner
  {
    path: 'foreigners-realty-owner',
    component: ForeignersRealtyOwnerComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'foreigners-realty-owner/:id',
    component: ForeignersRealtyOwnerComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'foreigners-realty-owner-attachments/:id',
    component: ForeignersRealtyOwnerAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'foreigners-realty-owner-preview-step/:id',
    component: ForeignersRealtyOwnerPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'foreigners-realty-owner-view/:id',
    component: ForeignersRealtyOwnerViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  //#region TreatmentRecommendation
  {
    path: 'treatment-recommendation',
    component: TreatmentRecommendationComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'treatment-recommendation/:id',
    component: TreatmentRecommendationComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'treatment-recommendation-attachments/:id',
    component: TreatmentRecommendationAttachmentsComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'treatment-recommendation-preview-step/:id',
    component: TreatmentRecommendationPreviewStepComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'treatment-recommendation-view/:id',
    component: TreatmentRecommendationViewComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  { path: '', redirectTo: 'services-list', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EServiceRoutingModule { }
