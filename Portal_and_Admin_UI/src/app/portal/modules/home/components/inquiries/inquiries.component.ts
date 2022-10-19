import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inquiries',
  templateUrl: './inquiries.component.html',
  styleUrls: ['./inquiries.component.scss']
})
export class InquiriesComponent implements OnInit {

  transactionsAdvancedSearch: any = false;
  transactionsSearchResult: any = false;

  lettersAdvancedSearch: any = false;
  lettersSearchResult: any = false;

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

  showLettersAdvancedSearch() {
    this.lettersSearchResult = false;
    this.lettersAdvancedSearch = !this.lettersAdvancedSearch;
  }

  lettersSearch() {
    this.lettersAdvancedSearch = false;
    this.lettersSearchResult = !this.lettersSearchResult;
  }
}
