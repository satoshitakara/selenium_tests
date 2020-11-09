import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewContactUsFormComponent } from './new-contact-us-form.component';

describe('NewContactUsFormComponent', () => {
  let component: NewContactUsFormComponent;
  let fixture: ComponentFixture<NewContactUsFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewContactUsFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewContactUsFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
