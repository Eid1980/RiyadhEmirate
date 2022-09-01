import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-region-princes',
  templateUrl: './region-princes.component.html',
  styleUrls: ['./region-princes.component.scss']
})
export class RegionPrincesComponent implements OnInit {

  regionPrincesList: any = [
    {
      id: 1,
      avatar: 'assets/images/princes/prince-1.jpg',
      name: 'الأمير ناصر بن عبد العزيز',
      subtitle: '',
      dateFrom: '1356',
      dateTo: '7/7/1366',
      description: ''
    },
    {
      id: 2,
      avatar: 'assets/images/princes/prince-2.jpg',
      name: 'الأمير سلطان بن عبد العزيز',
      subtitle: '',
      dateFrom: '8/7/1366',
      dateTo: '2/4/1372',
      description: ''
    },
    {
      id: 3,
      avatar: 'assets/images/princes/prince-3.jpg',
      name: 'الأمير نايف بن عبد العزيز',
      subtitle: 'بالنيابة عن الأمير السلطان',
      dateFrom: '6/6/1371',
      dateTo: '2/4/1372',
      description: ''
    },
    {
      id: 4,
      avatar: 'https://via.placeholder.com/120',
      name: 'الأمير نايف بن عبد العزيز',
      subtitle: '',
      dateFrom: '3/4/1372',
      dateTo: '25/8/1374',
      description: ''
    },
    {
      id: 5,
      avatar: 'assets/images/princes/prince-5.jpg',
      name: 'الأمير سلمان بن عبد العزيز',
      subtitle: 'بالنيابة عن الأمير نايف',
      dateFrom: '11/7/1373',
      dateTo: '1374',
      description: ''
    },
    {
      id: 6,
      avatar: 'https://via.placeholder.com/120',
      name: 'الأمير سلمان بن عبد العزيز',
      subtitle: '',
      dateFrom: '25/8/1374',
      dateTo: '30/3/1380',
      description: ''
    },
    {
      id: 7,
      avatar: 'assets/images/princes/prince-6.jpg',
      name: 'الأمير تركى بن عبد العزيز',
      subtitle: 'بالنيابة عن الملك سلمان',
      dateFrom: '16/3/1377',
      dateTo: '10/5/1380',
      description: ''
    },

    {
      id: 8,
      avatar: 'assets/images/princes/prince-7.jpg',
      name: 'الأمير فواز بن عبد العزيز',
      subtitle: '',
      dateFrom: '7/7/1380',
      dateTo: '7/2/1381',
      description: ''
    },
    {
      id: 9,
      avatar: 'https://via.placeholder.com/120',
      name: 'الأمير بدر بن سعود بن عبد العزيز',
      subtitle: '',
      dateFrom: '1/4/1381',
      dateTo: '24/8/1382',
      description: ''
    },
    {
      id: 10,
      avatar: 'https://via.placeholder.com/120',
      name: 'الملك سلمان بن عبد العزيز',
      subtitle: '',
      dateFrom: '10/9/1382',
      dateTo: '9/12/1432',
      description: ''
    },
    {
      id: 11,
      avatar: 'assets/images/princes/prince-11.jpg',
      name: 'الأمير سطام بن عبد العزيز',
      subtitle: '',
      dateFrom: '9/12/1432',
      dateTo: '2/4/1434',
      description: ''
    },
    {
      id: 12,
      avatar: 'assets/images/princes/prince-12.jpg',
      name: 'الأمير خالد بن بندر بن عبد العزيز',
      subtitle: '',
      dateFrom: '4/4/1434',
      dateTo: '15/7/1435',
      description: ''
    },
    {
      id: 13,
      avatar: 'assets/images/princes/prince-13.jpg',
      name: 'الأمير تركى بن عبد الله بن عبد العزيز',
      subtitle: '',
      dateFrom: '15/7/1435',
      dateTo: '9/4/1436',
      description: ''
    },
    {
      id: 14,
      avatar: 'assets/images/princes/prince-14.jpg',
      name: 'الأمير فيصل بن بندر بن عبد العزيز',
      subtitle: '',
      dateFrom: '9/4/1436',
      dateTo: 'حتى الآن',
      description: ''
    }
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
