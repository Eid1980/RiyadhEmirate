import { Component, OnInit } from "@angular/core";
import { GlobalService } from "@shared/services/global.service";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
})
export class HomeComponent implements OnInit {
  data: any;

  constructor(private globalService: GlobalService)
  {
    this.data = {
      labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
      datasets: [{
        label: '# of Votes',
        data: [12, 19, 3, 5, 2, 3],
        borderWidth: 1
      }]
    }
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الصفحة الرئيسية');
  }
}
