import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';

@Component({
  selector: 'app-news-categuery-list',
  templateUrl: './news-categuery-list.component.html'
})
export class NewsCategueryListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private newsCategueryService: NewsCategueryService, private globalService: GlobalService) { }

  ngOnInit() {
    this.globalService.setAdminTitle('تصنيف الأخبار');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في تصنيف الأخبار',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/news-categuery-add',
      createButtonText: 'اضافة تصنيف خبر جديد',
      Url: this.newsCategueryService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
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
          routerLink: '/admin/data-management/news-categuery-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/news-categuery-view',
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
    this.newsCategueryService.changeStatus(id).subscribe((result) => {
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
    this.newsCategueryService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
