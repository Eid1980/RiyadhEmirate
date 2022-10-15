import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetAuctionDetailsDto } from '@shared/proxy/auctions/models';
import { AuctionService } from '@shared/proxy/auctions/auction.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-auction-view',
  templateUrl: './auction-view.component.html'
})
export class AuctionViewComponent implements OnInit {
  id: number;
  auctionDetailsDto = {} as GetAuctionDetailsDto;

  constructor(private auctionService: AuctionService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل المناقصة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/auction-list");
    }
  }

  getDetails() {
    this.auctionService.getById(this.id).subscribe((response) => {
      this.auctionDetailsDto = response.data;
    });
  }
}
