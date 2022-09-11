import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GlobalService } from "@shared/services/global.service";
import { DomSanitizer } from "@angular/platform-browser";
import { LatestNewsService } from "@shared/proxy/latest-news/latest-news.service";
import { GetLatestNewsDetailsDto } from "@shared/proxy/latest-news/models";

@Component({
  selector: 'app-latest-news-ar-view',
  templateUrl: './latest-news-ar-view.component.html'
})
export class LatestNewsArViewComponent implements OnInit {
  id: number;
  newsDetailsDto = {} as GetLatestNewsDetailsDto;

  constructor(private latestNewsService: LatestNewsService, private activatedRoute: ActivatedRoute,
    public sanitizer: DomSanitizer,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الخبر');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/latest-news-ar-list");
    }
  }

  getDetails() {
    this.latestNewsService.getById(this.id).subscribe((response) => {
      this.newsDetailsDto = response.data;
      if (!this.newsDetailsDto.isArabic) {
        this.globalService.navigate("/admin/data-management/latest-news-ar-list");
      }
    });
  }
}
