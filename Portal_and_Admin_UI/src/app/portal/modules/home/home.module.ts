import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ButtonModule } from 'primeng/button';
import { MessageModule } from 'primeng/message';
import { ToastModule } from 'primeng/toast';
import { CoreModule } from '../core/core.module';
import { HomeComponent } from './components/home/home.component';
import { HomeRoutingModule } from './home-routing.module';
@NgModule({
  declarations: [HomeComponent],
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
export class HomeModule {}
