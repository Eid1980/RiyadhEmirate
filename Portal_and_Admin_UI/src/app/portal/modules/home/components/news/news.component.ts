import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.scss']
})
export class NewsComponent implements OnInit {

  latestNews: GetNewsDetailsDto[] = []

  newsTypeId : number

  constructor(private _newService: NewsService,
    private _activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    // Note: Below 'queryParams' can be replaced with 'params' depending on your requirements
    this._activatedRoute.queryParams.subscribe(params => {
      this.newsTypeId = params['newsTypeId'];
      this.getNewsByTypeId();
    });

  }

  getNewsByTypeId() {
    let searchModel: SearchModel = {
      SearchFields: [{
        FieldName: "NewsTypeId",
        Operator: "Equal",
        Value: this.newsTypeId.toString()//NewsTypes.LatestNews.toString()
      }]
    }

    this._newService
      .getListPage(searchModel)
      .subscribe((result) => {
        this.latestNews = result.data.gridItemsVM;
      });
  }

}
