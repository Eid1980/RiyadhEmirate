import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { CreateAuctionDto } from '@shared/proxy/auctions/models';
import { AuctionService } from '@shared/proxy/auctions/auction.service';

@Component({
  selector: 'app-auction-add',
  templateUrl: './auction-add.component.html'
})
export class AuctionAddComponent implements OnInit {
  createAuctionform: FormGroup;
  isFormSubmitted: boolean;
  createAuctionDto = {} as CreateAuctionDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.auctionsfileSize ? environment.auctionsfileSize : environment.fileSize;
  acceptType: string = environment.auctionsallowedExtensions ? environment.auctionsallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private auctionService: AuctionService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة مناقصة جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createAuctionform = this.formBuilder.group({
      title: [this.createAuctionDto.title || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      content: [this.createAuctionDto.content || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      image: [this.createAuctionDto.image || null],
      isActive: [this.createAuctionDto.isActive || true, Validators.required],
    });
  }

  onUpload(event: any) {
    this.createAuctionform.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.createAuctionform.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createAuctionform.valid) {
      this.createAuctionDto = { ...this.createAuctionform.value } as CreateAuctionDto;
      let imageContent = this.createAuctionform.get('image').value;
      if (imageContent) {
        this.createAuctionDto.imageName = imageContent.name;
      }
      this.auctionService.create(this.createAuctionDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Auctions, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate('/admin/data-management/auction-list');
            });
          }
          else {
            this.globalService.navigate('/admin/data-management/auction-list');
          }
        }
      });
    }
  }
}
