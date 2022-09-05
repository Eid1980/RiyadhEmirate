import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegionPrincesComponent } from './region-princes.component';

describe('RegionPrincesComponent', () => {
  let component: RegionPrincesComponent;
  let fixture: ComponentFixture<RegionPrincesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegionPrincesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegionPrincesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
