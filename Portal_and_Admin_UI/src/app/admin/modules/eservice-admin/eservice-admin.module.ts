import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { EServiceAdminRoutingModule } from './eservice-admin-routing.module';
import { RequestWorkflowDetailsComponent } from './components/request-workflow-details/request-workflow-details.component';
import { StepsModule } from 'primeng/steps';
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
  ],
  imports: [
    StepsModule,
    EServiceModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    EServiceAdminRoutingModule,
    SharedModule,
  ],
})
export class EServiceAdminModule {}
