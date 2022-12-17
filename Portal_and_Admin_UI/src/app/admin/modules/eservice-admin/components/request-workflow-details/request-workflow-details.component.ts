import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-request-workflow-details',
  templateUrl: './request-workflow-details.component.html'
})
export class RequestWorkflowDetailsComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 0;
  requestId: string;
  @Input() nextUrl: string;
  @Input() printTitle: string;

  constructor(private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }

  getWizardItems() {
      this.wizardItems = [
        { label: 'بيانات الطلب'},
        { label: 'اتخاذ القرار'}
      ];
  }
}
