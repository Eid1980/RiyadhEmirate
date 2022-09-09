import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-service-audience',
  templateUrl: './service-audience.component.html'
})
export class ServiceAudienceComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 1;
  id: number;

  constructor(
    private globalService: GlobalService,
    private activatedRoute: ActivatedRoute,)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('استكمال بيانات الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }


  getWizardItems() {
    this.wizardItems = [
      { label: 'البيانات الأساسية', url: `/data-management/service-edit/${this.id}` },
      { label: 'الجمهور المستهدف', url: `/data-management/service-audience/${this.id}` },
      { label: 'شروط ووثائق الخدمة', url: `/data-management/service-condition/${this.id}` }
    ];
  }

}
