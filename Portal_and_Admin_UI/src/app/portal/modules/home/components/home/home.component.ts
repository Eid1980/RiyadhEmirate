import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { GetPosterDetailsDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { HomeService } from '@shared/proxy/home/home.service';
import { GetAllServiceListDto, GetNewsSearchListDto } from '@shared/proxy/home/models';
import { AuctionService } from '@shared/proxy/auctions/auction.service';
import { GetAuctionListDto } from '@shared/proxy/auctions/models';
declare let $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  currentLang: string;
  electronicUrl: string;
  searchModel: SearchModel = {};
  posters = [] as GetPosterDetailsDto[];
  auctions = [] as GetAuctionListDto[];

  latestNews = [] as GetNewsSearchListDto[];
  governorateNews: GetNewsSearchListDto[] = [];
  reports: GetNewsSearchListDto[] = [];

  internalServices = [] as GetAllServiceListDto[];
  internalServicesTop = [] as GetAllServiceListDto[];
  externalServices = [] as GetAllServiceListDto[];
  serviceGuidFirst = [] as GetAllServiceListDto[];
  serviceGuidLength = [];

  //#region Sliders Options
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
  bannerOptions: OwlOptions = {
    loop: true,
    autoplay: true,
    autoplayTimeout: 5000,
    autoplayHoverPause: true,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: true,
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
    nav: false,
  };
  //#endregion

  constructor(private homeService: HomeService, private posterService: PosterService,
    private auctionService: AuctionService, private _globalService: GlobalService,
    private translateService: TranslationServiceService) {
  }

  ngOnInit() {
    this._globalService.setTitle('الصفحة الرئيسية');
    this.currentLang = this.translateService.getCurrentLanguage().Name.toLowerCase();
    this.getPosters();
    this.getServices();
    this.getAllNews();
    this.getAuction();

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

  getPosters() {
    this.posterService.getAll().subscribe((res) => {
      this.posters = res.data;
    });
  }
  getServices() {
    this.homeService.getAllServices().subscribe(result => {
      this.electronicUrl = result.data.filter(i => i.id === 1)[0].requestLink;
      this.internalServices = result.data.filter(i => i.isExternal === false);
      this.externalServices = result.data.filter(i => i.isExternal === true);

      this.internalServicesTop = this.internalServices.slice(0, 4);
      this.serviceGuidLength = Array(Math.round(this.internalServices?.length / 2)).fill(1);
      this.serviceGuidFirst = this.internalServices.slice(0, 2);
    });
  }
  getAllNews() {
    this.homeService.getTop5NewsByLang(this.currentLang == 'ar').subscribe((result) => {
      let news = result.data as GetNewsSearchListDto[];
      this.latestNews = news.filter((n) => n.newsTypeId == NewsTypes.LatestNews);
      this.governorateNews = news.filter((n) => n.newsTypeId == NewsTypes.GovernorateNews);
      this.reports = news.filter((n) => n.newsTypeId == NewsTypes.Reports);
    });
  }
  getAuction() {
    this.auctionService.getAll().subscribe((res) => {
      this.auctions = res.data;
    });
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
