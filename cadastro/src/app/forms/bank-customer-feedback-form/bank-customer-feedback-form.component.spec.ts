import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BankCustomerFeedbackFormComponent } from './bank-customer-feedback-form.component';

describe('BankCustomerFeedbackFormComponent', () => {
  let component: BankCustomerFeedbackFormComponent;
  let fixture: ComponentFixture<BankCustomerFeedbackFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BankCustomerFeedbackFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BankCustomerFeedbackFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
