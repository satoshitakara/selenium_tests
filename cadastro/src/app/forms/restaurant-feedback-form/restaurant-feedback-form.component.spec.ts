import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RestaurantFeedbackFormComponent } from './restaurant-feedback-form.component';

describe('RestaurantFeedbackFormComponent', () => {
  let component: RestaurantFeedbackFormComponent;
  let fixture: ComponentFixture<RestaurantFeedbackFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestaurantFeedbackFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestaurantFeedbackFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
