import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReasearchFormComponent } from './reasearch-form.component';

describe('ReasearchFormComponent', () => {
  let component: ReasearchFormComponent;
  let fixture: ComponentFixture<ReasearchFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReasearchFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReasearchFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
