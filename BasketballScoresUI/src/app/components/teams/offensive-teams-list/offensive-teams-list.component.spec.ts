import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OffensiveTeamsListComponent } from './offensive-teams-list.component';

describe('OffensiveTeamsListComponent', () => {
  let component: OffensiveTeamsListComponent;
  let fixture: ComponentFixture<OffensiveTeamsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OffensiveTeamsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OffensiveTeamsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
