import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { CreateCaseTypeDto } from '@proxy/case-types/models';
import { CaseTypeService } from '@proxy/case-types/case-type.service';

@Component({
  selector: 'app-case-type-add',
  templateUrl: './case-type-add.component.html'
})
export class CaseTypeAddComponent implements OnInit {
  createCaseTypeForm: FormGroup;
  isFormSubmitted: boolean;
  createCaseTypeDto: CreateCaseTypeDto = {} as CreateCaseTypeDto;

  constructor(private formBuilder: FormBuilder, private caseTypeService: CaseTypeService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة نوع قضية جديد');
    this.buildForm();
  }

  buildForm() {
    this.createCaseTypeForm = this.formBuilder.group({
      nameAr: [this.createCaseTypeDto.nameAr || '', Validators.required],
      nameEn: [this.createCaseTypeDto.nameEn || '', Validators.required],
      isActive: [this.createCaseTypeDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createCaseTypeForm.valid) {
      this.createCaseTypeDto = { ...this.createCaseTypeForm.value } as CreateCaseTypeDto;
      this.caseTypeService.create(this.createCaseTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/case-type-list");
          }
        });
    }
  }

}
