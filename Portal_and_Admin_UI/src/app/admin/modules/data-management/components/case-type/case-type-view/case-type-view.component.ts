import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CaseTypeService } from '@proxy/case-types/case-type.service';
import { GetCaseTypeDetailsDto } from '@proxy/case-types/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-case-type-view',
  templateUrl: './case-type-view.component.html'
})
export class CaseTypeViewComponent implements OnInit {
  id: number;
  caseTypeDetailsDto = {} as GetCaseTypeDetailsDto;

  constructor(private caseTypeService: CaseTypeService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل نوع القضية');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.caseTypeService.getById(this.id).subscribe((response) => {
      this.caseTypeDetailsDto = response.data;
    });
  }
}
