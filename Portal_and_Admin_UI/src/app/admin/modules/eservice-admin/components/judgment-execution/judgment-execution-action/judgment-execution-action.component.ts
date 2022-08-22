import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Stages } from '@shared/enums/stage.enum';
import { RequestChangeStageDto } from '@shared/proxy/requests/models';
import { RequestService } from '@shared/proxy/requests/request.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-judgment-execution-action',
  templateUrl: './judgment-execution-action.component.html'
})
export class JudgmentExecutionActionComponent implements OnInit {
  requestId: string;
  adminActionForm: FormGroup;
  isFormSubmitted: boolean = false;
  requestChangeStageDto = {} as RequestChangeStageDto;

  approved: number = Stages.UnderProcessing;
  rejected: number = Stages.RequestRejected;
  returned: number = Stages.CompleteDataFromRequester;

  constructor(private formBuilder: FormBuilder, private activatedRoute: ActivatedRoute,
    private requestService: RequestService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
  }

  buildForm() {
    this.adminActionForm = this.formBuilder.group({
      notes: [this.requestChangeStageDto.notes || '', Validators.required],
    });
  }

  executeAction(action: number) {
    if (action != Stages.UnderProcessing) {
      this.isFormSubmitted = true;
    }
    if (this.adminActionForm.valid || action == Stages.UnderProcessing) {
      let confrimMessage = '';
      switch (action) {
        case Stages.UnderProcessing:
          confrimMessage = 'هل تريد متأكد من الموافقة على الطلب وارساله الى نظام شامل؟';
          break;
        case Stages.RequestRejected:
          confrimMessage = 'هل تريد متأكد من رفض الطلب؟';
          break;
        case Stages.CompleteDataFromRequester:
          confrimMessage = 'هل تريد متأكد من ارجاع الطلب الى المستفيد لاستكمال البيانات؟';
          break;
        default:
          break;
      }
      this.globalService.showConfirm(confrimMessage);
      this.globalService.confirmSubmit = () => this.isconfirm(action);
    }
  }
  isconfirm(action: number) {
    this.requestChangeStageDto = { ...this.adminActionForm.value } as RequestChangeStageDto;
    this.requestChangeStageDto.id = this.requestId;
    this.requestChangeStageDto.stageId = action;
    this.requestService.changeStage(this.requestChangeStageDto).subscribe((response) => {
      this.globalService.showMessage(response.message);
      this.globalService.navigateToInbox();
    });
    this.globalService.clearMessages();
  }
}
