import { Component, OnInit } from '@angular/core';
import { GovernorateService } from '@shared/proxy/governorates/governorate.service';
import { GetGovernorateListDto } from '@shared/proxy/governorates/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-governorate-show',
  templateUrl: './governorate-show.component.html'
})
export class GovernorateShowComponent implements OnInit {
  governorateListDto = [] as GetGovernorateListDto[];

  constructor(private governorateService: GovernorateService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setTitle('المحافظات');
    this.getGovernorateList();
  }

  getGovernorateList() {
    this.governorateService.getAll().subscribe((response) => {
      this.governorateListDto = response.data;
    });
  }
}
