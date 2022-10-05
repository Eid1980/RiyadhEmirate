import { Component, OnInit } from '@angular/core';
import { AboutUsService } from '@shared/proxy/about-us/about-us.service';
import { GetAboutUsDto } from '@shared/proxy/about-us/models';

@Component({
  selector: 'app-aboutus',
  templateUrl: './aboutus.component.html',
  styleUrls: ['./aboutus.component.scss']
})
export class AboutusComponent implements OnInit {

  aboutUs = {} as GetAboutUsDto

  constructor(private _aboutService: AboutUsService) { }

  ngOnInit(): void {

    this.getAboutUs();
  }

  getAboutUs(){
    this. _aboutService.getAboutUs().subscribe(
      (response) => {
        this.aboutUs = response.data
      },
      (error) => {}
    )
  }

}
