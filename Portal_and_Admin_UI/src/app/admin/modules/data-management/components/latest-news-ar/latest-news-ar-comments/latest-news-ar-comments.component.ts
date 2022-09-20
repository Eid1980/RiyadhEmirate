import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { GlobalService } from '@shared/services/global.service';
import { FileManagerService } from '@shared/services/file-manager.service';
import { LatestNewsCommentService } from '@shared/proxy/latest-news-comments/latest-news-comment.service';
import { GetLatestNewsCommentDetailsDto, UpdateLatestNewsCommentDto } from '@shared/proxy/latest-news-comments/models';

@Component({
  selector: 'app-latest-news-ar-comments',
  templateUrl: './latest-news-ar-comments.component.html'
})
export class LatestNewsArCommentsComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  checked: true;
  showDialog: boolean = false;
  getLatestNewsCommentDetailsDto = {} as GetLatestNewsCommentDetailsDto;

  constructor(private latestNewsCommentService: LatestNewsCommentService, private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعليقات أخر الأخبار عربي');
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
      PageTitle: 'تعليقات أخر الأخبار عربي',
      listPermissionCode: '*',
      Url: this.latestNewsCommentService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'createdByName', Header: 'الاسم' },
        { Field: 'email', Header: 'البريد الالكتروني' },
        { Field: 'comment', Header: 'التعليق' },
        { Field: 'commentStageName', Header: 'مرحلة التعليق' },
        { Field: 'createdDate', Header: 'تاريخ التعليق' },
        {
          Field: 'action',
          Header: 'الإجراءات',
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'القرار',
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
      this.latestNewsCommentService.getById(id).subscribe((response) => {
        this.getLatestNewsCommentDetailsDto = response.data;
      });
      this.showDialog = true;
    }
  }
  updateCommentStage(stageId: number) {
    if (stageId) {
      const updateLatestNewsCommentDto = { commentStageId: stageId, id: this.getLatestNewsCommentDetailsDto.id } as UpdateLatestNewsCommentDto;
      this.latestNewsCommentService.update(updateLatestNewsCommentDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.getLatestNewsCommentDetailsDto = {} as GetLatestNewsCommentDetailsDto;
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
    this.latestNewsCommentService.delete(id).subscribe((result) => {
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
