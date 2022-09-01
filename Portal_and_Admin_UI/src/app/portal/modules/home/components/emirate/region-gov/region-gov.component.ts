import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-region-gov',
  templateUrl: './region-gov.component.html',
  styleUrls: ['./region-gov.component.scss']
})
export class RegionGovComponent implements OnInit {

  regionGov: any = [
    {
      id: 1,
      banner: 'assets/images/region-1.jpg',
      name: 'محافظة الدرعية',
      description:
        `
      هي المحافظة الأولى في المملكة و يحدها من الشمال محافظة حريملاء و من الجنوب محافظة ضرما ومدينة الرياض و من الشرق مدينة الرياض و من الغرب حريملاء و محافظة ضرما وتبلغ مساحتها 2020 كلم2 و يبلغ عدد سكانها 73668 نسمة ( ثلاثة وسبعون ألفا و ستمائة&nbsp;وثمانية وستون ) نسمة و هي عاصمة الدولة السعودية الأولى و الثانية و يوجد بها بيوت أثرية للأسرة السعودية المالكة بنيت قديما على أنقاض مدينة حجر عاصمة اليمامة . 
      `,
      phone: '011/4861400',
      location: 'https://www.riyadh.gov.sa/ar/PublishingImages/dareyah.jpg',
      website: 'http://www.aldoriyah.gov.sa/'
    },
    {
      id: 2,
      banner: 'assets/images/region-2.jpg',
      name: 'محافظة الخرج',
      description:
        `
      وتقع جنوب منطقة الرياض و يحدها من الشرق المنطقة الشرقية و من الغرب محافظة المزاحمية و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشمال مدينة الرياض . و تبلغ مساحتها 19790كلم2 و يبلغ عدد سكانها 376325 نسمة و من الآثار و الأماكن التاريخية بمحافظة الخرج ـ قصر مشرف ـ بلدة اليمامة
      `,
      phone: '011/5483800',
      location: 'https://www.riyadh.gov.sa/ar/PublishingImages/kharg.jpg',
      website: 'http://www.alkharj.gov.sa/'
    },
    {
      id: 3,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الدوادمى',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 4,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة المجمعة',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 5,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة القويعية',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 6,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة وادي الدواسر',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 7,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الأفلاج',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 8,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الزلفى',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 9,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة شقراء',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 10,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة حوطة بنى تميم',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 11,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة عفيف',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 12,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة السليل',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 13,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة ضرما',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 14,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة المزاحمية',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 15,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة رماح',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 16,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة ثادق',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 17,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة حريملاء',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 18,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الحريق',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 19,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الغاط',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 20,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة مرات',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 21,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الدلم',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    },
    {
      id: 22,
      banner: 'https://via.placeholder.com/550x260',
      name: 'محافظة الرين',
      description:
        `لايوجد`,
      phone: '011/5483800',
      location: '#',
      website: '#'
    }
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
