import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { GetContactUsMessageDetailsDto } from '@shared/proxy/contact-us-messages/models';
import { ContactUsMessageService } from '@shared/proxy/contact-us-messages/contact-us-message.service';

@Component({
  selector: 'app-contact-us-message-list',
  templateUrl: './contact-us-message-list.component.html'
})
export class ContactUsMessageListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;
  showDialog: boolean = false;
  getContactUsMessageDetailsDto = {} as GetContactUsMessageDetailsDto;

  constructor(private contactUsMessageService: ContactUsMessageService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('طلبات تواصل معنا');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'طلبات تواصل معنا',
      listPermissionCode: '*',
      Url: this.contactUsMessageService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'fullName', Header: 'الاسم الكامل' },
        { Field: 'email', Header: 'البريد الإلكترونى' },
        { Field: 'contactUsMessageTypeName', Header: 'نوع الطلب' },
        { Field: 'title', Header: 'عنوان الرسالة' },
        { Field: 'content', Header: 'الرسالة' },
        {
          Field: 'Action',
          Header: 'الإجراءات',
          Searchable: false,
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
      this.contactUsMessageService.getById(id).subscribe((response) => {
        this.getContactUsMessageDetailsDto = response.data;
      });
      this.showDialog = true;
    }
  }
  changeStatus(id: number) {
    if (id) {
      this.contactUsMessageService.changeStatus(id).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.getContactUsMessageDetailsDto = {} as GetContactUsMessageDetailsDto;
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
    this.contactUsMessageService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}