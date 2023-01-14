import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { EServiceAdminRoutingModule } from './eservice-admin-routing.module';
import { RequestWorkflowDetailsComponent } from './components/request-workflow-details/request-workflow-details.component';
import { StepsModule } from 'primeng/steps';
import { NgxPrintModule } from 'ngx-print';

import { PrisonerTempReleaseViewComponent } from './components/prisoner-temp-release/prisoner-temp-release-view/prisoner-temp-release-view.component';
import { PrisonerTempReleaseActionComponent } from './components/prisoner-temp-release/prisoner-temp-release-action/prisoner-temp-release-action.component';
import { RequestWorkflowActionComponent } from './components/request-workflow-action/request-workflow-action.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InboxComponent } from './components/inbox/inbox.component';
import { PrisonerTempReleasePreviewStepComponent } from './components/prisoner-temp-release/prisoner-temp-release-preview-step/prisoner-temp-release-preview-step.component';
import { PrisonersServicesActionComponent } from './components/prisoners-services/prisoners-services-action/prisoners-services-action.component';
import { PrisonersServicesPreviewStepComponent } from './components/prisoners-services/prisoners-services-preview-step/prisoners-services-preview-step.component';
import { PrisonersServicesViewComponent } from './components/prisoners-services/prisoners-services-view/prisoners-services-view.component';
import { EServiceModule } from 'src/app/portal/modules/eservice/eservice.module';
import { InboxShamelComponent } from './components/inbox-shamel/inbox-shamel.component';
import { LandsInfringementActionComponent } from './components/lands-infringement/lands-infringement-action/lands-infringement-action.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';
import { ElectronicSummonActionComponent } from './components/electronic-summon/electronic-summon-action/electronic-summon-action.component';
import { ElectronicSummonViewComponent } from './components/electronic-summon/electronic-summon-view/electronic-summon-view.component';
import { ElectronicSummonPreviewStepComponent } from './components/electronic-summon/electronic-summon-preview-step/electronic-summon-preview-step.component';
import { ElectronicCouncilActionComponent } from './components/electronic-council/electronic-council-action/electronic-council-action.component';
import { ElectronicCouncilViewComponent } from './components/electronic-council/electronic-council-view/electronic-council-view.component';
import { ElectronicCouncilStepViewComponent } from './components/electronic-council/electronic-council-step-view/electronic-council-step-view.component';
import { MarriageCertificateActionComponent } from './components/marriage-certificate/marriage-certificate-action/marriage-certificate-action.component';
import { MarriageCertificatePreviewStepComponent } from './components/marriage-certificate/marriage-certificate-preview-step/marriage-certificate-preview-step.component';
import { MarriageCertificateViewComponent } from './components/marriage-certificate/marriage-certificate-view/marriage-certificate-view.component';
import { JudgmentExecutionActionComponent } from './components/judgment-execution/judgment-execution-action/judgment-execution-action.component';
import { JudgmentExecutionViewComponent } from './components/judgment-execution/judgment-execution-view/judgment-execution-view.component';
import { JudgmentExecutionPreviewStepComponent } from './components/judgment-execution/judgment-execution-preview-step/judgment-execution-preview-step.component';
import { ForeignersRealtyOwnerViewComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-view/foreigners-realty-owner-view.component';
import { ForeignersRealtyOwnerPreviewStepComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-preview-step/foreigners-realty-owner-preview-step.component';
import { ForeignersRealtyOwnerActionComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-action/foreigners-realty-owner-action.component';
import { TreatmentRecommendationViewComponent } from './components/treatment-recommendation/treatment-recommendation-view/treatment-recommendation-view.component';
import { TreatmentRecommendationPreviewStepComponent } from './components/treatment-recommendation/treatment-recommendation-preview-step/treatment-recommendation-preview-step.component';
import { TreatmentRecommendationActionComponent } from './components/treatment-recommendation/treatment-recommendation-action/treatment-recommendation-action.component';
import { RequestSearchComponent } from './components/request-search/request-search.component';

@NgModule({
  declarations: [
    RequestWorkflowDetailsComponent,
    PrisonerTempReleaseViewComponent,
    PrisonerTempReleaseActionComponent,
    RequestWorkflowActionComponent,
    InboxComponent,
    PrisonerTempReleasePreviewStepComponent,
    PrisonersServicesActionComponent,
    PrisonersServicesPreviewStepComponent,
    PrisonersServicesViewComponent,
    InboxShamelComponent,
    LandsInfringementActionComponent,
    LandsInfringementPreviewStepComponent,
    LandsInfringementViewComponent,
    ElectronicSummonActionComponent,
    ElectronicSummonViewComponent,
    ElectronicSummonPreviewStepComponent,
    ElectronicCouncilActionComponent,
    ElectronicCouncilViewComponent,
    ElectronicCouncilStepViewComponent,
    MarriageCertificateActionComponent,
    MarriageCertificatePreviewStepComponent,
    MarriageCertificateViewComponent,
    JudgmentExecutionActionComponent,
    JudgmentExecutionViewComponent,
    JudgmentExecutionPreviewStepComponent,
    ForeignersRealtyOwnerViewComponent,
    ForeignersRealtyOwnerPreviewStepComponent,
    ForeignersRealtyOwnerActionComponent,
    TreatmentRecommendationViewComponent,
    TreatmentRecommendationPreviewStepComponent,
    TreatmentRecommendationActionComponent,
    RequestSearchComponent,
  ],
  imports: [
    StepsModule,
    EServiceModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    EServiceAdminRoutingModule,
    SharedModule,
    NgxPrintModule,
  ],
})
export class EServiceAdminModule {}
