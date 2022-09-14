import { Component, OnInit } from '@angular/core';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsListDto } from '@shared/proxy/latest-news/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-latest-news',
  templateUrl: './latest-news.component.html'
})
export class LatestNewsComponent implements OnInit {
  latestNews =  [] as GetLatestNewsListDto[];

  constructor(private _latestNewService: LatestNewsService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle('أخر الأخبار');
    this.getLatestNews();
  }

  getLatestNews() {
    this._latestNewService.getByLang(true).subscribe((result) => {
      this.latestNews = result.data;
    });
  }

}
