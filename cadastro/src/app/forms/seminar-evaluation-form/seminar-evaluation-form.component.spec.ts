import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SeminarEvaluationFormComponent } from './seminar-evaluation-form.component';

describe('SeminarEvaluationFormComponent', () => {
  let component: SeminarEvaluationFormComponent;
  let fixture: ComponentFixture<SeminarEvaluationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SeminarEvaluationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SeminarEvaluationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
