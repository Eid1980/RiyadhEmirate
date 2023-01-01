import { Component, OnInit } from "@angular/core";
import { GlobalService } from "@shared/services/global.service";
import { HomeService } from "@shared/proxy/home/home.service";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
})
export class HomeComponent implements OnInit {
  serviceRequestsdata: any;
  data: any;

  constructor(private homeService: HomeService, private globalService: GlobalService)
  {
    
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الصفحة الرئيسية');
    this.homeService.getStatistics().subscribe(res => {
      const result = res.data;
      this.data = {
        labels: result.serviceRequests.map((obj) => obj.name),
        datasets: [{
          label: '# of Votes',
          data: result.serviceRequests.map((obj) => obj.count),
          borderWidth: 1
        }]
      };
    });
  }
}
