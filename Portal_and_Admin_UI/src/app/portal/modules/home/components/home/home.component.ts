import { Component, HostListener, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { NewsService } from '@shared/proxy/news/news.service';
import {
  GetPosterDetailsDto
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
  serviceGuidLength:number = 2;

  serviceGuidesList: GetServiceListDto[] = [];

  serviceGuide: GetServiceListDto[] = [];

  isEven: boolean

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
    //this.getAllServiceGuide();

    let processNumber1 = document.getElementById("processNumber1");
    let processNumber2 = document.getElementById("processNumber2");
    let processNumber3 = document.getElementById("processNumber3");
    let processNumber4 = document.getElementById("processNumber4");

    this.animateValue(processNumber1, 0, 135.661, 5000);
    this.animateValue(processNumber2, 0, 22.123, 5000);
    this.animateValue(processNumber3, 0, 435, 5000);
    this.animateValue(processNumber4, 0, 89, 5000);
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
        this.serviceGuidesList = this.services
      });
  }

  getAllServiceGuide(){
    let searchModel : SearchModel = {

    }

    this._serviceService
    .getAllServiceGuide(searchModel)
    .subscribe((result) => {
      debugger
      this.serviceGuidesList = result.data.gridItemsVM;
    });

  }

  load(index){
    console.log('hi')
    debugger

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

  onCarouselSlide(index : number){
    this.isEven = index % 2 == 0;
    debugger
    console.log(this.isEven)
    this.serviceGuide = this.serviceGuidesList.slice(index * 2 , index * 2 + 2);
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
