import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
  Router,
} from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { HttpErrorResponse } from '@angular/common/http';
import { AccountService } from '@proxy/accounts/account.service';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router, private accountService: AccountService) {}

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot):
    | Observable<boolean | UrlTree>
    | Promise<boolean | UrlTree>
    | boolean
    | UrlTree {
    if (localStorage.getItem('EmiratesToken') === null || localStorage.getItem('EmiratesToken') === undefined) {
      this.router.navigate(['/auth/login']);
      return false;
    }
    else {
      return this.accountService.getAuthUser().pipe(
        map((response) => {
          if (response.isSuccess) {
            localStorage.setItem('AuthUser', JSON.stringify(response.data));
            return true;
          }
          else {
            next.data = {};
            localStorage.removeItem('AuthUser');
            localStorage.removeItem('EmiratesToken');
            this.router.navigate(['/auth/login'], {
              queryParams: { returnUrl: state.url },
            });
            return false;
          }
        }),
        catchError((error: HttpErrorResponse) => {
          if (error.status === 401) {
            localStorage.removeItem('AuthUser');
            localStorage.removeItem('EmiratesToken');
            this.router.navigate(['/auth/login'], {
              queryParams: { returnUrl: state.url },
            });
          }
          return throwError(error);
        })
      );
    }
  }
}
