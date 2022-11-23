import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchResultsListComponent } from './match-results-list.component';

describe('MatchResultsListComponent', () => {
  let component: MatchResultsListComponent;
  let fixture: ComponentFixture<MatchResultsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MatchResultsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MatchResultsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
