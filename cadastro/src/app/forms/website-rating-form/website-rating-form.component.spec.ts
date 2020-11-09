import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WebsiteRatingFormComponent } from './website-rating-form.component';

describe('WebsiteRatingFormComponent', () => {
  let component: WebsiteRatingFormComponent;
  let fixture: ComponentFixture<WebsiteRatingFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WebsiteRatingFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebsiteRatingFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
