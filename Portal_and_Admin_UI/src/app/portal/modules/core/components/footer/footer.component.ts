import { Component, OnInit } from '@angular/core';
import { HomeService } from '@shared/proxy/home/home.service';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { CreateDesignEvaluationDto } from '@shared/proxy/home/models';
import { environment } from 'src/environments/environment';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html'
})
export class FooterComponent implements OnInit {
  email: string = '';
  designEvaluate: number;
  lastSieUpdate: string;

  constructor(private homeService: HomeService, private translateService: TranslationServiceService,
    private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.lastSieUpdate = this.globalService.getFullDate(new Date(environment.lastSieUpdate), this.translateService.getCurrentLanguage().Name.toLowerCase());
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
