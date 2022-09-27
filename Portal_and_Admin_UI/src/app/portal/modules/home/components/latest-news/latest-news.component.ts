import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { PagingMetaData } from '@shared/models/paging-meta-data.model';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsListDto } from '@shared/proxy/latest-news/models';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-latest-news',
  templateUrl: './latest-news.component.html'
})
export class LatestNewsComponent implements OnInit {
  latestNews = [] as GetLatestNewsListDto[];

  firstPage: number;
  activePageNumber: number

  totalCount: number
  pageSize: number

  PAGESIZECONST: number = 12;

  searchModel = {} as SearchModel

  constructor(
    private _latestNewService: LatestNewsService,
    private _translateService: TranslationServiceService,
    private globalService: GlobalService) {
    this.firstPage = 1;
  }

  ngOnInit(): void {
    this.globalService.setTitle('أخر الأخبار');
    this.getLatestNews(this.firstPage);
  }

  getLatestNews(pageNumber) {
    /*if (pageNumber == this.activePageNumber)
      return*/

    this.searchModel = { PageNumber: pageNumber, PageSize: this.PAGESIZECONST }

    let isArabic = this._translateService.getCurrentLanguage().Name.toLowerCase() == 'ar';

    this._latestNewService.getByLang(isArabic, this.searchModel).subscribe((result: any) => {
      this.latestNews = result.data.gridItemsVM;

      let pagingMetaData: PagingMetaData = result.data.pagingMetaData;

      this.activePageNumber = pagingMetaData.pageNumber;

      this.totalCount = pagingMetaData.totalItemCount;
      this.pageSize = pagingMetaData.pageSize;
    });
  }

  /*getNextPage() {
    if (this.hasNext) {
      if (Math.round(this.totalCount / this.pageSize) > this.nextPageNumber) {
        this.hasPrevious = true;
        this.pageNumber = this.pageNumber + 1;
        this.nextPageNumber = this.nextPageNumber + 1
      }
    }
  }

  getPreviousPage() {
    if (this.hasPrevious) {
      if (this.pageNumber > 1) {
        this.pageNumber = this.pageNumber - 1;
        this.nextPageNumber = this.nextPageNumber - 1
      }
    }
  }*/

  paginate(event){
    this.getLatestNews(event.page + 1)
  }

}
