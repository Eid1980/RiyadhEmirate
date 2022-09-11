import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { GlobalService } from '@shared/services/global.service';
import { DomSanitizer } from '@angular/platform-browser';
import { FileManagerService } from '@shared/services/file-manager.service';
import { ServiceAudienceService } from '@shared/proxy/service-audience/service-audience.service';
import { CreateServiceAudienceDto, GetCheckedAudienceDto } from '@shared/proxy/service-audience/models';

@Component({
  selector: 'app-service-audience',
  templateUrl: './service-audience.component.html'
})
export class ServiceAudienceComponent implements OnInit {
  wizardItems: MenuItem[];
  activeIndex: number = 1;
  id: number;
  getCheckedAudienceDto = {} as GetCheckedAudienceDto;
  image: any;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  fileSize: number = 10000000;
  acceptType: 'image/*';
  isMultiple: boolean = false;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private serviceAudienceService: ServiceAudienceService, private fileManagerService: FileManagerService,
    public sanitizer: DomSanitizer, private globalService: GlobalService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('استكمال بيانات الخدمة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    } else {
      this.globalService.navigate('/admin/data-management/service-list');
    }
    this.getWizardItems();
  }

  checkAudience(id: number, audienceId: number) {
    if (id) {
      this.serviceAudienceService.delete(id).subscribe((response) => {
        this.getDetails();
      });
    }
    else {
      const createDto = { serviceId: this.id, audienceId: audienceId } as CreateServiceAudienceDto;
      this.serviceAudienceService.create(createDto).subscribe((response) => {
        this.getDetails();
      });
    }
  }

  onUpload(event: any) {
    this.fileManagerService.upload(this.id.toString(), 'ServiceExplain', '', event.files).subscribe(res => {
      if (this.getCheckedAudienceDto.image) {
        this.fileManagerService.deleteByEntityName(this.id.toString(), 'ServiceExplain').subscribe((res) => {
          this.getDetails();
        });
      }
      else {
        this.getDetails();
      }
    })
  }
  getDetails() {
    this.serviceAudienceService.getCheckedAudience(this.id).subscribe((response) => {
      this.getCheckedAudienceDto = response.data;
    });
  }

  getWizardItems() {
    this.wizardItems = [
      { label: 'البيانات الأساسية', url: `/data-management/service-edit/${this.id}` },
      { label: 'الجمهور المستهدف', url: `/data-management/service-audience/${this.id}` },
      { label: 'شروط ووثائق الخدمة', url: `/data-management/service-condition/${this.id}` }
    ];
  }

}
