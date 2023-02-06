import { Component, Input, OnInit } from '@angular/core';
import { IntegrationService } from '@shared/proxy/integrations/integration.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EntityTableDto, GetSubSubExternalEntityRequestDto, GetTransactionResponseDto, LetterAdvancedSearchRequedtDto, LetterAdvancedSearchResponse } from '@shared/proxy/integrations/models';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-letter-search',
  templateUrl: './letter-search.component.html'
})
export class LetterSearchComponent implements OnInit {
  lettersAdvancedSearch: boolean = false;
  lettersSearchResult: boolean = false;
  lettersSearchFinalResult: boolean = false;
  isFormSubmitted: boolean = false;
  letterNumber: string = '';
  lettersAdvancedSearchForm: FormGroup;

  lettersAdvancedSearchsubExternalEntity: boolean = false;
  lettersAdvancedSearchsubSubExternalEntity: boolean = false;

  externalEntities = [] as EntityTableDto[];
  subExternalEntities = [] as EntityTableDto[];
  subSubExternalEntities = [] as EntityTableDto[];
  @Input() years = [] as LookupDto<string>[];
  @Input() currentYear: string = '';
  letterAdvancedSearchRequedtDto = {} as LetterAdvancedSearchRequedtDto;
  letterAdvancedSearchResponse = [] as LetterAdvancedSearchResponse[];
  transactionResponseDto = {} as GetTransactionResponseDto;

  constructor(private integrationService: IntegrationService, private formBuilder: FormBuilder,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.buildLettersAdvancedSearchForm();
    this.clear();
  }

  showLettersAdvancedSearch() {
    this.getMainEntityTableDto();
    this.lettersSearchResult = false;
    this.lettersAdvancedSearch = true;
    this.buildLettersAdvancedSearchForm();
  }
  showLettersSearch() {
    this.lettersSearchResult = false;
    this.lettersAdvancedSearch = false;
    this.letterNumber = '';
  }
  buildLettersAdvancedSearchForm() {
    this.lettersAdvancedSearchForm = this.formBuilder.group({
      externalEntity: [this.letterAdvancedSearchRequedtDto.externalEntity || '-1'],
      subExternalEntity: [this.letterAdvancedSearchRequedtDto.subExternalEntity || '-1'],
      subSubExternalEntity: [this.letterAdvancedSearchRequedtDto.subSubExternalEntity || '-1'],
      searchClass: [this.letterAdvancedSearchRequedtDto.searchClass || '1'],
      intYear: [this.letterAdvancedSearchRequedtDto.intYear || this.currentYear],
      letterNo: [this.letterAdvancedSearchRequedtDto.letterNo || '', Validators.required]
    });
  }

  onExternalEntityChange() {
    let externalEntityId = this.lettersAdvancedSearchForm.controls['externalEntity'].value;
    if (externalEntityId) {
      this.integrationService.getSubExternalEntityAsync(externalEntityId).subscribe((response) => {
        if (response.isSuccess) {
          this.subExternalEntities = response.data;
          this.lettersAdvancedSearchsubExternalEntity = true;
        }
        else {
          this.lettersAdvancedSearchsubExternalEntity = false;
          this.lettersAdvancedSearchsubSubExternalEntity = false;
        }
      });
    }
    else {
      this.lettersAdvancedSearchsubExternalEntity = false;
      this.lettersAdvancedSearchsubSubExternalEntity = false;
    }
    this.lettersAdvancedSearchForm.controls['subExternalEntity'].setValue('-1');
    this.lettersAdvancedSearchForm.controls['subSubExternalEntity'].setValue('-1');
  }
  onSubExternalEntityChange() {
    let externalEntityId = this.lettersAdvancedSearchForm.controls['externalEntity'].value;
    let subExternalEntityId = this.lettersAdvancedSearchForm.controls['subExternalEntity'].value;
    if (subExternalEntityId) {
      let request = { externalEntity: externalEntityId, subExternalEntity: subExternalEntityId } as GetSubSubExternalEntityRequestDto;
      this.integrationService.getSubSubExternalEntityAsync(request).subscribe((response) => {
        if (response.isSuccess) {
          this.subSubExternalEntities = response.data;
          this.lettersAdvancedSearchsubSubExternalEntity = true;
        }
        else {
          this.lettersAdvancedSearchsubSubExternalEntity = false;
        }
      });
    }
    else {
      this.lettersAdvancedSearchsubSubExternalEntity = false;
    }
    this.lettersAdvancedSearchForm.controls['subSubExternalEntity'].setValue('-1');
  }

  onLettersAdvancedSearchSubmit() {
    this.isFormSubmitted = true;
    if (this.lettersAdvancedSearchForm.valid) {
      this.letterAdvancedSearchRequedtDto = { ...this.lettersAdvancedSearchForm.value } as LetterAdvancedSearchRequedtDto;
      this.search();
    }
  }
  lettersSearchClick() {
    if (this.letterNumber) {
      this.letterAdvancedSearchRequedtDto = {
        letterNo: this.letterNumber,
        externalEntity: -1,
        subExternalEntity: -1,
        subSubExternalEntity: -1,
        intYear: this.currentYear,
        searchClass: '1'
      } as LetterAdvancedSearchRequedtDto;
      this.search();
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء ادخال رقم الخطاب أولا');
    }
  }
  search() {
    this.integrationService.getLetterBySearchAsync(this.letterAdvancedSearchRequedtDto).subscribe((response) => {
      if (response.isSuccess) {
        this.letterAdvancedSearchResponse = response.data;
        this.lettersSearchResult = true;
      }
    });
  }
  showFinalResult(id: string, letterNo: string, letterDate: string) {
    debugger;
    this.integrationService.getTransactionByIdAsync(id).subscribe((response) => {
      if (response.isSuccess) {
        this.transactionResponseDto = response.data;
        this.transactionResponseDto.letterNo = letterNo;
        this.transactionResponseDto.letterDate = letterDate;
        this.lettersSearchFinalResult = true;
      }
    });
  }

  getMainEntityTableDto() {
    if (this.externalEntities.length <= 0) {
      this.integrationService.getExternalEntityAsync().subscribe((response) => {
        this.externalEntities = response.data;
      });
    }
  }
  closeLettersSearchFinalResult() {
    this.lettersSearchFinalResult = false;
  }
  clear() {
    this.letterNumber = '';
    this.lettersAdvancedSearchForm.reset();
    this.lettersAdvancedSearchsubExternalEntity = false;
    this.lettersAdvancedSearchsubSubExternalEntity = false;
    this.lettersAdvancedSearchForm.controls['externalEntity'].setValue('-1');
    this.lettersAdvancedSearchForm.controls['subExternalEntity'].setValue('-1');
    this.lettersAdvancedSearchForm.controls['subSubExternalEntity'].setValue('-1');
    this.lettersAdvancedSearch = false;
    this.lettersSearchResult = false;
    this.letterAdvancedSearchResponse = [];
  }

}
