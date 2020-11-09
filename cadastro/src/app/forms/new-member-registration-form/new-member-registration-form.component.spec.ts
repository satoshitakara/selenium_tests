import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewMemberRegistrationFormComponent } from './new-member-registration-form.component';

describe('NewMemberRegistrationFormComponent', () => {
  let component: NewMemberRegistrationFormComponent;
  let fixture: ComponentFixture<NewMemberRegistrationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewMemberRegistrationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewMemberRegistrationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
