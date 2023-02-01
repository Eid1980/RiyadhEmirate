import { Component, Input, OnInit } from '@angular/core';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';

@Component({
  selector: 'app-transaction-search',
  templateUrl: './transaction-search.component.html'
})
export class TransactionSearchComponent implements OnInit {
  @Input() years = [] as LookupDto<string>[];
  @Input() currentYear: string = '';
  transactionNumber: string = '';
  transactionsAdvancedSearch: boolean = false;
  transactionsSearchResult: boolean = false;


  constructor() { }

  ngOnInit(): void {
  }


  showTransactionsAdvancedSearch() {
    this.transactionsSearchResult = false;
    this.transactionsAdvancedSearch = !this.transactionsAdvancedSearch;
  }

  transactionsSearch() {
    this.transactionsAdvancedSearch = false;
    this.transactionsSearchResult = !this.transactionsSearchResult;
  }
  clear() {
  }
}
