import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-request-workflow-action',
  templateUrl: './request-workflow-action.component.html'
})
export class RequestWorkflowActionComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 1;
  requestId: string;
  @Input() previousUrl: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.getWizardItems();
  }

  getWizardItems() {
    this.wizardItems = [
      { label: 'بيانات الطلب' },
      { label: 'اتخاذ القرار' }
    ];
  }

}
