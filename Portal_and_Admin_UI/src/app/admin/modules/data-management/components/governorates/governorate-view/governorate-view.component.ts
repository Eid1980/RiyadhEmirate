import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GlobalService } from "@shared/services/global.service";
import { GetGovernorateDetailsDto } from "@shared/proxy/governorates/models";
import { GovernorateService } from "@shared/proxy/governorates/governorate.service";

@Component({
  selector: 'app-governorate-view',
  templateUrl: './governorate-view.component.html'
})
export class GovernorateViewComponent implements OnInit {
  id: number;
  governorateDetailsDto = {} as GetGovernorateDetailsDto;

  constructor(private governorateService: GovernorateService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل المحافظة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/governorate-list");
    }
  }

  getDetails() {
    this.governorateService.getById(this.id).subscribe((response) => {
      this.governorateDetailsDto = response.data;
    });
  }
}
