import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateCaseTypeDto } from '@proxy/case-types/models';
import { CaseTypeService } from '@proxy/case-types/case-type.service';
import { ActivatedRoute, Router } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-case-type-edit',
  templateUrl: './case-type-edit.component.html'
})
export class CaseTypeEditComponent implements OnInit {
  id: number;
  updateCaseTypeForm: FormGroup;
  isFormSubmitted: boolean;
  updateCaseTypeDto: UpdateCaseTypeDto = {} as UpdateCaseTypeDto;

  constructor(private formBuilder: FormBuilder, private caseTypeService: CaseTypeService,
    private router: Router, private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل نوع القضية');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/case-type-list");
    }
  }

  buildForm() {
    this.updateCaseTypeForm = this.formBuilder.group({
      nameAr: [this.updateCaseTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateCaseTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateCaseTypeDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.caseTypeService.getById(this.id).subscribe((response) => {
      this.updateCaseTypeDto = response.data as UpdateCaseTypeDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateCaseTypeForm.valid) {
      this.updateCaseTypeDto = { ...this.updateCaseTypeForm.value } as UpdateCaseTypeDto;
      this.updateCaseTypeDto.id = this.id;
      this.caseTypeService.update(this.updateCaseTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/case-type-list");
          }
        });
    }
  }
}
