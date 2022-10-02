import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { EmiratesPrinceService } from '@shared/proxy/emirates-princes/emirates-prince.service';
import { GetEmiratesPrinceDetailsDto } from '@shared/proxy/emirates-princes/models';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-emirates-prince-view',
  templateUrl: './emirates-prince-view.component.html'
})
export class EmiratesPrinceViewComponent implements OnInit {
  id: number;
  emiratesPrinceDetailsDto = {} as GetEmiratesPrinceDetailsDto;

  constructor(private emiratesPrinceService: EmiratesPrinceService, public sanitizer: DomSanitizer,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل أمير المنطقة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.emiratesPrinceService.getById(this.id).subscribe((response) => {
      this.emiratesPrinceDetailsDto = response.data;
    });
  }
}
