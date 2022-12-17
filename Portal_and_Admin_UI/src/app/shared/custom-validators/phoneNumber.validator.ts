import { AbstractControl, ValidationErrors } from '@angular/forms';

export class PhoneNumberValidator {
  static validatePhoneNumber(control: AbstractControl): ValidationErrors | null {
    let controlValue = (control.value as string)?.valueOf().trim();
    if (controlValue == '') {
      return null;
    }
    let regexp = new RegExp(/^(009661|9661|\+9661|01|1)(1|2|3|4|6|7)([0-9]{7})$/);
    if (!regexp.test(controlValue)) {
      return { isValid: false };
    }
    else {
      return null;
    }
  }
}
