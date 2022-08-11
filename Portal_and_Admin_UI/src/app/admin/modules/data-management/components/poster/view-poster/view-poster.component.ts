import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { GetPosterDetailsDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-view-poster',
  templateUrl: './view-poster.component.html'
})
export class ViewPosterComponent implements OnInit {
  id: number;
  posterDetailsDto = {} as GetPosterDetailsDto;

  constructor(private posterService: PosterService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService,
    public sanitizer: DomSanitizer
    ) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الاعلان');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/poster-list");
    }
  }

  getDetails() {
    this.posterService.getById(this.id).subscribe((response) => {
      this.posterDetailsDto = response.data;
    });
  }
}
