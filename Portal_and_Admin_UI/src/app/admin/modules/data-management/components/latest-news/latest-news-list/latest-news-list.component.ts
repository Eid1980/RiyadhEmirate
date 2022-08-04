import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnPipe } from '@shared/enums/column-pipe.enum';
import { ColumnType } from '@shared/enums/column-type.enum';
import { HelperFunctions } from '@shared/helpers/helper-functions';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { LatestNewsService } from '../../../services/latest-news.service';
import { ColumnPipeOptions } from '@shared/interfaces/column-pipe-options.interface';
import { CurrencyPipeOptions } from '@shared/models/currency-pipe-options.model';
import { DatePipeOptions } from '@shared/models/date-pipe-options.model';
import { NewsTypes } from '@shared/enums/news-types.enum';

@Component({
  selector: 'app-latest-news-list',
  templateUrl: './latest-news-list.component.html',
  styleUrls: ['./latest-news-list.component.scss'],
})
export class LatestNewsListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;

  constructor(private latestNewsService: LatestNewsService) {}

  ngOnInit() {
    this.pageSetting();
  }

  pageSetting() {
    this.list.searchModel .SearchFields = [
      {
        FieldName: "NewsTypeId",
        Operator: "Equal",
        Value: NewsTypes.LatestNews.toString()
      }
    ]

    this.pageListSettings = {
      PageTitle: 'قائمة أخر الأخبار',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/latest-news-add',
      createButtonText: 'انشاء خبر جديد',
      Url: this.latestNewsService.serviceUrl,

      cols: [
        { Field: 'Id', Header: 'الكود', Searchable: false, Hidden: true },
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
          Field: 'action',
          Header: 'الإجراءات',
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'تعديل',
          routerLink: '/admin/data-management/latest-news-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/latest-news-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
      ],
    };
  }

  changeStatus(id: number, e: any) {
    this.latestNewsService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }
}
