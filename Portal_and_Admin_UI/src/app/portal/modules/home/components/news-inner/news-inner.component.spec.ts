import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewsInnerComponent } from './news-inner.component';

describe('NewsInnerComponent', () => {
  let component: NewsInnerComponent;
  let fixture: ComponentFixture<NewsInnerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewsInnerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewsInnerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
