import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsListDto } from '@shared/proxy/latest-news/models';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import { GetPosterDetailsDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { ApiResponse } from '@shared/proxy/shared/api-response.model';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { HomeService } from '@shared/proxy/home/home.service';
import { GetAllServiceListDto } from '@shared/proxy/home/models';
declare let $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  searchModel: SearchModel = {};

  news: GetNewsDetailsDto[] = [];
  emiratesNews: GetNewsDetailsDto[] = [];
  latestNews = [] as GetLatestNewsListDto[];
  reports: GetNewsDetailsDto[] = [];
  posters: GetPosterDetailsDto[] = [];

  internalServices = [] as GetAllServiceListDto[];
  internalServicesTop = [] as GetAllServiceListDto[];
  externalServices = [] as GetAllServiceListDto[];
  serviceGuidFirst = [] as GetAllServiceListDto[];
  serviceGuidLength = [];

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
      740: {
        items: 3,
      },
      940: {
        items: 4,
      }
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

  constructor(private _newService: NewsService, private _latestNewsService: LatestNewsService,
    private _posterService: PosterService, private _globalService: GlobalService, private homeService: HomeService,
    private _translateService: TranslationServiceService, public sanitizer: DomSanitizer)
  {
  }

  ngOnInit() {
    this._globalService.setTitle('الصفحة الرئيسية');
    this.getAllNews();
    this.getServices();
    this.getPosters();
    this.getLatestNews();

    let processNumber1 = document.getElementById("processNumber1");
    let processNumber2 = document.getElementById("processNumber2");
    let processNumber3 = document.getElementById("processNumber3");
    let processNumber4 = document.getElementById("processNumber4");

    this.homeService.getCounts().subscribe(result => {
      this.animateValue(processNumber1, 0, result.data.userCount, 5000);
      this.animateValue(processNumber2, 0, result.data.serviceCount, 5000);
      this.animateValue(processNumber3, 0, result.data.requestCount, 5000);
      this.animateValue(processNumber4, 0, result.data.rateCount, 5000);
    });
  }

  getAllNews() {
    this._newService.getAll().subscribe((result) => {
      this.news = result.data;
      this.emiratesNews = this.getNewsByNewsTypeId(NewsTypes.EmiratesNews);
      this.reports = this.getNewsByNewsTypeId(NewsTypes.Reports);
    });
  }

  getNewsByNewsTypeId(newsTypeId: number): GetNewsDetailsDto[] {
    return this.news.filter((n) => n.newsTypeId == newsTypeId);
  }

  getServices() {
    this.homeService.getAllServices().subscribe(result => {
      this.internalServices = result.data.filter(i => i.isExternal === false);
      this.externalServices = result.data.filter(i => i.isExternal === true);

      this.internalServicesTop = this.internalServices.slice(0, 4);
      this.serviceGuidLength = Array(Math.round(this.internalServices?.length / 2)).fill(1);
      this.serviceGuidFirst = this.internalServices.slice(0, 2);
    });
  }

  getLatestNews() {
    let isArabic = this._translateService.getCurrentLanguage().Name.toLowerCase() == 'ar';
    this._latestNewsService
      .getByLangTop5(isArabic)
      .subscribe((result) => {
        this.latestNews = result.data;
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
    debugger;
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

  animateValue(obj: any, start: any, end: any, duration: any) {
    let startTimestamp = null;
    let step = (timestamp: any) => {
      if (!startTimestamp) startTimestamp = timestamp;
      let progress = Math.min((timestamp - startTimestamp) / duration, 1);
      obj.innerHTML = Math.floor(progress * (end - start) + start);
      if (progress < 1) {
        window.requestAnimationFrame(step);
      }
    };
    console.log(step)
    window.requestAnimationFrame(step);
  }
}
