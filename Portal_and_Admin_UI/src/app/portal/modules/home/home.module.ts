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
import { RegionGovComponent } from './components/emirate/region-gov/region-gov.component';
import { OrganizationChartComponent } from './components/emirate/organization-chart/organization-chart.component';

@NgModule({
  declarations: [HomeComponent, NewsComponent, NewsInnerComponent, ServicesGuideComponent, ServicesGuideInnerComponent, AboutusComponent, WomenSectionComponent, RegionPrincesComponent, RegionGovComponent, OrganizationChartComponent],
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
