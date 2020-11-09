import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BabysitterFormComponent } from './babysitter-form.component';

describe('BabysitterFormComponent', () => {
  let component: BabysitterFormComponent;
  let fixture: ComponentFixture<BabysitterFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BabysitterFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BabysitterFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
