import { AbstractControl, ValidationErrors } from '@angular/forms';

export class NationalityIDValidator {
  static validateNationalityID(control: AbstractControl): ValidationErrors | null {

    debugger
    let controlValue = (control.value as string)?.valueOf().trim();

    if (controlValue == '') {
      return { isValid: false }
    }

    let regexp = new RegExp('^(1|2){1}[0-9]{9}$');
    let isValid = regexp.test(controlValue);

    return {isValid : isValid};
  }
}
