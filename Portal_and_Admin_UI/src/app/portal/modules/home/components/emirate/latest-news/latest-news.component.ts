import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsListDto } from '@shared/proxy/latest-news/models';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';

@Component({
  selector: 'app-latest-news',
  templateUrl: './latest-news.component.html',
  styleUrls: ['./latest-news.component.scss']
})
export class LatestNewsComponent implements OnInit {

  latestNews =  [] as GetLatestNewsListDto[];

  newsTypeId : number

  constructor(private _latestNewService: LatestNewsService,
    private _activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.getLatestNews();

  }

  getLatestNews() {

    this._latestNewService
      .getByLang(true)
      .subscribe((result) => {
        this.latestNews = result.data;
      });
  }

}
