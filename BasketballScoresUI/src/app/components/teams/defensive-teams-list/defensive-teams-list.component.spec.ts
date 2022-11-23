import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DefensiveTeamsListComponent } from './defensive-teams-list.component';

describe('DefensiveTeamsListComponent', () => {
  let component: DefensiveTeamsListComponent;
  let fixture: ComponentFixture<DefensiveTeamsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DefensiveTeamsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DefensiveTeamsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
