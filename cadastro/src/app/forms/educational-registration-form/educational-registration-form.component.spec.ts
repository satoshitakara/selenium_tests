import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EducationalRegistrationFormComponent } from './educational-registration-form.component';

describe('EducationalRegistrationFormComponent', () => {
  let component: EducationalRegistrationFormComponent;
  let fixture: ComponentFixture<EducationalRegistrationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EducationalRegistrationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EducationalRegistrationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
