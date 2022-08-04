import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GlobalService } from "@shared/services/global.service";
import { NewsService } from "@proxy/news/news.service";
import { GetNewsDetailsDto } from "@proxy/news/models";

@Component({
  selector: "app-emirates-news-view",
  templateUrl: "./emirates-news-view.component.html"
})
export class EmiratesNewsViewComponent implements OnInit {
  id: number;
  newsDetailsDto = {} as GetNewsDetailsDto;

  constructor(private newsService: NewsService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الخبر');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/emirates-news-list");
    }
  }

  getDetails() {
    this.newsService.getById(this.id).subscribe((response) => {
      this.newsDetailsDto = response.data;
    });
  }
}
