import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunicationInformationComponent } from './communication-information.component';

describe('CommunicationInformationComponent', () => {
  let component: CommunicationInformationComponent;
  let fixture: ComponentFixture<CommunicationInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommunicationInformationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CommunicationInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
