import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnPipe } from '@shared/enums/column-pipe.enum';
import { ColumnType } from '@shared/enums/column-type.enum';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { DatePipeOptions } from '@shared/models/date-pipe-options.model';
import { ReportsService } from '../../../services/reports.service';

@Component({
  selector: 'app-reports-list',
  templateUrl: './reports-list.component.html',
  styleUrls: ['./reports-list.component.scss'],
})
export class ReportsListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;

  constructor(private reportsService: ReportsService) {}

  ngOnInit() {
    this.pageSetting();
  }

  pageSetting() {

    this.list.searchModel .SearchFields = [
      {
        FieldName: "NewsTypeId",
        Operator: "Equal",
        Value: NewsTypes.Reports.toString()
      }
    ]

    this.pageListSettings = {
      PageTitle: 'قائمة التقارير الإعلانية',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/reports-add',
      createButtonText: 'انشاء تقرير جديد',
      Url: this.reportsService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'titleAr', Header: 'العنوان باللغة العربية' },
        { Field: 'titleEn', Header: 'العنوان باللغة الانجليزية' },
        {
          Field: 'date',
          Header: 'التاريخ',
          Pipe: ColumnPipe.Date,
          PipeOptions: new DatePipeOptions(),
        },
        {
          Field: 'isActive',
          Header: 'الحالة',
          Searchable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeStatus(id, event),
        },
        {
          Field: 'Action',
          Header: 'الإجراءات',
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'تعديل',
          routerLink: '/admin/data-management/reports-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/reports-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
      ],
    };
  }

  changeStatus(id: number, e: any) {
    this.reportsService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }
}
