import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { HomeComponent } from "./components/home/home.component";
import { NewsInnerComponent } from "./components/news-inner/news-inner.component";
import { NewsComponent } from "./components/news/news.component";
import { ServicesGuideInnerComponent } from "./components/services-guide-inner/services-guide-inner.component";
import { ServicesGuideComponent } from "./components/services-guide/services-guide.component";
// emirate pages
import { AboutusComponent } from "./components/emirate/aboutus/aboutus.component";
import { OrganizationChartComponent } from "./components/emirate/organization-chart/organization-chart.component";
import { RegionPrincesComponent } from "./components/emirate/region-princes/region-princes.component";
import { WomenSectionComponent } from "./components/emirate/women-section/women-section.component";
import { LatestNewsComponent } from "./components/latest-news/latest-news.component";
import { LatestNewsInnerComponent } from "./components/latest-news-inner/latest-news-inner.component";
import { OpenDataComponent } from "./components/open-data/open-data.component";
import { GovernorateShowComponent } from "./components/emirate/governorate-show/governorate-show.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent },
  { path: "home/news", component: NewsComponent },
  { path: "home/news/:id", component: NewsInnerComponent },
  { path: "home/services-guide", component: ServicesGuideComponent },
  { path: "home/services-guide/:id", component: ServicesGuideInnerComponent },
  { path: "home/latest-news", component: LatestNewsComponent},
  { path: "home/latest-news/:id", component: LatestNewsInnerComponent},
    { path: "open-data", component: OpenDataComponent },
  // emirate pages
  { path: "home/aboutus", component: AboutusComponent },
  { path: "home/regiion-princes", component: RegionPrincesComponent },
  { path: "home/governorate-show", component: GovernorateShowComponent },
  { path: "home/organization", component: OrganizationChartComponent },
  { path: "home/women-section", component: WomenSectionComponent },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
