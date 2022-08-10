import { Component, OnInit, ViewChild } from '@angular/core';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { ColumnType } from '@shared/enums/column-type.enum';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';

@Component({
  selector: 'app-list-poster',
  templateUrl: './list-poster.component.html'
})
export class ListPosterComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private posterService: PosterService,private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الاعلانات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: "قائمة الاعلانات",
      listPermissionCode: "*",
      createButtonLink: "/admin/data-management/poster-add",
      createButtonText: "انشاء  إعلان جديد",
      Url: this.posterService.serviceUrl,

      cols: [
        { Field: "id", Header: "الكود", Searchable: false, Hidden: true },
        { Field: "titleAr", Header: "العنوان عربي" },
        { Field: "titleEn", Header: "العنوان انجليزي" },
        { Field: "order", Header: "الترتيب" },
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
          routerLink: "/admin/data-management/poster-edit",
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: "التفاصيل",
          routerLink: "/admin/data-management/poster-view",
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
      ],
    };
  }

  changeStatus(id: number, e: any) {
    this.posterService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

}
