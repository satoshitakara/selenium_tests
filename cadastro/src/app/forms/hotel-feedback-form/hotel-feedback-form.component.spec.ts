import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HotelFeedbackFormComponent } from './hotel-feedback-form.component';

describe('HotelFeedbackFormComponent', () => {
  let component: HotelFeedbackFormComponent;
  let fixture: ComponentFixture<HotelFeedbackFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HotelFeedbackFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HotelFeedbackFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
