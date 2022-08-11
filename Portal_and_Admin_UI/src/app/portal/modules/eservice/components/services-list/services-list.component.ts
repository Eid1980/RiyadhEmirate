import { Component, OnInit } from '@angular/core';
import { ServiceService } from '@shared/proxy/services/service.service';
import { GetServiceListDto } from '@shared/proxy/services/models';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-services-list',
  templateUrl: './services-list.component.html'
})
export class ServicesListComponent implements OnInit {
  serviceSearchForm: FormGroup;
  services = [] as GetServiceListDto[];

  constructor(private formBuilder: FormBuilder, private serviceService: ServiceService) { }

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
    this.serviceService.getAll().subscribe((result) => {
      this.services = result.data;
    });
  }
  servicSearch() {
    let searchFilter: string = this.serviceSearchForm.get('filter').value;
    if (searchFilter) {
      this.serviceService.searchByFilter(searchFilter).subscribe((result) => {
        this.services = result.data;
      });
    }
    else {
      this.getServices();
    }
  }
}
