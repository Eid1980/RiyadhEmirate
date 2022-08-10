import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LatestNewsService } from '../../../services/latest-news.service';

@Component({
  selector: 'app-latest-news-view',
  templateUrl: './latest-news-view.component.html',
  styleUrls: ['./latest-news-view.component.scss'],
})
export class LatestNewsViewComponent implements OnInit {
  id: number;
  detailsVM: any;
  oldImage: any;

  constructor(
    private latestNewsService: LatestNewsService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getEdit(this.id);
    }
  }

  getEdit(newsId) {
    this.latestNewsService.getById(newsId).subscribe((response) => {
      this.detailsVM = response.data;
      this.oldImage = this.detailsVM.image;
    });
  }
}
