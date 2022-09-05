import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegionGovComponent } from './region-gov.component';

describe('RegionGovComponent', () => {
  let component: RegionGovComponent;
  let fixture: ComponentFixture<RegionGovComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegionGovComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegionGovComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
