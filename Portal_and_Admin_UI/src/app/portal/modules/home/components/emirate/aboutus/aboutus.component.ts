import { Component, OnInit } from '@angular/core';
import { AboutUsService } from '@shared/proxy/about-us/about-us.service';
import { GetAboutUsDto } from '@shared/proxy/about-us/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-aboutus',
  templateUrl: './aboutus.component.html'
})
export class AboutusComponent implements OnInit {

  aboutUs = {} as GetAboutUsDto

  constructor(private aboutService: AboutUsService, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("عن الإمارة");
    this.getAboutUs();
  }

  getAboutUs(){
    this. aboutService.getAboutUs().subscribe(
      (response) => {
        this.aboutUs = response.data
      },
      (error) => {}
    )
  }

}
