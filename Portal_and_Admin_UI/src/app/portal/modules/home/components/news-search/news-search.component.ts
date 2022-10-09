import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HomeService } from '@shared/proxy/home/home.service';
import { GetNewsSearchListDto } from '@shared/proxy/home/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-news-search',
  templateUrl: './news-search.component.html'
})
export class NewsSearchComponent implements OnInit {
  newsSearchListDto = [] as GetNewsSearchListDto[];
  filter: string;

  constructor(private homeService: HomeService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle("البحث في الأخبار");
    this.filter = this.activatedRoute.snapshot.paramMap.get("filter");
    if (this.filter) {
      this.homeService.getNewsSearch(this.filter).subscribe((response) => {
        this.newsSearchListDto = response.data;
      });
    }
  }

}
