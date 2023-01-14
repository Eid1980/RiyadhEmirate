import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { GlobalService } from '@shared/services/global.service';
import { ServieNotificationService } from '@shared/proxy/servie-notifications/servie-notification.service';
import { GetServieNotificationLogListDto } from '@shared/proxy/servie-notifications/models';

@Component({
  selector: 'app-servie-notification-sms-list',
  templateUrl: './servie-notification-sms-list.component.html'
})
export class ServieNotificationSmsListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;
  showLogDialog: boolean = false;
  servieNotificationLogListDto = [] as GetServieNotificationLogListDto[];

  constructor(private servieNotificationService: ServieNotificationService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('اعدادات الرسائل النصية');
    this.pageSetting();
  }

  pageSetting() {
    this.list.searchModel.SearchFields = [
      {
        FieldName: "IsSMS",
        Operator: "Equal",
        Value: "true"
      }
    ];

    this.pageListSettings = {
      PageTitle: 'قائمة الرسائل النصية',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/servie-notification-sms-add',
      createButtonText: 'انشاء رسالة نصية جديدة',
      Url: this.servieNotificationService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'serviceName', Header: 'الخدمة' },
        { Field: 'stageName', Header: 'المرحلة' },
        { Field: 'message', Header: 'نص الرسالة' },
        {
          Field: 'isActive',
          Header: 'الحالة',
          Searchable: false,
          Sortable: false,
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
          title: 'أرشيف النصوص',
          FuncName: (id) => this.previewmessages(id),
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.Roles,
        },
        {
          title: 'تعديل',
          routerLink: '/admin/data-management/servie-notification-sms-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/servie-notification-sms-view',
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

  previewmessages(id: number) {
    if (id) {
      this.servieNotificationService.getServieNotificationLog(id).subscribe((response) => {
        this.servieNotificationLogListDto = response.data;
      });
      this.showLogDialog = true;
    }
  }
  closeRolesDialog() {
    this.servieNotificationLogListDto = [];
    this.showLogDialog = false;
  }

  changeStatus(id: number, e: any) {
    this.servieNotificationService.changeStatus(id).subscribe((result) => {
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
    this.servieNotificationService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
