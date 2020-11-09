import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CourseEvaluationFormComponent } from './course-evaluation-form.component';

describe('CourseEvaluationFormComponent', () => {
  let component: CourseEvaluationFormComponent;
  let fixture: ComponentFixture<CourseEvaluationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CourseEvaluationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CourseEvaluationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
