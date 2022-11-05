import { Component, OnInit } from '@angular/core';
import { AuctionService } from '@shared/proxy/auctions/auction.service';
import { GetAuctionListDto } from '@shared/proxy/auctions/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-auctions',
  templateUrl: './auctions.component.html'
})
export class AuctionsComponent implements OnInit {
  auctions = [] as GetAuctionListDto[];

  constructor(private auctionService: AuctionService, public globalService: GlobalService) { }

  ngOnInit(): void {
    this.globalService.setTitle('الإعلانات والمزادات والمناقصات');
    this.getAuction();
  }

  getAuction() {
    this.auctionService.getAll().subscribe((res) => {
      this.auctions = res.data;
    });
  }

}
