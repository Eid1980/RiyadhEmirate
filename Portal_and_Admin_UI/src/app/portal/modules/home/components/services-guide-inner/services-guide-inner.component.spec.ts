import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicesGuideInnerComponent } from './services-guide-inner.component';

describe('ServicesGuideInnerComponent', () => {
  let component: ServicesGuideInnerComponent;
  let fixture: ComponentFixture<ServicesGuideInnerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServicesGuideInnerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ServicesGuideInnerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
