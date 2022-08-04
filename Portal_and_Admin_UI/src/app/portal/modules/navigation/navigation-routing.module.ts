import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CoreLayoutComponent } from '../core/components/core-layout/core-layout.component';
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
        path: 'eservice',
        loadChildren: () =>
          import('../eservice/eservice.module').then((x) => x.EServiceModule),
      },

      { path: '', redirectTo: 'home', pathMatch: 'full' },
    ],
    component: CoreLayoutComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule, CoreModule],
})
export class NavigationRoutingModule {}
