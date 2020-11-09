import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CampRegistrationFormComponent } from './camp-registration-form.component';

describe('CampRegistrationFormComponent', () => {
  let component: CampRegistrationFormComponent;
  let fixture: ComponentFixture<CampRegistrationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CampRegistrationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CampRegistrationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
