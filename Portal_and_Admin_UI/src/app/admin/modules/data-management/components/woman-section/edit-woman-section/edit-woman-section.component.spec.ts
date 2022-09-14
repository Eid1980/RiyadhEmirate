import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditWomanSectionComponent } from './edit-woman-section.component';

describe('EditWomanSectionComponent', () => {
  let component: EditWomanSectionComponent;
  let fixture: ComponentFixture<EditWomanSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditWomanSectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditWomanSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
