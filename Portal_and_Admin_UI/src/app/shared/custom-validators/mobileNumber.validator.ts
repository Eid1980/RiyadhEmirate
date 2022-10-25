import { AbstractControl, ValidationErrors } from '@angular/forms';

export class MobileNumberValidator {
  static validateMobileNumber(control: AbstractControl): ValidationErrors | null {

    let controlValue = (control.value as string)?.valueOf().trim();

    if (controlValue == '') {
      return { isValid: true }
    }

    let regexp = new RegExp('^966{1}[0-9]{9}$');
    let isValid = regexp.test(controlValue);

    return {isValid : isValid};
  }
}
