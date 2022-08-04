import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDto } from '@proxy/accounts/models';

@Component({
  selector: 'app-user-data-current-view',
  templateUrl: './user-data-current-view.component.html'
})
export class UserDataCurrentViewComponent implements OnInit {
  userDto = {} as GetUserDto;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.getUserDetails();
  }

  getUserDetails() {
    this.accountService.getAuthUser().subscribe((response) => {
      this.userDto = response.data;
    });
  }
}
