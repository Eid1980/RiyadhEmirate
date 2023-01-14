import { Pipe, PipeTransform } from '@angular/core';
import { GetAllServiceListDto } from '../proxy/home/models';

@Pipe({
  name: 'servicefilter',
  pure: false
})
export class ServiceFilterPipe implements PipeTransform {
  transform(items: GetAllServiceListDto[], take: number): any {
    if (!items || !take) {
      return items;
    }
    let start = take * 2;
    return items.slice(start, start + 2);
  }
}
