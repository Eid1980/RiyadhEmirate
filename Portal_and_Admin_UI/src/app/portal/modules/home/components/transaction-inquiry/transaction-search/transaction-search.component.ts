import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { IntegrationService } from '@shared/proxy/integrations/integration.service';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { GetTransactionResponseDto, TransactionRequedtDto } from '@shared/proxy/integrations/models';

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
  isFormSubmitted: boolean = false;
  transactionsAdvancedSearchForm: FormGroup;

  transactionRequedtDto = {} as TransactionRequedtDto;
  transactionResponseDto = {} as GetTransactionResponseDto;


  constructor(private integrationService: IntegrationService, private formBuilder: FormBuilder,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.buildTransactionsAdvancedSearchForm();
    this.clear();
  }

  showTransactionsAdvancedSearch() {
    this.transactionsSearchResult = false;
    this.transactionsAdvancedSearch = true;
    this.transactionRequedtDto = {} as TransactionRequedtDto;
    this.buildTransactionsAdvancedSearchForm();
  }
  showTransactionsSearch() {
    this.transactionsAdvancedSearch = false;
    this.transactionsSearchResult = false;
    this.transactionNumber = '';
  }
  buildTransactionsAdvancedSearchForm() {
    this.transactionsAdvancedSearchForm = this.formBuilder.group({
      transactionType: [this.transactionRequedtDto.transactionType || '2'],
      transactionClass: [this.transactionRequedtDto.transactionClass || '1'],
      intYear: [this.transactionRequedtDto.intYear || this.currentYear],
      intNumber: [this.transactionRequedtDto.intNumber || '', Validators.required]
    });
  }

  onTransactionsAdvancedSearchSubmit() {
    this.isFormSubmitted = true;
    if (this.transactionsAdvancedSearchForm.valid) {
      this.transactionRequedtDto = { ...this.transactionsAdvancedSearchForm.value } as TransactionRequedtDto;
      this.search();
    }
  }
  transactionsSearchClick() {
    if (this.transactionNumber) {
      this.transactionRequedtDto = {
        intNumber: this.transactionNumber,
        intYear: this.currentYear,
        transactionType: '2',
        transactionClass: '1'
      } as TransactionRequedtDto;
      this.search();
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء ادخال رقم المعاملة أولا');
    }
  }
  search() {
    this.integrationService.getTransactionAsync(this.transactionRequedtDto).subscribe((response) => {
      if (response.isSuccess) {
        this.transactionResponseDto = response.data;
        this.transactionsSearchResult = true;
      }
    });
  }

  clear() {
    this.transactionNumber = '';
    this.transactionsAdvancedSearchForm.reset();
    this.transactionsAdvancedSearch = false;
    this.transactionsSearchResult = false;
    //this.letterAdvancedSearchResponse = [];
  }
}
