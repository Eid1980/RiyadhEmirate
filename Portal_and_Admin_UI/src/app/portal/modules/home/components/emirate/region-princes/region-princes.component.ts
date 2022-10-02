import { Component, OnInit } from '@angular/core';
import { EmiratesPrinceService } from '@shared/proxy/emirates-princes/emirates-prince.service';
import { GlobalService } from '@shared/services/global.service';
import { GetEmiratesPrinceListDto } from '@shared/proxy/emirates-princes/models';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-region-princes',
  templateUrl: './region-princes.component.html'
})
export class RegionPrincesComponent implements OnInit {
  emiratesPrinceListDto = [] as GetEmiratesPrinceListDto[];

  constructor(private emiratesPrinceService: EmiratesPrinceService, private globalService: GlobalService,
    public sanitizer: DomSanitizer)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('أمراء المنطقة');
    this.getEmiratesPrinceList();

  }
  getEmiratesPrinceList() {
    this.emiratesPrinceService.getAll().subscribe((response) => {
      this.emiratesPrinceListDto = response.data;
    });
  }

}
