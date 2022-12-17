import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { OpenDataRequestService } from '@shared/proxy/open-data-requests/open-data-request.service';
import { GetOpenDataRequestDetailsDto } from '@shared/proxy/open-data-requests/models';

@Component({
  selector: 'app-open-data-request-list',
  templateUrl: './open-data-request-list.component.html'
})
export class OpenDataRequestListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;
  showDialog: boolean = false;
  getOpenDataRequestDetailsDto = {} as GetOpenDataRequestDetailsDto;

  constructor(private openDataRequestService: OpenDataRequestService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('طلبات البيانات المفتوحة');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'طلبات البيانات المفتوحة',
      listPermissionCode: '*',
      Url: this.openDataRequestService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'fullName', Header: 'الاسم الكامل' },
        { Field: 'email', Header: 'البريد الإلكترونى' },
        { Field: 'title', Header: 'عنوان الرسالة' },
        { Field: 'content', Header: 'الرسالة' },
        {
          Field: 'Action',
          Header: 'الإجراءات',
          Searchable: false,
          Sortable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'الرد على الطلب',
          FuncName: (id) => this.preview(id),
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

  preview(id: number) {
    if (id) {
      this.openDataRequestService.getById(id).subscribe((response) => {
        this.getOpenDataRequestDetailsDto = response.data;
      });
      this.showDialog = true;
    }
  }
  changeStatus(id: number) {
    if (id) {
      this.openDataRequestService.changeStatus(id).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.getOpenDataRequestDetailsDto = {} as GetOpenDataRequestDetailsDto;
          this.showDialog = false;
          this.list.getData();
        }
      });
    }
  }

  delete(id: number) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.openDataRequestService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
