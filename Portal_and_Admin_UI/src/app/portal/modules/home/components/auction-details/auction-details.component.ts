import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { AuctionService } from '@shared/proxy/auctions/auction.service';
import { GetAuctionDetailsDto } from '@shared/proxy/auctions/models';

@Component({
  selector: 'app-auction-details',
  templateUrl: './auction-details.component.html'
})
export class AuctionDetailsComponent implements OnInit {
  id: number;
  auctionDetailsDto = {} as GetAuctionDetailsDto;

  constructor(private auctionService: AuctionService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل المناقصة');
    let query = this.activatedRoute.snapshot.params['id'];
    if (query) {
      this.id = this.globalService.decryptNumber(query.toString());
      if (this.id) {
        this.getAuctionById();
      }
      else {
        this.globalService.navigate("/");
      }
    }
    else {
      this.globalService.navigate("/");
    }
  }

  getAuctionById() {
    this.auctionService.getById(this.id).subscribe((response) => {
      this.auctionDetailsDto = response.data;
      if (!this.auctionDetailsDto.isActive) {
        this.globalService.navigate("/");
      }
    });
  }
}
