import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsDetailsDto } from '@shared/proxy/latest-news/models';

@Component({
  selector: 'app-latest-news-inner',
  templateUrl: './latest-news-inner.component.html',
  styleUrls: ['./latest-news-inner.component.scss']
})
export class LatestNewsInnerComponent implements OnInit {

  latestnews = {} as GetLatestNewsDetailsDto

  newsId : number

  constructor(private _latestNewsService: LatestNewsService,
    private _activatedRoute: ActivatedRoute,
    ) { }

  ngOnInit(): void {
    this.newsId = this._activatedRoute.snapshot.params['id'];
    this.getNewsById();
  }

  getNewsById(){
    this._latestNewsService.getById(this.newsId).subscribe(
      (response) => {
        this.latestnews = response.data
      },
      (error) => {}
    )

  }
}
