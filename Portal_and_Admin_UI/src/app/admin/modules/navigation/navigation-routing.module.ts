import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CoreLayoutComponent } from '../core/components/core-layout/core-layout.component';
import { SharedModule } from '@shared/shared.module';
import { CoreModule } from '../core/core.module';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'home',
        loadChildren: () =>
          import('../home/home.module').then((x) => x.HomeModule),
      },
      {
        path: 'data-management',
        loadChildren: () =>
          import('../data-management/data-management.module').then(
            (x) => x.DataManagementModule
          ),
      },
      {
        path: 'eservice-admin',
        loadChildren: () =>
          import('../eservice-admin/eservice-admin.module').then(
            (x) => x.EServiceAdminModule
          ),
      },

      { path: '', redirectTo: 'home', pathMatch: 'full' },
    ],
    component: CoreLayoutComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class NavigationRoutingModule {}
