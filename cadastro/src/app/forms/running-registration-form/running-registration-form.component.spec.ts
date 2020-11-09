import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RunningRegistrationFormComponent } from './running-registration-form.component';

describe('RunningRegistrationFormComponent', () => {
  let component: RunningRegistrationFormComponent;
  let fixture: ComponentFixture<RunningRegistrationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RunningRegistrationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RunningRegistrationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
