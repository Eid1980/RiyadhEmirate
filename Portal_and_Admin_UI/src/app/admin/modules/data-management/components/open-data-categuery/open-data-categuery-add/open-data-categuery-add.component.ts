import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { CreateOpenDataCategueryDto } from '@proxy/open-data-categueries/models';
import { OpenDataCategueryService } from '@proxy/open-data-categueries/open-data-categuery.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';

@Component({
  selector: 'app-open-data-categuery-add',
  templateUrl: './open-data-categuery-add.component.html'
})
export class OpenDataCategueryAddComponent implements OnInit {
  createOpenDataCategueryForm: FormGroup;
  isFormSubmitted: boolean;
  createOpenDataCategueryDto = {} as CreateOpenDataCategueryDto;
  openDataSubCategueries = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private openDataCategueryService: OpenDataCategueryService,
    private lookupService: LookupService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مجموعة جديدة');
    this.lookupService.getOpenDataSubCategueryLookupList().subscribe((response) => {
      this.openDataSubCategueries = response.data;
    });
    this.buildForm();
  }

  buildForm() {
    this.createOpenDataCategueryForm = this.formBuilder.group({
      nameAr: [this.createOpenDataCategueryDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createOpenDataCategueryDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      openDataSubCategueryId: [this.createOpenDataCategueryDto.openDataSubCategueryId || null, [Validators.required]],
      isActive: [this.createOpenDataCategueryDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createOpenDataCategueryForm.valid) {
      this.createOpenDataCategueryDto = { ...this.createOpenDataCategueryForm.value } as CreateOpenDataCategueryDto;
      this.openDataCategueryService.create(this.createOpenDataCategueryDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/open-data-categuery-list");
          }
        });
    }
  }
}
