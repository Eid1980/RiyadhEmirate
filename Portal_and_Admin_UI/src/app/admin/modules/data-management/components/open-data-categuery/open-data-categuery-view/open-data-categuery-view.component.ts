import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OpenDataCategueryService } from '@proxy/open-data-categueries/open-data-categuery.service';
import { GetOpenDataCategueryDetailsDto } from '@proxy/open-data-categueries/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-open-data-categuery-view',
  templateUrl: './open-data-categuery-view.component.html'
})
export class OpenDataCategueryViewComponent implements OnInit {
  id: number;
  openDataCategueryDetailsDto = {} as GetOpenDataCategueryDetailsDto;

  constructor(private openDataCategueryService: OpenDataCategueryService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل المجموعة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.openDataCategueryService.getById(this.id).subscribe((response) => {
      this.openDataCategueryDetailsDto = response.data;
    });
  }
}
