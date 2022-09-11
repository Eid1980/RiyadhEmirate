import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { LatestNewsService } from 'src/app/admin/modules/data-management/services/latest-news.service';

@Component({
  selector: 'app-latest-news',
  templateUrl: './latest-news.component.html',
  styleUrls: ['./latest-news.component.scss']
})
export class LatestNewsComponent implements OnInit {

  latestNews: GetNewsDetailsDto[] = []

  newsTypeId : number

  constructor(private _latestNewService: LatestNewsService,
    private _activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.getLatestNews();

  }

  getLatestNews() {
    debugger
    let searchModel: SearchModel = {
    }

    this._latestNewService
      .getListPage(searchModel)
      .subscribe((result) => {
        this.latestNews = result.data.gridItemsVM;
      });
  }

}
