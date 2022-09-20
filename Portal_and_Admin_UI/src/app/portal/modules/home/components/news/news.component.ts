import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PagingMetaData } from '@shared/models/paging-meta-data.model';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html'
})
export class NewsComponent implements OnInit {
  latestNews: GetNewsDetailsDto[] = []
  newsTypeId: number
  title = "اخبار المحافظات" as string;


  firstPage: number;
  activePageNumber: number

  totalCount: number
  pageSize: number

  PAGESIZECONST: number = 3;

  searchModel = {} as SearchModel

  constructor(private _newService: NewsService, private globalService: GlobalService,
    private _activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    // Note: Below 'queryParams' can be replaced with 'params' depending on your requirements
    this._activatedRoute.queryParams.subscribe(params => {
      this.newsTypeId = params['newsTypeId'];
      if (this.newsTypeId) {
        this.getNewsByTypeId(this.firstPage);
        if (this.newsTypeId == 2) {
          this.title = "اخبار المحافظات";
          this.globalService.setTitle(this.title);
        }
        else if (this.newsTypeId == 3) {
          this.title = "التقارير الإعلامية";
          this.globalService.setTitle(this.title);
        }
      }
      else {
        this.globalService.navigate("/");
      }
    });

  }

  getNewsByTypeId(pageNumber) {
    let searchModel: SearchModel = {
      SearchFields: [{
        FieldName: "NewsTypeId",
        Operator: "Equal",
        Value: this.newsTypeId.toString()//NewsTypes.LatestNews.toString()
      }],

      PageNumber: pageNumber,
      PageSize: this.PAGESIZECONST
    }

    this._newService
      .getListPage(searchModel)
      .subscribe((result) => {
        this.latestNews = result.data.gridItemsVM;


        let pagingMetaData: PagingMetaData = result.data.pagingMetaData;

        this.activePageNumber = pagingMetaData.pageNumber;

        this.totalCount = pagingMetaData.totalItemCount;
        this.pageSize = pagingMetaData.pageSize;
      });
  }

  paginate(event) {
    debugger
    this.getNewsByTypeId(event.page + 1)
  }
}
