import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VolunteerSignupFormComponent } from './volunteer-signup-form.component';

describe('VolunteerSignupFormComponent', () => {
  let component: VolunteerSignupFormComponent;
  let fixture: ComponentFixture<VolunteerSignupFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VolunteerSignupFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VolunteerSignupFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
