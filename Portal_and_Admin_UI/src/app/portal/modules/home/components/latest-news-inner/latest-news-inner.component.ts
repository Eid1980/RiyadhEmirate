import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { LatestNewsService } from '@shared/proxy/latest-news/latest-news.service';
import { GetLatestNewsDetailsDto } from '@shared/proxy/latest-news/models';
import { GlobalService } from '@shared/services/global.service';
import { CreateLatestNewsCommentDto, GetLatestNewsCommentListDto } from '@shared/proxy/latest-news-comments/models';
import { LatestNewsCommentService } from '@shared/proxy/latest-news-comments/latest-news-comment.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-latest-news-inner',
  templateUrl: './latest-news-inner.component.html'
})
export class LatestNewsInnerComponent implements OnInit {
  latestnews = {} as GetLatestNewsDetailsDto;
  id: number;
  createCommentForm: FormGroup;
  isFormSubmitted: boolean;
  createLatestNewsCommentDto = {} as CreateLatestNewsCommentDto;
  getLatestNewsCommentListDto = [] as GetLatestNewsCommentListDto[];

  constructor(private latestNewsService: LatestNewsService, private latestNewsCommentService: LatestNewsCommentService,
    private formBuilder: FormBuilder, private globalService: GlobalService, private _activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل الخبر');
    this.id = this._activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getLatestNewsById();
      this.getLatestNewsComments();
    }
    else {
      this.globalService.navigate("/home/latest-news");
    }
    this.buildForm();
  }

  getLatestNewsById(){
    this.latestNewsService.getById(this.id).subscribe((response) => {
      this.latestnews = response.data
    });
  }
  getLatestNewsComments() {
    this.latestNewsCommentService.getByLatestNewsId(this.id).subscribe((response) => {
      this.getLatestNewsCommentListDto = response.data
    });
  }

  buildForm() {
    this.createCommentForm = this.formBuilder.group({
      createdByName: [this.createLatestNewsCommentDto.createdByName || ''],
      email: [this.createLatestNewsCommentDto.email || ''],
      comment: [this.createLatestNewsCommentDto.comment || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createCommentForm.valid) {
      this.createLatestNewsCommentDto = { ...this.createCommentForm.value } as CreateLatestNewsCommentDto;
      this.createLatestNewsCommentDto.latestNewsId = this.id;
      this.latestNewsCommentService.create(this.createLatestNewsCommentDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.createCommentForm.reset();
          this.isFormSubmitted = false;
        }
      });
    }
  }
}
