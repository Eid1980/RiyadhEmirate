import { Component, OnInit, ViewChild } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LetterSearchComponent } from './letter-search/letter-search.component';


@Component({
  selector: 'app-transaction-inquiry',
  templateUrl: './transaction-inquiry.component.html'
})
export class TransactionInquiryComponent implements OnInit {
  @ViewChild(LetterSearchComponent, { static: true }) letterSearchComponent: LetterSearchComponent;
  years = [] as LookupDto<string>[];
  transactionsAdvancedSearch: boolean = false;
  transactionsSearchResult: boolean = false;
  currentYear: string = '';


  constructor(private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setTitle('الاستعلام عن المعاملات');
    if (this.years.length <= 0) {
      this.currentYear = this.getCurrentHijriYear();
      if (this.currentYear) {
        for (let i = +this.currentYear; i >= 1429; i--) {
          this.years.push({ id: i.toString(), name: i.toString() } as LookupDto<string>)
        }
      }
    }
  }
  showTransactionsAdvancedSearch() {
    this.transactionsSearchResult = false;
    this.transactionsAdvancedSearch = !this.transactionsAdvancedSearch;
  }

  transactionsSearch() {
    this.transactionsAdvancedSearch = false;
    this.transactionsSearchResult = !this.transactionsSearchResult;
  }


  getCurrentHijriYear() {
    return new Date().toLocaleString('en-u-ca-islamic', {
      year: 'numeric'
    }).toLowerCase().replace(' ah', '');
  }
  showLettersSearch() {
    this.letterSearchComponent.clear();
  }



  
}
