import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HomeService } from '@shared/proxy/home/home.service';
import { GetNewsSearchListDto } from '@shared/proxy/home/models';
import { GlobalService } from '@shared/services/global.service';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-news-search',
  templateUrl: './news-search.component.html'
})
export class NewsSearchComponent implements OnInit {
  currentLang: string;
  newsSearchListDto = [] as GetNewsSearchListDto[];
  filter: string;

  constructor(private homeService: HomeService, private globalService: GlobalService,
    private translateService: TranslationServiceService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    debugger;
    this.globalService.setTitle("البحث في الأخبار");
    this.currentLang = this.translateService.getCurrentLanguage().Name.toLowerCase();
    this.filter = this.activatedRoute.snapshot.paramMap.get("filter");
    if (this.filter) {
      this.homeService.getNewsSearch(this.filter).subscribe((response) => {
        this.newsSearchListDto = response.data;
      });
    }
  }

}
