import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GlobalService } from "@shared/services/global.service";
import { NewsService } from "@shared/proxy/news/news.service";
import { GetNewsDetailsDto } from "@shared/proxy/news/models";

@Component({
  selector: 'app-latest-news-en-view',
  templateUrl: './latest-news-en-view.component.html'
})
export class LatestNewsEnViewComponent implements OnInit {
  id: number;
  newsDetailsDto = {} as GetNewsDetailsDto;

  constructor(private newsService: NewsService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الخبر');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/latest-news-en-list");
    }
  }

  getDetails() {
    this.newsService.getById(this.id).subscribe((response) => {
      this.newsDetailsDto = response.data;
      if (this.newsDetailsDto.isArabic) {
        this.globalService.navigate("/admin/data-management/latest-news-en-list");
      }
    });
  }
}
