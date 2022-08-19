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
    LandsInfringementDetailsComponent,
  ],
})
export class EServiceModule {}
