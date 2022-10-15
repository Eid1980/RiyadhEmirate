import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { ContactUsMessageService } from '@shared/proxy/contact-us-messages/contact-us-message.service';
import { CreateContactUsMessageDto } from '@shared/proxy/contact-us-messages/models';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html'
})
export class ContactUsComponent implements OnInit {
  lat: number = 24.738823381268524;
  lng: number = 46.64890079854117;

  createContactUsform: FormGroup;
  isFormSubmitted: boolean;
  createContactUsMessage = {} as CreateContactUsMessageDto;
  messageContactUsTypes = [] as LookupDto<number>[];

  constructor(private lookUpService: LookupService,
    private conatctUsService: ContactUsMessageService,
    private globalService: GlobalService,
    private formBuilder: FormBuilder) {
  }

  ngOnInit(): void {
    this.globalService.setTitle("تواصل معنا");
    this.buildForm();

    this.getContactUsMessageType();
  }

  buildForm() {
    this.createContactUsform = this.formBuilder.group({
      fullName: [this.createContactUsMessage.fullName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email : [this.createContactUsMessage.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      title: [this.createContactUsMessage.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      contactUsMessageTypeId: [this.createContactUsMessage.contactUsMessageTypeId || '', [Validators.required]],
      content: [this.createContactUsMessage.content || null, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      recaptcha: ['' , Validators.required]
    });
  }

  getContactUsMessageType(){
    this.lookUpService.getContactUsMessageTypeLookupList().subscribe(
      (response) => {
        if(response.isSuccess){
          this.messageContactUsTypes = response.data;
        }
      }),
      (error)=>{

      }
  }

  onSubmit(){
    this.isFormSubmitted = true;

    if (this.createContactUsform.valid) {
      this.createContactUsMessage = { ...this.createContactUsform.value } as CreateContactUsMessageDto;

      this.conatctUsService.create(this.createContactUsMessage).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.createContactUsform.reset();
        }
      });
    }
  }
}
