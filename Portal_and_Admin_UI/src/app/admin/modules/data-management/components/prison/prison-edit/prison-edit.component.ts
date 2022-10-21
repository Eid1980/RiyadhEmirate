import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdatePrisonDto } from '@shared/proxy/prisons/models';
import { PrisonService } from '@shared/proxy/prisons/prison.service';

@Component({
  selector: 'app-prison-edit',
  templateUrl: './prison-edit.component.html'
})
export class PrisonEditComponent implements OnInit {
  id: number;
  updatePrisonForm: FormGroup;
  isFormSubmitted: boolean;
  updatePrisonDto = {} as UpdatePrisonDto;

  constructor(private formBuilder: FormBuilder, private prisonService: PrisonService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل السجن');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/prison-list");
    }
  }

  buildForm() {
    this.updatePrisonForm = this.formBuilder.group({
      nameAr: [this.updatePrisonDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updatePrisonDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updatePrisonDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.prisonService.getById(this.id).subscribe((response) => {
      this.updatePrisonDto = response.data as UpdatePrisonDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updatePrisonForm.valid) {
      this.updatePrisonDto = { ...this.updatePrisonForm.value } as UpdatePrisonDto;
      this.updatePrisonDto.id = this.id;
      this.prisonService.update(this.updatePrisonDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/prison-list");
          }
        });
    }
  }
}
