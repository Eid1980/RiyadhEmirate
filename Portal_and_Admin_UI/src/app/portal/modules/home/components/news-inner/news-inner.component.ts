import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-news-inner',
  templateUrl: './news-inner.component.html'
})
export class NewsInnerComponent implements OnInit {

  news = {} as GetNewsDetailsDto

  newsId : number

  constructor(private _newService: NewsService,
    private _activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل الخبر');
    this.newsId = this._activatedRoute.snapshot.params['id'];
    this.getNewsById();
  }

  getNewsById(){
    this._newService.getById(this.newsId).subscribe(
      (response) => {
        this.news = response.data
      },
      (error) => {}
    )

  }
}
