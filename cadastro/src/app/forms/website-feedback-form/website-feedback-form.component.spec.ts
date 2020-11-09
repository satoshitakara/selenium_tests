import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WebsiteFeedbackFormComponent } from './website-feedback-form.component';

describe('WebsiteFeedbackFormComponent', () => {
  let component: WebsiteFeedbackFormComponent;
  let fixture: ComponentFixture<WebsiteFeedbackFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WebsiteFeedbackFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebsiteFeedbackFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
