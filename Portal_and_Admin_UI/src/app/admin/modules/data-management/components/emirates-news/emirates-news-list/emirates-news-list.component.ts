import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnPipe } from '@shared/enums/column-pipe.enum';
import { ColumnType } from '@shared/enums/column-type.enum';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { DatePipeOptions } from '@shared/models/date-pipe-options.model';
import { NewsService } from '@proxy/news/news.service';
import { NewsTypes } from '@shared/enums/news-types.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-emirates-news-list',
  templateUrl: './emirates-news-list.component.html'
})
export class EmiratesNewsListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;

  constructor(private newsService: NewsService, private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('اخبار المحافظات');
    this.pageSetting();
  }

  pageSetting() {

    this.list.searchModel.SearchFields = [
      {
        FieldName: "NewsTypeId",
        Operator: "Equal",
        Value: NewsTypes.EmiratesNews.toString()
      }
    ]

    this.pageListSettings = {
      PageTitle: "قائمة اخبار المحافظات",
      listPermissionCode: "*",
      createButtonLink: "/admin/data-management/emirates-news-add",
      createButtonText: "انشاء خبر جديد",
      Url: this.newsService.serviceUrl,

      cols: [
        { Field: "id", Header: "الكود", Searchable: false, Hidden: true },
        { Field: "titleAr", Header: "العنوان عربي" },
        { Field: "titleEn", Header: "العنوان انجليزي" },
        {
          Field: "date", Header: "التاريخ",
          Pipe: ColumnPipe.Date, PipeOptions: new DatePipeOptions()
        },
        {
          Field: "isActive",
          Header: "الحالة",
          Searchable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeStatus(id, event),
        },
        {
          Field: "Action",
          Header: "الإجراءات",
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: "تعديل",
          routerLink: "/admin/data-management/emirates-news-edit",
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: "التفاصيل",
          routerLink: "/admin/data-management/emirates-news-view",
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
    this.newsService.changeStatus(id).subscribe((result) => {
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
    this.newsService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.fileManagerService.deleteByEntityName(id, 'News').subscribe((res) => {
        });
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
