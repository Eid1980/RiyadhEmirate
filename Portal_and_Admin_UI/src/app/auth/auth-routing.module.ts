import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './components/login/login.component';
import { ForgotPasswordComponent } from './components/forgot-password/forgot-password.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthLayoutComponent } from '@shared/components/auth-layout/auth-layout.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { IamLoginComponent } from './components/iam-login/iam-login.component';
import { CompleteDataComponent } from './components/complete-data/complete-data.component';
import { AdminLoginComponent } from './admin-login/admin-login.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'login',
        component: LoginComponent
      },
      {
        path: 'admin-login',
        component: AdminLoginComponent
      },
      {
        path: 'iam-login/:id',
        component: IamLoginComponent
      },
      {
        path: 'complete-data',
        component: CompleteDataComponent
      },
      //{
      //  path: 'forgot-password',
      //  component: ForgotPasswordComponent
      //},
      //{
      //  path: 'register',
      //  component: RegisterComponent
      //},

      {
        path: '', redirectTo: 'login', pathMatch: 'full'
      },
    ],
    component: AuthLayoutComponent,
  },
  {
    path: 'profile',
    children: [
      {
        path: 'user-profile',
        component: UserProfileComponent,
      },
    ],
    component: AuthLayoutComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AuthRoutingModule {}
