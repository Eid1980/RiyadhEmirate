import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { HomeComponent } from "./components/home/home.component";
import { RoleAddComponent } from "./components/permission/role-add/role-add.component";
import { RoleEditComponent } from "./components/permission/role-edit/role-edit.component";
import { RoleListComponent } from "./components/permission/role-list/role-list.component";
import { RoleViewComponent } from "./components/permission/role-view/role-view.component";
import { UserAddComponent } from "./components/permission/user-add/user-add.component";
import { UserListComponent } from "./components/permission/user-list/user-list.component";
import { UserRoleAddComponent } from "./components/permission/user-role-add/user-role-add.component";

const routes: Routes = [
  //#region Permission
  {
    path: "role-add",
    component: RoleAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "role-edit/:id",
    component: RoleEditComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "role-list",
    component: RoleListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "role-view/:id",
    component: RoleViewComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "user-add",
    component: UserAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "user-list",
    component: UserListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: "user-role-add/:id",
    component: UserRoleAddComponent,
    canActivate: [AuthGuard],
  },
  //#endregion

  { path: "", component: HomeComponent, canActivate: [AuthGuard] },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
