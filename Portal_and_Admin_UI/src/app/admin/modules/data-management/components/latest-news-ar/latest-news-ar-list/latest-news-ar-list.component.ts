import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnPipe } from '@shared/enums/column-pipe.enum';
import { ColumnType } from '@shared/enums/column-type.enum';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { DatePipeOptions } from '@shared/models/date-pipe-options.model';
import { GlobalService } from '@shared/services/global.service';
import { FileManagerService } from '@shared/services/file-manager.service';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';

@Component({
  selector: 'app-latest-news-ar-list',
  templateUrl: './latest-news-ar-list.component.html'
})
export class LatestNewsArListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;

  constructor(private latestNewsService: LatestNewsService, private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('أخر الأخبار عربي');
    this.pageSetting();
  }

  pageSetting() {
    this.list.searchModel.SearchFields = [
      {
        FieldName: "IsArabic",
        Operator: "Equal",
        Value: "true"
      }
    ]

    this.pageListSettings = {
      PageTitle: 'قائمة أخر الأخبار عربي',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/latest-news-ar-add',
      createButtonText: 'انشاء خبر عربي جديد',
      Url: this.latestNewsService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'title', Header: 'عنوان الخبر' },
        { Field: 'newsCategueryName', Header: 'التصنيف' },
        { Field: 'newsOrigin', Header: 'المصدر' },
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
          Field: 'openComments',
          Header: 'التعليقات',
          Searchable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changecommentStatus(id, event),
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
          routerLink: '/admin/data-management/latest-news-ar-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/latest-news-ar-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: 'حذف',
          FuncName: (id) => this.delete(id),
          buttonclass: ActionButtonClass.Delete,
          buttonIcon: ActionButtonIcon.Delete,
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

  changecommentStatus(id: number, e: any) {
    this.latestNewsService.changecommentStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

  delete(id: number) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.latestNewsService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.fileManagerService.deleteByEntityName(id, 'LatestNews').subscribe((res) => {
        });
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
