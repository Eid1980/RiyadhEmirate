import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { StepsModule } from 'primeng/steps';
import { ToastModule } from 'primeng/toast';

import { EServiceRoutingModule } from './eservice-routing.module';
import { RequesterDashboardComponent } from './components/requester-dashboard/requester-dashboard.component';
import { PrisonerTempReleaseViewComponent } from './components/prisoner-temp-release/prisoner-temp-release-view/prisoner-temp-release-view.component';
import { PrisonerTempReleaseComponent } from './components/prisoner-temp-release/prisoner-temp-release/prisoner-temp-release.component';
import { PrisonerTempReleaseAttachmentsComponent } from './components/prisoner-temp-release/prisoner-temp-release-attachments/prisoner-temp-release-attachments.component';
import { PrisonerTempReleaseDetailsComponent } from './components/prisoner-temp-release/prisoner-temp-release-details/prisoner-temp-release-details.component';
import { PrisonerTempReleasePreviewStepComponent } from './components/prisoner-temp-release/prisoner-temp-release-preview-step/prisoner-temp-release-preview-step.component';
import { MyRequestsComponent } from './components/my-requests/my-requests.component';
import { PrisonersServicesComponent } from './components/prisoners-services/prisoners-services/prisoners-services.component';
import { PrisonersServicesAttachmentsComponent } from './components/prisoners-services/prisoners-services-attachments/prisoners-services-attachments.component';
import { PrisonersServicesDetailsComponent } from './components/prisoners-services/prisoners-services-details/prisoners-services-details.component';
import { PrisonersServicesPreviewStepComponent } from './components/prisoners-services/prisoners-services-preview-step/prisoners-services-preview-step.component';
import { PrisonersServicesViewComponent } from './components/prisoners-services/prisoners-services-view/prisoners-services-view.component';
import { ServiceDetailsComponent } from './components/service-details/service-details.component';
import { ServicesListComponent } from './components/services-list/services-list.component';
import { LandsInfringementComponent } from './components/lands-infringement/lands-infringement/lands-infringement.component';
import { LandsInfringementAttachmentsComponent } from './components/lands-infringement/lands-infringement-attachments/lands-infringement-attachments.component';
import { LandsInfringementDetailsComponent } from './components/lands-infringement/lands-infringement-details/lands-infringement-details.component';
import { LandsInfringementPreviewStepComponent } from './components/lands-infringement/lands-infringement-preview-step/lands-infringement-preview-step.component';
import { LandsInfringementViewComponent } from './components/lands-infringement/lands-infringement-view/lands-infringement-view.component';
import { ElectronicSummonComponent } from './components/electronic-summon/electronic-summon/electronic-summon.component';
import { ElectronicSummonAttachmentsComponent } from './components/electronic-summon/electronic-summon-attachments/electronic-summon-attachments.component';
import { ElectronicSummonDetailsComponent } from './components/electronic-summon/electronic-summon-details/electronic-summon-details.component';
import { ElectronicSummonViewComponent } from './components/electronic-summon/electronic-summon-view/electronic-summon-view.component';
import { ElectronicSummonPreviewStepComponent } from './components/electronic-summon/electronic-summon-preview-step/electronic-summon-preview-step.component';
import { ElectronicCouncilDetailsComponent } from './components/electronic-council/electronic-council-details/electronic-council-details.component';
import { JudgmentExecutionComponent } from './components/judgment-execution/judgment-execution/judgment-execution.component';
import { JudgmentExecutionAttachmentsComponent } from './components/judgment-execution/judgment-execution-attachments/judgment-execution-attachments.component';
import { JudgmentExecutionDetailsComponent } from './components/judgment-execution/judgment-execution-details/judgment-execution-details.component';
import { JudgmentExecutionViewComponent } from './components/judgment-execution/judgment-execution-view/judgment-execution-view.component';
import { JudgmentExecutionPreviewStepComponent } from './components/judgment-execution/judgment-execution-preview-step/judgment-execution-preview-step.component';
import { MarriageCertificateComponent } from './components/marriage-certificate/marriage-certificate/marriage-certificate.component';
import { MarriageCertificateAttachmentsComponent } from './components/marriage-certificate/marriage-certificate-attachments/marriage-certificate-attachments.component';
import { MarriageCertificateViewComponent } from './components/marriage-certificate/marriage-certificate-view/marriage-certificate-view.component';
import { MarriageCertificateDetailsComponent } from './components/marriage-certificate/marriage-certificate-details/marriage-certificate-details.component';
import { MarriageCertificatePreviewStepComponent } from './components/marriage-certificate/marriage-certificate-preview-step/marriage-certificate-preview-step.component';
import { ForeignersRealtyOwnerComponent } from './components/foreigners-realty-owner/foreigners-realty-owner/foreigners-realty-owner.component';
import { ForeignersRealtyOwnerAttachmentsComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-attachments/foreigners-realty-owner-attachments.component';
import { ForeignersRealtyOwnerDetailsComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-details/foreigners-realty-owner-details.component';
import { ForeignersRealtyOwnerViewComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-view/foreigners-realty-owner-view.component';
import { ForeignersRealtyOwnerPreviewStepComponent } from './components/foreigners-realty-owner/foreigners-realty-owner-preview-step/foreigners-realty-owner-preview-step.component';
import { TreatmentRecommendationComponent } from './components/treatment-recommendation/treatment-recommendation/treatment-recommendation.component';
import { TreatmentRecommendationDetailsComponent } from './components/treatment-recommendation/treatment-recommendation-details/treatment-recommendation-details.component';
import { TreatmentRecommendationAttachmentsComponent } from './components/treatment-recommendation/treatment-recommendation-attachments/treatment-recommendation-attachments.component';
import { TreatmentRecommendationPreviewStepComponent } from './components/treatment-recommendation/treatment-recommendation-preview-step/treatment-recommendation-preview-step.component';
import { TreatmentRecommendationViewComponent } from './components/treatment-recommendation/treatment-recommendation-view/treatment-recommendation-view.component';

@NgModule({
  declarations: [
    ServicesListComponent,
    ServiceDetailsComponent,
    RequesterDashboardComponent,
    PrisonerTempReleaseViewComponent,
    PrisonerTempReleaseComponent,
    PrisonerTempReleaseAttachmentsComponent,
    PrisonerTempReleaseDetailsComponent,
    PrisonerTempReleasePreviewStepComponent,
    MyRequestsComponent,
    PrisonersServicesComponent,
    PrisonersServicesAttachmentsComponent,
    PrisonersServicesDetailsComponent,
    PrisonersServicesPreviewStepComponent,
    PrisonersServicesViewComponent,
    LandsInfringementComponent,
    LandsInfringementAttachmentsComponent,
    LandsInfringementDetailsComponent,
    LandsInfringementPreviewStepComponent,
    LandsInfringementViewComponent,
    ElectronicSummonComponent,
    ElectronicSummonAttachmentsComponent,
    ElectronicSummonDetailsComponent,
    ElectronicSummonViewComponent,
    ElectronicSummonPreviewStepComponent,
    JudgmentExecutionComponent,
    JudgmentExecutionAttachmentsComponent,
    JudgmentExecutionDetailsComponent,
    JudgmentExecutionViewComponent,
    JudgmentExecutionPreviewStepComponent,
    MarriageCertificateComponent,
    MarriageCertificateAttachmentsComponent,
    MarriageCertificateViewComponent,
    MarriageCertificateDetailsComponent,
    MarriageCertificatePreviewStepComponent,
    ForeignersRealtyOwnerComponent,
    ForeignersRealtyOwnerAttachmentsComponent,
    ForeignersRealtyOwnerDetailsComponent,
    ForeignersRealtyOwnerViewComponent,
    ForeignersRealtyOwnerPreviewStepComponent,
    TreatmentRecommendationComponent,
    TreatmentRecommendationDetailsComponent,
    TreatmentRecommendationAttachmentsComponent,
    TreatmentRecommendationPreviewStepComponent,
    TreatmentRecommendationViewComponent,
    ElectronicCouncilDetailsComponent
  ],
  imports: [
    StepsModule,
    ToastModule,
    CommonModule,
    EServiceRoutingModule,
    SharedModule,
  ],
  exports: [
    PrisonerTempReleaseDetailsComponent,
    PrisonersServicesDetailsComponent,
    ElectronicSummonDetailsComponent,
    LandsInfringementDetailsComponent,
    ElectronicCouncilDetailsComponent
    JudgmentExecutionDetailsComponent,
    MarriageCertificateDetailsComponent,
    ForeignersRealtyOwnerDetailsComponent,
    TreatmentRecommendationDetailsComponent,
  ],
})
export class EServiceModule {}
