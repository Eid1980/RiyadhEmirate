import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ColumnType } from '@shared/enums/column-type.enum';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { GlobalService } from '@shared/services/global.service';
import { RequestTypeService } from '@proxy/request-types/request-type.service';

@Component({
  selector: 'app-request-type-list',
  templateUrl: './request-type-list.component.html',
})
export class RequestTypeListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(
    private requestTypeService: RequestTypeService,
    private globalService: GlobalService
  ) {}

  ngOnInit() {
    this.globalService.setAdminTitle('أنواع الخدمات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في أنواع الخدمات',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/request-type-add',
      createButtonText: 'اضافة نوع خدمة جديد',
      Url: this.requestTypeService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
        { Field: 'serviceName', Header: 'الخدمة' },
        {
          Field: 'isActive',
          Header: 'الحالة',
          Searchable: false,
          Sortable: false,
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
          routerLink: '/admin/data-management/request-type-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/request-type-view',
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
    this.requestTypeService.changeStatus(id).subscribe((result) => {
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
    this.requestTypeService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
