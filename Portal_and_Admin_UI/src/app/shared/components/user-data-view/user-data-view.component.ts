import { Component, Input, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDto } from '@proxy/accounts/models';

@Component({
  selector: 'app-user-data-view',
  templateUrl: './user-data-view.component.html'
})
export class UserDataViewComponent implements OnInit {
  userDto = {} as GetUserDto;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  initializeForm(userId?: number) {
    if (userId) {
      this.accountService.getById(userId).subscribe((response) => {
        this.userDto = response.data;
      });
    }
  }

}
