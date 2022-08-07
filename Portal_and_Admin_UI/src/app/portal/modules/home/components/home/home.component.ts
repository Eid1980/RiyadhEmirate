import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { NewsService } from '@shared/proxy/news/news.service';
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
  searchModel: SearchModel = {};

  posters: any[] = [];
  emiratesNews: any[] = [];
  latestNews: any[] = [];
  reports: any[] = [];
  services: any[] = [];

  constructor(
    private _newService: NewsService,
    private _globalService: GlobalService,
    private _router: Router
  ) {}

  ngOnInit() {
    this.getPosters();
    this.getEmiratesNews();
    this.getLatestNews();
    this.getReports();
    this.getServices();
  }

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
    },
    nav: true,
  };
  govNewsOptions: OwlOptions = {
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

  getPosters() {
    this.searchModel.SearchFields = [
      {
        FieldName: 'NewsTypeId',
        Operator: 'Equal',
        Value: NewsTypes.Posters.toString(),
      },
    ];

    this._newService.getAll(NewsTypes.Posters).subscribe((result: any) => {
      debugger;
      this.posters = result.data;
      console.log('posters');
      console.log(this.posters);
    });
  }

  getEmiratesNews() {
    this.searchModel.SearchFields = [
      {
        FieldName: 'NewsTypeId',
        Operator: 'Equal',
        Value: NewsTypes.EmiratesNews.toString(),
      },
    ];

    this._newService.getAll(NewsTypes.EmiratesNews).subscribe((result: any) => {
      debugger;
      this.emiratesNews = result.data;
    });
  }

  getLatestNews() {
    this.searchModel.SearchFields = [
      {
        FieldName: 'NewsTypeId',
        Operator: 'Equal',
        Value: NewsTypes.LatestNews.toString(),
      },
    ];

    this._newService.getAll(NewsTypes.LatestNews).subscribe((result: any) => {
      this.latestNews = result.data;
    });
  }

  getReports() {
    this._newService.getAll(NewsTypes.LatestNews).subscribe((result: any) => {
      this.reports = result.data;
    });
  }

  getServices() {
    this.searchModel.SearchFields = [
      {
        FieldName: 'NewsTypeId',
        Operator: 'Equal',
        Value: NewsTypes.Posters.toString(),
      },
    ];

    this._newService.getAll(NewsTypes.Posters).subscribe((result: any) => {
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
