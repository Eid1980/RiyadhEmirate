import { Component, OnInit } from '@angular/core';
import { EmiratesPrinceService } from '@shared/proxy/emirates-princes/emirates-prince.service';
import { GlobalService } from '@shared/services/global.service';
import { GetEmiratesPrinceDetailsDto, GetEmiratesPrinceListDto } from '@shared/proxy/emirates-princes/models';

@Component({
  selector: 'app-region-princes',
  templateUrl: './region-princes.component.html'
})
export class RegionPrincesComponent implements OnInit {
  emiratesPrinceListDto = [] as GetEmiratesPrinceListDto[];
  emiratesPrinceDetailsDto = {} as GetEmiratesPrinceDetailsDto;
  showDialog: boolean = false;

  constructor(private emiratesPrinceService: EmiratesPrinceService, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('أمراء المنطقة');
    this.getEmiratesPrinceList();

  }
  getEmiratesPrinceList() {
    this.emiratesPrinceService.getAll().subscribe((response) => {
      this.emiratesPrinceListDto = response.data;
    });
  }

  showCv(id: number) {
    this.emiratesPrinceDetailsDto = {} as GetEmiratesPrinceDetailsDto;
    this.emiratesPrinceService.getById(id).subscribe((response) => {
      this.emiratesPrinceDetailsDto = response.data;
      this.showDialog = true;
    });
  }

}
