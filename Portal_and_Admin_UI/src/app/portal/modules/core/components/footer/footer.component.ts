import { Component, OnInit } from '@angular/core';
import { HomeService } from '@shared/proxy/home/home.service';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { CreateDesignEvaluationDto, CreateNewsSubscriperDto } from '@shared/proxy/home/models';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html'
})
export class FooterComponent implements OnInit {
  email: string = '';
  designEvaluate: number;

  constructor(private homeService: HomeService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
  }

  subscripe() {
    if (this.email) {
      const createNewsSubscriperDto = { email: this.email } as CreateNewsSubscriperDto;
      this.homeService.createNewsSubscriper(createNewsSubscriperDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.email = '';
          }
        });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, "برجاء ادخال البريد الالكتروني");
    }
  }
  evaluate() {
    if (this.designEvaluate) {
      const createDesignEvaluationDto = { evaluate: this.designEvaluate } as CreateDesignEvaluationDto;
      this.homeService.createDesignEvaluation(createDesignEvaluationDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.designEvaluate = undefined;
        }
      });

    }
    else {
      this.globalService.messageAlert(MessageType.Warning, "برجاء اختيار التقييم أولا");
    }
  }
}
