import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { HomeComponent } from "./components/home/home.component";

const routes: Routes = [
  { path: "", component: HomeComponent, canActivate: [AuthGuard] },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule {}
