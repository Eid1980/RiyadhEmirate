import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AuctionService } from '@shared/proxy/auctions/auction.service';
import { GlobalService } from '@shared/services/global.service';
import { UpdateAuctionDto } from '@shared/proxy/auctions/models';
import { FileManagerService } from '@shared/services/file-manager.service';
import { DomSanitizer } from '@angular/platform-browser';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-auction-edit',
  templateUrl: './auction-edit.component.html'
})
export class AuctionEditComponent implements OnInit {
  updateAuctionform: FormGroup;
  isFormSubmitted: boolean;
  id: number;
  updateAuctionDto = {} as UpdateAuctionDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.auctionsfileSize ? environment.auctionsfileSize : environment.fileSize;
  acceptType: string = environment.auctionsallowedExtensions ? environment.auctionsallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private auctionService: AuctionService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService,
    public sanitizer: DomSanitizer
  ) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل المناقصة');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/auction-list");
    }
  }

  buildForm() {
    this.updateAuctionform = this.formBuilder.group({
      title: [this.updateAuctionDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.updateAuctionDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      image: [null],
      isActive: [this.updateAuctionDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.auctionService.getById(this.id).subscribe((response) => {
      this.updateAuctionDto = response.data as UpdateAuctionDto;
      this.buildForm();
    });
  }
  onUpload(event: any) {
    this.updateAuctionform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateAuctionform.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateAuctionform.valid) {
      this.updateAuctionDto = { ...this.updateAuctionform.value } as UpdateAuctionDto;
      this.updateAuctionDto.id = this.id;
      let imageContent = this.updateAuctionform.get('image').value;
      if (imageContent) {
        this.updateAuctionDto.imageName = imageContent.name;
      }
      this.auctionService.update(this.updateAuctionDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Auctions, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/auction-list");
            });
          }
          else {
            this.globalService.navigate("/admin/data-management/auction-list");
          }
        }
      });
    }
  }
}
