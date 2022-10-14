import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-transaction-inquiry',
  templateUrl: './transaction-inquiry.component.html'
})
export class TransactionInquiryComponent implements OnInit {

  constructor(private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('الاستعلام عن المعاملات');
  }

}
