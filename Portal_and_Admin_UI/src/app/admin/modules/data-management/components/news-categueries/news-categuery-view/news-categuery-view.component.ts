import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetNewsCategueryDetailsDto } from '@shared/proxy/news-categueries/models';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-news-categuery-view',
  templateUrl: './news-categuery-view.component.html'
})
export class NewsCategueryViewComponent implements OnInit {
  id: number;
  newsCategueryDetailsDto = {} as GetNewsCategueryDetailsDto;

  constructor(private newsCategueryService: NewsCategueryService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل تصنيف الخبر');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.newsCategueryService.getById(this.id).subscribe((response) => {
      this.newsCategueryDetailsDto = response.data;
    });
  }
}
