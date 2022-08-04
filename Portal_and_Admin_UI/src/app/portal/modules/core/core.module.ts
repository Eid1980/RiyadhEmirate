import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreLayoutComponent } from './components/core-layout/core-layout.component';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { MenuComponent } from './components/menu/menu.component';
import { CoreRoutingModule } from './core-routing.module';
import { CarouselModule } from 'ngx-owl-carousel-o';

@NgModule({
  declarations: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
  ],
  imports: [CommonModule, CoreRoutingModule, CarouselModule],
  exports: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
    CarouselModule,
  ],
})
export class CoreModule {}
