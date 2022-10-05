import { Component, OnInit } from '@angular/core';
import { GetWomanSectionDto } from '@shared/proxy/woman-section/models';
import { WomanSectionService } from '@shared/proxy/woman-section/woman-section.service';

@Component({
  selector: 'app-women-section',
  templateUrl: './women-section.component.html',
  styleUrls: ['./women-section.component.scss']
})
export class WomenSectionComponent implements OnInit {

  womanSection = {} as GetWomanSectionDto

  constructor(private _womanSectionService: WomanSectionService) { }

  ngOnInit(): void {

    this.getWomanSection();
  }

  getWomanSection(){
    this. _womanSectionService.getAboutUs().subscribe(
      (response) => {
        this.womanSection = response.data
      },
      (error) => {}
    )
  }
}
