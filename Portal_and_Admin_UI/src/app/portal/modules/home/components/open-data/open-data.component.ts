import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { OpenDataRequestService } from '@shared/proxy/open-data-requests/open-data-request.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateOpenDataRequestDto } from '@shared/proxy/open-data-requests/models';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-open-data',
  templateUrl: './open-data.component.html'
})
export class OpenDataComponent implements OnInit {
  createOpenDataRequestform: FormGroup;
  isFormSubmitted: boolean;
  createOpenDataRequestDto = {} as CreateOpenDataRequestDto;

  constructor(private formBuilder: FormBuilder, private openDataRequestService: OpenDataRequestService,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('البيانات المفتوحة');
    this.buildForm();
  }

  buildForm() {
    this.createOpenDataRequestform = this.formBuilder.group({
      fullName: [this.createOpenDataRequestDto.fullName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.createOpenDataRequestDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      title: [this.createOpenDataRequestDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.createOpenDataRequestDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createOpenDataRequestform.valid) {
      this.createOpenDataRequestDto = { ...this.createOpenDataRequestform.value } as CreateOpenDataRequestDto;
      this.createOpenDataRequestDto.isReplied = false;
      this.openDataRequestService.create(this.createOpenDataRequestDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.createOpenDataRequestform.reset();
          this.isFormSubmitted = false;
        }
      });
    }
  }

}
