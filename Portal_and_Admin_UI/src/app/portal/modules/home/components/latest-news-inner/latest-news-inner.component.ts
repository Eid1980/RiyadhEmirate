import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsDetailsDto } from '@shared/proxy/latest-news/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-latest-news-inner',
  templateUrl: './latest-news-inner.component.html'
})
export class LatestNewsInnerComponent implements OnInit {
  latestnews = {} as GetLatestNewsDetailsDto;
  newsId: number;

  constructor(private _latestNewsService: LatestNewsService, private globalService: GlobalService,
    private _activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل الخبر');
    this.newsId = this._activatedRoute.snapshot.params['id'];
    if (this.newsId) {
      this.getNewsById();
    }
    else {
      this.globalService.navigate("/home/latest-news");
    }
  }

  getNewsById(){
    this._latestNewsService.getById(this.newsId).subscribe((response) => {
      this.latestnews = response.data
    });
  }
}
