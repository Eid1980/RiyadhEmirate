import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreatePrisonDto } from '@shared/proxy/prisons/models';
import { PrisonService } from '@shared/proxy/prisons/prison.service';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-prison-add',
  templateUrl: './prison-add.component.html'
})
export class PrisonAddComponent implements OnInit {
  createPrisonForm: FormGroup;
  isFormSubmitted: boolean;
  createPrisonDto = {} as CreatePrisonDto;

  constructor(private formBuilder: FormBuilder, private prisonService: PrisonService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة سجن جديد');
    this.buildForm();
  }

  buildForm() {
    this.createPrisonForm = this.formBuilder.group({
      nameAr: [this.createPrisonDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createPrisonDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createPrisonDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createPrisonForm.valid) {
      this.createPrisonDto = { ...this.createPrisonForm.value } as CreatePrisonDto;
      this.prisonService.create(this.createPrisonDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/prison-list");
          }
        });
    }
  }
}
