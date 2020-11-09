import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { YogaFormComponent } from './yoga-form.component';

describe('YogaFormComponent', () => {
  let component: YogaFormComponent;
  let fixture: ComponentFixture<YogaFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ YogaFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(YogaFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
