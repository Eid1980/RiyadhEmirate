import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { NewsService } from '@shared/proxy/news/news.service';
import { GetNewsDetailsDto } from '@shared/proxy/news/models';
import { GlobalService } from '@shared/services/global.service';
import { CreateNewsCommentDto, GetNewsCommentListDto } from '@shared/proxy/news-comments/models';
import { NewsCommentService } from '@shared/proxy/news-comments/news-comment.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { NewsTypes } from '@shared/enums/news-types.enum';

@Component({
  selector: 'app-news-details',
  templateUrl: './news-details.component.html'
})
export class NewsDetailsComponent implements OnInit {
  newsDetailsDto = {} as GetNewsDetailsDto;
  id: number;
  createCommentForm: FormGroup;
  isFormSubmitted: boolean;
  createNewsCommentDto = {} as CreateNewsCommentDto;
  getNewsCommentListDto = [] as GetNewsCommentListDto[];
  canComments: boolean = false;

  constructor(private newsService: NewsService, private newsCommentService: NewsCommentService,
    private formBuilder: FormBuilder, private globalService: GlobalService, private _activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('تفاصيل الخبر');
    let query = this._activatedRoute.snapshot.params['id'];
    if (query) {
      this.id = this.globalService.decryptNumber(query.toString());
      if (this.id) {
        this.getNewsById();
      }
      else {
        this.globalService.navigate("/");
      }
    }
    else {
      this.globalService.navigate("/");
    }
    this.buildForm();
  }

  getNewsById(){
    this.newsService.getById(this.id).subscribe((response) => {
      this.newsDetailsDto = response.data
      if (!this.newsDetailsDto.isActive) {
        this.globalService.navigate("/");
      }
      this.canComments = this.newsDetailsDto.newsTypeId == NewsTypes.LatestNews;
      if (this.canComments) {
        this.getNewsComments();
      }
    });
  }
  getNewsComments() {
    this.newsCommentService.getByNewsId(this.id).subscribe((response) => {
      this.getNewsCommentListDto = response.data
    });
  }

  buildForm() {
    this.createCommentForm = this.formBuilder.group({
      createdByName: [this.createNewsCommentDto.createdByName || ''],
      email: [this.createNewsCommentDto.email || '' , Validators.email],
      comment: [this.createNewsCommentDto.comment || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }
  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createCommentForm.valid) {
      this.createNewsCommentDto = { ...this.createCommentForm.value } as CreateNewsCommentDto;
      this.createNewsCommentDto.newsId = this.id;
      this.newsCommentService.create(this.createNewsCommentDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.createCommentForm.reset();
          this.isFormSubmitted = false;
        }
      });
    }
  }
}
