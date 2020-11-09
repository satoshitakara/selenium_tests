import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GymMembershipFormComponent } from './gym-membership-form.component';

describe('GymMembershipFormComponent', () => {
  let component: GymMembershipFormComponent;
  let fixture: ComponentFixture<GymMembershipFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GymMembershipFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GymMembershipFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
