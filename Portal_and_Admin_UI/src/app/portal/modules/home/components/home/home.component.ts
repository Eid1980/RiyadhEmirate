import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import {
  GetPosterDetailsDto,
  GetPosterListDto,
} from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { ApiResponse } from '@shared/proxy/shared/api-response.model';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
declare let $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  searchModel: SearchModel = {};

  news: GetNewsDetailsDto[] = [];
  emiratesNews: GetNewsDetailsDto[] = [];
  latestNews: GetNewsDetailsDto[] = [];
  reports: GetNewsDetailsDto[] = [];
  posters: GetPosterDetailsDto[] = [];
  services: GetServiceListDto[] = [];

  sliderOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };
  govNewsOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    items: 5,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 2,
      },
      740: {
        items: 3,
      },
      940: {
        items: 2,
      },
    },
    nav: true,
  };
  Details: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 2,
      },
      740: {
        items: 3,
      },
      940: {
        items: 4,
      },
    },
    nav: true,
  };
  newsOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };
  advertiseReportOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: true,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };

  servicesOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };

  servicesDetailsOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: true,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: false,
    animateOut: 'slideOutUp',
    animateIn: 'slideInUp'
  };

  constructor(
    private _newService: NewsService,
    private _serviceService: ServiceService,
    private _posterService: PosterService,
    private _globalService: GlobalService,
    public sanitizer: DomSanitizer
  ) { }

  ngOnInit() {
    this._globalService.setTitle('الصفحة الرئيسية');
    this.getAllNews();
    this.getServices();
    this.getPosters();
  }

  getAllNews() {
    this._newService
      .getAll()
      .subscribe((result: ApiResponse<GetNewsDetailsDto[]>) => {
        this.news = result.data;

        this.emiratesNews = this.getNewsByNewsTypeId(NewsTypes.EmiratesNews);

        this.latestNews = this.getNewsByNewsTypeId(NewsTypes.LatestNews);

        this.reports = this.getNewsByNewsTypeId(NewsTypes.Reports);
      });
  }

  getNewsByNewsTypeId(newsTypeId: number): GetNewsDetailsDto[] {
    return this.news.filter((n) => n.newsTypeId == newsTypeId);
  }

  getServices() {
    this._serviceService
      .getAll()
      .subscribe((result: ApiResponse<GetServiceListDto[]>) => {
        this.services = result.data;
      });
  }

  getPosters() {
    this._posterService.getAll().subscribe(
      (res: ApiResponse<GetPosterDetailsDto[]>) => {
        if (res.isSuccess) {
          this.posters = res.data;
        } else {
          // TODO
          // display error message
        }
      },
      (err) => { }
    );
  }

  navigateTo() {
    /*if (this._userService.currentUser.IsAdmin) {
      this._router.navigate(['/e-council/incoming-orders']);
    } else {
      this._router.navigate(['/e-council/create']);
    }*/
  }

  formatDate(date: any) {
    let newDate = new Date(date);
    var months = [
      'يناير',
      'فبراير',
      'مارس',
      'إبريل',
      'مايو',
      'يونيو',
      'يوليو',
      'أغسطس',
      'سبتمبر',
      'أكتوبر',
      'نوفمبر',
      'ديسمبر',
    ];
    let hijriDate = this._globalService.convertToHijri(newDate, 'ar');
    return (
      hijriDate.toString() +
      '     -     ' +
      newDate.getDay().toString() +
      ' ' +
      months[newDate.getMonth()] +
      ' ' +
      newDate.getFullYear().toString() +
      ' م '
    );
  }

  getHijriDate(date: any) {
    let newDate = new Date(date);
    let hijriDate = this._globalService.convertToHijri(newDate, 'ar');
    return hijriDate.toString();
  }
}
