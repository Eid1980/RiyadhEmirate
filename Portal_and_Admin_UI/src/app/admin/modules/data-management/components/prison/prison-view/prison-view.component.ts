import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetPrisonDetailsDto } from '@shared/proxy/prisons/models';
import { GlobalService } from '@shared/services/global.service';
import { PrisonService } from '@shared/proxy/prisons/prison.service';

@Component({
  selector: 'app-prison-view',
  templateUrl: './prison-view.component.html'
})
export class PrisonViewComponent implements OnInit {
  id: number;
  prisonDetailsDto = {} as GetPrisonDetailsDto;

  constructor(private prisonService: PrisonService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل السجن');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.prisonService.getById(this.id).subscribe((response) => {
      this.prisonDetailsDto = response.data;
    });
  }
}
