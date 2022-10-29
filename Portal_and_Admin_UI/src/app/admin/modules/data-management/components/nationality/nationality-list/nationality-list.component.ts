import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { NationalityService } from '@proxy/nationalities/nationality.service';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-nationality-list',
  templateUrl: './nationality-list.component.html'
})
export class NationalityListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private nationalityService: NationalityService, private globalService: GlobalService) { }

  ngOnInit() {
    this.globalService.setAdminTitle('الجنسيات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في الجنسيات',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/nationality-add',
      createButtonText: 'اضافة جنسية جديدة',
      Url: this.nationalityService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
        { Field: 'code', Header: 'كود الجنسية' },
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
          routerLink: '/admin/data-management/nationality-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/nationality-view',
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
    this.nationalityService.changeStatus(id).subscribe((result) => {
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
    this.nationalityService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
