import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ButtonModule } from 'primeng/button';
import { MessageModule } from 'primeng/message';
import { ToastModule } from 'primeng/toast';
import { CoreModule } from '../core/core.module';
import { HomeComponent } from './components/home/home.component';
import { HomeRoutingModule } from './home-routing.module';
import { NewsComponent } from './components/news/news.component';
import { NewsInnerComponent } from './components/news-inner/news-inner.component';
import { ServicesGuideComponent } from './components/services-guide/services-guide.component';
import { ServicesGuideInnerComponent } from './components/services-guide-inner/services-guide-inner.component';
// emirate pages
import { AboutusComponent } from './components/emirate/aboutus/aboutus.component';
import { WomenSectionComponent } from './components/emirate/women-section/women-section.component';
import { RegionPrincesComponent } from './components/emirate/region-princes/region-princes.component';
import { OrganizationChartComponent } from './components/emirate/organization-chart/organization-chart.component';
import { LatestNewsComponent } from './components/latest-news/latest-news.component';
import { LatestNewsInnerComponent } from './components/latest-news-inner/latest-news-inner.component';
import { OpenDataComponent } from './components/open-data/open-data.component';
import { GovernorateShowComponent } from './components/emirate/governorate-show/governorate-show.component';
import { ProfileComponent } from './components/profile/profile.component';
import { EditProfileComponent } from './components/edit-profile/edit-profile.component';
import { PrivacyComponent } from './components/privacy/privacy.component';
import { ConditionsComponent } from './components/conditions/conditions.component';
import { SLAComponent } from './components/sla/sla.component';
import { RSSComponent } from './components/rss/rss.component';
import { MobileApplicationsComponent } from './components/mobile-applications/mobile-applications.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';

@NgModule({
  declarations: [
    HomeComponent,
     NewsComponent,
     NewsInnerComponent ,
     LatestNewsComponent,
     LatestNewsInnerComponent,
     ServicesGuideComponent,
     ServicesGuideInnerComponent,
     AboutusComponent,
     WomenSectionComponent,
     RegionPrincesComponent,
        OrganizationChartComponent,
        OpenDataComponent,
        GovernorateShowComponent,
        ProfileComponent,
        EditProfileComponent,
        PrivacyComponent,
        ConditionsComponent,
        SLAComponent,
        RSSComponent,
        MobileApplicationsComponent,
        ContactUsComponent
    ],
  imports: [
    SharedModule,
    HomeRoutingModule,
    MessageModule,
    ButtonModule,
    ToastModule,
    CoreModule,
  ],
  exports: [],
  providers: [],
})
export class HomeModule { }
