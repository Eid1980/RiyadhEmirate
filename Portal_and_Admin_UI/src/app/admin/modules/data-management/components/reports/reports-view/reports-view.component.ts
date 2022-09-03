import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { ReportsService } from '../../../services/reports.service';

@Component({
  selector: 'app-reports-view',
  templateUrl: './reports-view.component.html',
  styleUrls: ['./reports-view.component.scss']
})
export class ReportsViewComponent implements OnInit {
  form: FormGroup;
  isFormSubmitted: boolean;
  id:number;
  detailsVM:any;
  oldImage:any;

  constructor(
    private formBuilder: FormBuilder,
    private reportsService: ReportsService,
    private globalService:GlobalService,
    private activatedRoute: ActivatedRoute,
    public sanitizer: DomSanitizer
  ) {}

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails(this.id);
    }
    else {
      this.globalService.navigate("/admin/data-management/reports-list");
    }
  }

  getDetails(newsId : number) {
    this.form.disable();

    this.reportsService.getById(newsId).subscribe(
      (response) => {
        this.detailsVM = response.data;
        this.form.patchValue({
          Id: this.detailsVM.Id,
          TitleAr:this.detailsVM.titleAr,
          TitleEn:this.detailsVM.titleEn,
          DescriptionAr:this.detailsVM.descriptionAr,
          DescriptionEn:this.detailsVM.descriptionEn,
          Date: new Date(this.detailsVM.Date),
           HijriDate: this.globalService.convertToHijri(new Date(this.detailsVM.date),'ar'),
          IsActive: this.detailsVM.isActive,
        });

        this.oldImage = this.detailsVM.image
      }
    );
  }

}
