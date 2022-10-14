import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./components/home/home.component";
import { ServicesGuideInnerComponent } from "./components/services-guide-inner/services-guide-inner.component";
import { ServicesGuideComponent } from "./components/services-guide/services-guide.component";
import { AboutusComponent } from "./components/emirate/aboutus/aboutus.component";
import { OrganizationChartComponent } from "./components/emirate/organization-chart/organization-chart.component";
import { RegionPrincesComponent } from "./components/emirate/region-princes/region-princes.component";
import { WomenSectionComponent } from "./components/emirate/women-section/women-section.component";
import { LatestNewsComponent } from "./components/latest-news/latest-news.component";
import { NewsDetailsComponent } from "./components/news-details/news-details.component";
import { OpenDataComponent } from "./components/open-data/open-data.component";
import { GovernorateShowComponent } from "./components/emirate/governorate-show/governorate-show.component";
import { ProfileComponent } from "./components/profile/profile.component";
import { EditProfileComponent } from "./components/edit-profile/edit-profile.component";
import { PrivacyComponent } from "./components/privacy/privacy.component";
import { RSSComponent } from "./components/rss/rss.component";
import { MobileApplicationsComponent } from "./components/mobile-applications/mobile-applications.component";
import { ContactUsComponent } from "./components/contact-us/contact-us.component";
import { SLAComponent } from "./components/sla/sla.component";
import { ConditionsComponent } from "./components/conditions/conditions.component";
import { NewsSearchComponent } from "./components/news-search/news-search.component";
import { GovernorateNewsComponent } from "./components/governorate-news/governorate-news.component";
import { ReportsComponent } from "./components/reports/reports.component";
import { TransactionInquiryComponent } from "./components/transaction-inquiry/transaction-inquiry.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent },
  { path: "home/transaction-inquiry", component: TransactionInquiryComponent },
  { path: "home/news-search", component: NewsSearchComponent },
  { path: "home/services-guide", component: ServicesGuideComponent },
  { path: "home/services-guide/:id", component: ServicesGuideInnerComponent },
  { path: "home/latest-news", component: LatestNewsComponent },
  { path: "home/governorate-news", component: GovernorateNewsComponent },
  { path: "home/reports-news", component: ReportsComponent },
  { path: "home/news-details/:id", component: NewsDetailsComponent },
  { path: "profile", component: ProfileComponent },
  { path: "edit-profile", component: EditProfileComponent },
  { path: "open-data", component: OpenDataComponent },
  { path: "home/privacy", component: PrivacyComponent },
  { path: "home/conditions", component: ConditionsComponent },
  { path: "home/sla", component: SLAComponent },
  { path: "home/rss", component: RSSComponent },
  { path: "home/mobile-applications", component: MobileApplicationsComponent },
  { path: "home/contact-us", component: ContactUsComponent },
  { path: "home/aboutus", component: AboutusComponent },
  { path: "home/region-princes", component: RegionPrincesComponent },
  { path: "home/governorate-show", component: GovernorateShowComponent },
  { path: "home/organization", component: OrganizationChartComponent },
  { path: "home/women-section", component: WomenSectionComponent },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
