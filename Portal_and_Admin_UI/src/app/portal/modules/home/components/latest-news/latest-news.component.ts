import { Component, OnInit } from '@angular/core';
import { PagingMetaData } from '@shared/models/paging-meta-data.model';
import { GetNewsListDto } from '@shared/proxy/news/models';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { HomeService } from '@shared/proxy/home/home.service';
import { NewsTypes } from '@shared/enums/news-types.enum';

@Component({
  selector: 'app-latest-news',
  templateUrl: './latest-news.component.html'
})
export class LatestNewsComponent implements OnInit {
  currentLang: string;
  latestNews = [] as GetNewsListDto[];

  firstPage: number;
  activePageNumber: number
  totalCount: number
  pageSize: number
  PAGESIZECONST: number = 10;
  searchModel = {} as SearchModel

  constructor(private homeService: HomeService, private translateService: TranslationServiceService,
    public globalService: GlobalService) {
    this.firstPage = 1;
  }

  ngOnInit(): void {
    this.globalService.setTitle('أخر الأخبار');
    this.currentLang = this.translateService.getCurrentLanguage().Name.toLowerCase();
    this.getLatestNews(this.firstPage);
  }

  getLatestNews(pageNumber) {
    let isArabic = this.currentLang == 'ar';
    this.searchModel = {
      PageNumber: pageNumber, PageSize: this.PAGESIZECONST,
      SearchFields: [
        {
          FieldName: "IsArabic",
          Operator: "Equal",
          Value: isArabic.toString()
        },
        {
          FieldName: "NewsTypeId",
          Operator: "Equal",
          Value: NewsTypes.LatestNews.toString()
        }
      ]
    }
    this.homeService.getAllNews(this.searchModel).subscribe((result: any) => {
      this.latestNews = result.data.gridItemsVM;
      let pagingMetaData: PagingMetaData = result.data.pagingMetaData;
      this.activePageNumber = pagingMetaData.pageNumber;
      this.totalCount = pagingMetaData.totalItemCount;
      this.pageSize = pagingMetaData.pageSize;
    });
  }
  paginate(event){
    this.getLatestNews(event.page + 1)
  }

}
