import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreLayoutComponent } from './components/core-layout/core-layout.component';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { MenuComponent } from './components/menu/menu.component';
import { CoreRoutingModule } from './core-routing.module';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { SharedModule } from 'primeng/api';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
  ],
  imports: [CommonModule, CoreRoutingModule, CarouselModule,    SharedModule,
    ReactiveFormsModule,
    HttpClientModule],
  exports: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
    CarouselModule,
  ],
})
export class CoreModule {}
