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
import { RegionGovComponent } from "./components/emirate/region-gov/region-gov.component";
import { RegionPrincesComponent } from "./components/emirate/region-princes/region-princes.component";
import { WomenSectionComponent } from "./components/emirate/women-section/women-section.component";
import { OpenDataComponent } from "./components/open-data/open-data.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent },
  { path: "news", component: NewsComponent },
  { path: "news/:id", component: NewsInnerComponent },
  { path: "services-guide", component: ServicesGuideComponent },
  { path: "services-guide/:id", component: ServicesGuideInnerComponent },

  // emirate pages
  { path: "emirate/aboutus", component: AboutusComponent },
  { path: "emirate/regiion-princes", component: RegionPrincesComponent },
  { path: "emirate/region-gov", component: RegionGovComponent },
  { path: "emirate/organization", component: OrganizationChartComponent },
  { path: "emirate/women-section", component: WomenSectionComponent },
  { path: "open-data", component: OpenDataComponent },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
