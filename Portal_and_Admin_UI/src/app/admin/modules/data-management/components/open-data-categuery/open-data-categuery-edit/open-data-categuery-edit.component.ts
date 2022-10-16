import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateOpenDataCategueryDto } from '@proxy/open-data-categueries/models';
import { OpenDataCategueryService } from '@proxy/open-data-categueries/open-data-categuery.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';

@Component({
  selector: 'app-open-data-categuery-edit',
  templateUrl: './open-data-categuery-edit.component.html'
})
export class OpenDataCategueryEditComponent implements OnInit {
  id: number;
  updateOpenDataCategueryForm: FormGroup;
  isFormSubmitted: boolean;
  updateOpenDataCategueryDto = {} as UpdateOpenDataCategueryDto;
  openDataSubCategueries = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private openDataCategueryService: OpenDataCategueryService,
    private lookupService: LookupService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل بيانات المجموعة');
    this.lookupService.getOpenDataSubCategueryLookupList().subscribe((response) => {
      this.openDataSubCategueries = response.data;
    });
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/open-data-categuery-list");
    }
  }

  buildForm() {
    this.updateOpenDataCategueryForm = this.formBuilder.group({
      nameAr: [this.updateOpenDataCategueryDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateOpenDataCategueryDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      openDataSubCategueryId: [this.updateOpenDataCategueryDto.openDataSubCategueryId || null, [Validators.required]],
      isActive: [this.updateOpenDataCategueryDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.openDataCategueryService.getById(this.id).subscribe((response) => {
      this.updateOpenDataCategueryDto = response.data as UpdateOpenDataCategueryDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateOpenDataCategueryForm.valid) {
      this.updateOpenDataCategueryDto = { ...this.updateOpenDataCategueryForm.value } as UpdateOpenDataCategueryDto;
      this.updateOpenDataCategueryDto.id = this.id;
      this.openDataCategueryService.update(this.updateOpenDataCategueryDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/open-data-categuery-list");
          }
        });
    }
  }
}
