import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { ServiceService } from '@shared/proxy/services/service.service';
import { ApiResponse } from '@shared/proxy/shared/api-response.model';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
declare let $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {

  searchModel : SearchModel = {} ;

  news : GetNewsDetailsDto[] = [];
  posters: GetNewsDetailsDto[] = [];
  emiratesNews: GetNewsDetailsDto[] = [];
  latestNews: GetNewsDetailsDto[] = [];
  reports: GetNewsDetailsDto[] = [];
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
        items: 2,
      },
    },
    nav: true,
  };
  govNewsOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    items : 5,
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
        items: 2,
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
    },
    nav: true,
  };

  constructor(
    private _newService : NewsService,
    private _serviceService : ServiceService,
    private _globalService: GlobalService,
    private _router: Router) {
    }

  ngOnInit() {

    this.getAllNews();
    this.getServices();

  }

  getAllNews() {
    this._newService.getAll().subscribe((result: ApiResponse<GetNewsDetailsDto[]>) => {
      this.news = result.data;

      this.posters = this.getNewsByNewsTypeId(NewsTypes.Posters);

      this.emiratesNews = this.getNewsByNewsTypeId(NewsTypes.EmiratesNews);

      this.latestNews = this.getNewsByNewsTypeId(NewsTypes.LatestNews);

      this.reports = this.getNewsByNewsTypeId(NewsTypes.Posters);
    });
  }

  getNewsByNewsTypeId(newsTypeId : number): GetNewsDetailsDto[] {
    return this.posters = this.news.filter(n => n.newsTypeId == newsTypeId);
  }

  getServices() {
    this._serviceService.getAll().subscribe((result: ApiResponse<GetServiceListDto[]>) => {
      this.services = result.data;
    });
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
