import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { DropdownModule } from 'primeng/dropdown';
import { PaginatorModule } from 'primeng/paginator';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import { CalendarModule } from 'primeng/calendar';
import { ContextMenuModule } from 'primeng/contextmenu';
import { InputMaskModule } from 'primeng/inputmask';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { RouterModule } from '@angular/router';
import { SharedRoutingModule } from './shared-routing.module';
import { InputSwitchModule } from 'primeng/inputswitch';
import { DialogModule } from 'primeng/dialog';
import { RatingModule } from 'primeng/rating';
import { AuthGuard } from './guards/auth.guard';
import { ProgressSpinnerComponent } from './components/progress-spinner/progress-spinner.component';
import { PageListComponent } from './components/page-list/page-list.component';
import { DataListComponent } from './components/data-list/data-list.component';
import { AuthorizeDirective } from './directives/authorize.directive';
import { HiddenAuthorizeColumnFilterPipe } from './pipes/hidden-authorize-coulmn-filter.pipe';
import { ViewProfileComponent } from './components/view-profile/view-profile.component';
import { FileUploadModule } from 'primeng/fileupload';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { MessageService } from 'primeng/api';
import { AuthLayoutComponent } from './components/auth-layout/auth-layout.component';
import { NotAuthorizedComponent } from './components/not-authorized/not-authorized.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { NgxHijriGregorianDatepickerModule } from 'ngx-hijri-gregorian-datepicker';
import { RequestAttacmentComponent } from './components/request-attacment/request-attacment.component';
import { RequestAttacmentPreviewComponent } from './components/request-attacment-preview/request-attacment-preview.component';
import { UserDataViewComponent } from './components/user-data-view/user-data-view.component';
import { UserDataCurrentViewComponent } from './components/user-data-current-view/user-data-current-view.component';
import { BreadcrumbModule } from 'primeng/breadcrumb';
import { RateServiceComponent } from './components/rate-service/rate-service.component';
import { RequestStageLogComponent } from './components/request-stage-log/request-stage-log.component';
import { ToastModule } from 'primeng/toast';
import { CustomSlicePipe } from './pipes/custom-slice.pipe';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { BrowserModule } from '@angular/platform-browser';
import { ServiceFilterPipe } from './pipes/service-filter.pipe';

@NgModule({
  declarations: [
    AuthLayoutComponent,
    NotAuthorizedComponent,
    PageNotFoundComponent,
    HiddenAuthorizeColumnFilterPipe,
    ProgressSpinnerComponent,
    PageListComponent,
    DataListComponent,
    AuthorizeDirective,
    ViewProfileComponent,
    RequestAttacmentComponent,
    RequestAttacmentPreviewComponent,
    RequestStageLogComponent,
    UserDataViewComponent,
    UserDataCurrentViewComponent,
    RateServiceComponent,
    CustomSlicePipe,
    ServiceFilterPipe,
  ],
  imports: [
    CommonModule,
    ProgressSpinnerModule,
    AutoCompleteModule,
    PaginatorModule,
    InputMaskModule,
    TableModule,
    CalendarModule,
    AutoCompleteModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule,
    SharedRoutingModule,
    InputSwitchModule,
    FileUploadModule,
    ConfirmDialogModule,
    BreadcrumbModule,
    ToastModule,
    DialogModule,
    RatingModule,
    NgxHijriGregorianDatepickerModule
  ],
  exports: [
    AuthLayoutComponent,
    NotAuthorizedComponent,
    PageNotFoundComponent,
    PageListComponent,
    DataListComponent,
    TableModule,
    AutoCompleteModule,
    ReactiveFormsModule,
    FormsModule,
    DropdownModule,
    CommonModule,
    ProgressSpinnerModule,
    AutoCompleteModule,
    CalendarModule,
    ReactiveFormsModule,
    ContextMenuModule,
    InputMaskModule,
    PaginatorModule,
    HiddenAuthorizeColumnFilterPipe,
    InputSwitchModule,
    ToastModule,
    DialogModule,
    DatePipe,
    FileUploadModule,
    ConfirmDialogModule,
    NgxHijriGregorianDatepickerModule,
    RequestAttacmentComponent,
    RequestAttacmentPreviewComponent,
    RequestStageLogComponent,
    UserDataViewComponent,
    UserDataCurrentViewComponent,
    RateServiceComponent,
    CustomSlicePipe,
    ServiceFilterPipe,
    TranslateModule
  ],
  providers: [
    HiddenAuthorizeColumnFilterPipe,
    AuthGuard,
    DatePipe,
    MessageService
  ],
})
export class SharedModule {}

// required for AOT compilation
export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}
