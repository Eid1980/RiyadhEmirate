import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicesGuideComponent } from './services-guide.component';

describe('ServicesGuideComponent', () => {
  let component: ServicesGuideComponent;
  let fixture: ComponentFixture<ServicesGuideComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServicesGuideComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ServicesGuideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
