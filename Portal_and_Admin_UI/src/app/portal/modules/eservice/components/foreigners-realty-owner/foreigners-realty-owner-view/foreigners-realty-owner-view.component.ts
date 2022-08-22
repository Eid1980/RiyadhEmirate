import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-foreigners-realty-owner-view',
  templateUrl: './foreigners-realty-owner-view.component.html'
})
export class ForeignersRealtyOwnerViewComponent implements OnInit {
  requestId: string;

  constructor(private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("خدمة تملك عقار للأجانب");
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }

}
