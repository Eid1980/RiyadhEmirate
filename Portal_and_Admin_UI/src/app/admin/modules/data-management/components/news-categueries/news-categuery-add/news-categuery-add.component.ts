import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateNewsCategueryDto } from '@shared/proxy/news-categueries/models';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-news-categuery-add',
  templateUrl: './news-categuery-add.component.html'
})
export class NewsCategueryAddComponent implements OnInit {
  createNewsCategueryForm: FormGroup;
  isFormSubmitted: boolean;
  createNewsCategueryDto = {} as CreateNewsCategueryDto;

  constructor(private formBuilder: FormBuilder, private newsCategueryService: NewsCategueryService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة تصنيف خبر جديد');
    this.buildForm();
  }

  buildForm() {
    this.createNewsCategueryForm = this.formBuilder.group({
      nameAr: [this.createNewsCategueryDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createNewsCategueryDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createNewsCategueryDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createNewsCategueryForm.valid) {
      this.createNewsCategueryDto = { ...this.createNewsCategueryForm.value } as CreateNewsCategueryDto;
      this.newsCategueryService.create(this.createNewsCategueryDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/news-categuery-list");
          }
        });
    }
  }

}
