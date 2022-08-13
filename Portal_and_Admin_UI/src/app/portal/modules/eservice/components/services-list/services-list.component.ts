import { Component, OnInit } from '@angular/core';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-services-list',
  templateUrl: './services-list.component.html'
})
export class ServicesListComponent implements OnInit {
  serviceSearchForm: FormGroup;
  services = [] as GetServiceListDto[];
  contentTitle = 'جميع الخدمات';
  sortTitle = 'أبجدي - من أ إلى ي';

  constructor(private formBuilder: FormBuilder, private serviceService: ServiceService,
    public sanitizer: DomSanitizer) { }

  ngOnInit(): void {
    this.getServices();
    this.buildSearchForm();
  }

  buildSearchForm() {
    this.serviceSearchForm = this.formBuilder.group({
      filter: ['' || null]
    });
  }
  getServices() {
    this.contentTitle = 'جميع الخدمات';
    this.serviceService.getAll().subscribe((result) => {
      this.services = result.data;
    });
  }
  servicSearch() {
    let searchFilter: string = this.serviceSearchForm.get('filter').value;
    if (searchFilter) {
      this.serviceService.searchByFilter(searchFilter).subscribe((result) => {
        this.services = result.data;
        this.contentTitle = 'نتائج البحث';
      });
    }
    else {
      this.getServices();
    }
  }
  sortServices(sortBy: number) {
    if (this.services.length > 0) {
      switch (sortBy) {
        case 1:
          this.services.sort((a, b) => a.nameAr.localeCompare(b.nameAr));
          this.sortTitle = 'أبجدي - من أ إلى ي';
          break;
        case 2:
          this.services.sort((a, b) => b.nameAr.localeCompare(a.nameAr));
          this.sortTitle = 'أبجدي - من ي إلى أ';
          break;
        case 3:
          this.services.sort((a, b) => a.createdDate.localeCompare(b.createdDate));
          this.sortTitle = 'من الأقدم إلى الأحدث';
          break;
        case 4:
          this.services.sort((a, b) => b.createdDate.localeCompare(a.createdDate));
          this.sortTitle = 'من الأحدث إلى الأقدم';
          break;
        default:
          break;
      }
    }
  }
}
