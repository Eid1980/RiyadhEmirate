import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ColumnType } from '@shared/enums/column-type.enum';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { RequestAttachmentTypeService } from '@proxy/request-attachment-types/request-attachment-type.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-request-attachment-type-list',
  templateUrl: './request-attachment-type-list.component.html'
})
export class RequestAttachmentTypeListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private requestAttachmentTypeService: RequestAttachmentTypeService, private globalService: GlobalService) { }

  ngOnInit() {
    this.globalService.setAdminTitle('مرفقات الخدمات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في مرفقات الخدمات',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/request-attachment-type-add',
      createButtonText: 'اضافة مرفق خدمة جديد',
      Url: this.requestAttachmentTypeService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
        { Field: 'serviceName', Header: 'الخدمة' },
        {
          Field: 'isRequired',
          Header: 'المرفق مطلوب ادخالة',
          Searchable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeRequire(id, event),
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
          routerLink: '/admin/data-management/request-attachment-type-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/request-attachment-type-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
      ],
    };
  }

  changeStatus(id: number, e: any) {
    this.requestAttachmentTypeService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }
  changeRequire(id: number, e: any) {
    this.requestAttachmentTypeService.changeRequire(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

}
