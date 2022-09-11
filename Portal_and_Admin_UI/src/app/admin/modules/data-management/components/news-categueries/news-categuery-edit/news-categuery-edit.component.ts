import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateNewsCategueryDto } from '@shared/proxy/news-categueries/models';
import { NewsCategueryService } from '@shared/proxy/news-categueries/news-categuery.service';

@Component({
  selector: 'app-news-categuery-edit',
  templateUrl: './news-categuery-edit.component.html'
})
export class NewsCategueryEditComponent implements OnInit {
  id: number;
  updateNewsCategueryForm: FormGroup;
  isFormSubmitted: boolean;
  updateNewsCategueryDto = {} as UpdateNewsCategueryDto;

  constructor(private formBuilder: FormBuilder, private newsCategueryService: NewsCategueryService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل نوع القضية');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/news-categuery-list");
    }
  }

  buildForm() {
    this.updateNewsCategueryForm = this.formBuilder.group({
      nameAr: [this.updateNewsCategueryDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateNewsCategueryDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateNewsCategueryDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.newsCategueryService.getById(this.id).subscribe((response) => {
      this.updateNewsCategueryDto = response.data as UpdateNewsCategueryDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateNewsCategueryForm.valid) {
      this.updateNewsCategueryDto = { ...this.updateNewsCategueryForm.value } as UpdateNewsCategueryDto;
      this.updateNewsCategueryDto.id = this.id;
      this.newsCategueryService.update(this.updateNewsCategueryDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/news-categuery-list");
          }
        });
    }
  }
}
