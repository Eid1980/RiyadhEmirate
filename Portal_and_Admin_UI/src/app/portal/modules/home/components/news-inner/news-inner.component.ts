import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';

@Component({
  selector: 'app-news-inner',
  templateUrl: './news-inner.component.html',
  styleUrls: ['./news-inner.component.scss']
})
export class NewsInnerComponent implements OnInit {

  news = {} as GetNewsDetailsDto

  newsId : number

  constructor(private _newService: NewsService,
    private _activatedRoute: ActivatedRoute,
    ) { }

  ngOnInit(): void {
    this.newsId = this._activatedRoute.snapshot.params['id'];

    this.getNewsById();
  }

  getNewsById(){
    this._newService.getById(this.newsId).subscribe(
      (response) => {
        debugger
        this.news = response.data
      },
      (error) => {}
    )

  }
}
