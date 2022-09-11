import { Pipe, PipeTransform } from '@angular/core';
import { GetServiceListDto } from '../proxy/services/models';

@Pipe({
  name: 'servicefilter',
  pure: false
})
export class ServiceFilterPipe implements PipeTransform {
  transform(items: GetServiceListDto[], take: number): any {
    if (!items || !take) {
      return items;
    }
    let start = take * 2;
    return items.slice(start, start + 2);
  }
}
