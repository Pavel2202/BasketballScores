import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HighlightMatchResultComponent } from './highlight-match-result.component';

describe('HighlightMatchResultComponent', () => {
  let component: HighlightMatchResultComponent;
  let fixture: ComponentFixture<HighlightMatchResultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HighlightMatchResultComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HighlightMatchResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
