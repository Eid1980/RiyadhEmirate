import { Component, OnInit } from "@angular/core";
import { GlobalService } from "@shared/services/global.service";
import { HomeService } from "@shared/proxy/home/home.service";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
})
export class HomeComponent implements OnInit {
  serviceRequestsData: any;
  stageRequestsData: any;
  governorateRequestsData: any;
  userCount: number;
  requestCount: number;
  requestFinishedCount: number;
  achievePercent: number;
  requestElectronicBoardsCount: number;

  constructor(private homeService: HomeService, private globalService: GlobalService)
  {
    
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الصفحة الرئيسية');
    this.homeService.getStatistics().subscribe(res => {
      const result = res.data;
      this.userCount = result.userCount;
      this.requestCount = result.requestCount;
      this.requestFinishedCount = result.requestFinishedCount;
      this.requestElectronicBoardsCount = result.requestElectronicBoardsCount;
      this.achievePercent = this.requestFinishedCount / this.requestCount * 100;

      this.serviceRequestsData = {
        labels: result.serviceRequests.map((obj) => obj.name),
        datasets: [{
          label: 'طلبات المراحل',
          data: result.serviceRequests.map((obj) => obj.count),
          borderWidth: 1
        }]
      };

      this.stageRequestsData = {
        labels: result.stageRequests.map((obj) => obj.name),
        datasets: [{
          label: 'طلبات الخدمات',
          data: result.stageRequests.map((obj) => obj.count),
          borderWidth: 1
        }]
      };

      this.governorateRequestsData = {
        labels: result.governorateRequests.map((obj) => obj.name),
        datasets: [{
          label: 'طلبات المحافظات',
          data: result.governorateRequests.map((obj) => obj.count),
          fill: false,
          borderColor: 'rgb(75, 192, 192)',
          tension: 0.1
        }]
      };


    });
  }
}
