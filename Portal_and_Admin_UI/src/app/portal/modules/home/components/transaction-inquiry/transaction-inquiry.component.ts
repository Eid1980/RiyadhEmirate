import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-transaction-inquiry',
  templateUrl: './transaction-inquiry.component.html'
})
export class TransactionInquiryComponent implements OnInit {
  transactionsAdvancedSearch: any = false;
  transactionsSearchResult: any = false;

  lettersAdvancedSearch: any = false;
  lettersSearchResult: any = false;

  constructor(private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('الاستعلام عن المعاملات');
  }
  showTransactionsAdvancedSearch() {
    this.transactionsSearchResult = false;
    this.transactionsAdvancedSearch = !this.transactionsAdvancedSearch;
  }

  transactionsSearch() {
    this.transactionsAdvancedSearch = false;
    this.transactionsSearchResult = !this.transactionsSearchResult;
  }

  showLettersAdvancedSearch() {
    this.lettersSearchResult = false;
    this.lettersAdvancedSearch = !this.lettersAdvancedSearch;
  }

  lettersSearch() {
    this.lettersAdvancedSearch = false;
    this.lettersSearchResult = !this.lettersSearchResult;
  }

}
