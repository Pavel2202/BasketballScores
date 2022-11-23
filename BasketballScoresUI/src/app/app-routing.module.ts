import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamsListComponent } from './components/teams/teams-list/teams-list.component';
import { OffensiveTeamsListComponent } from './components/teams/offensive-teams-list/offensive-teams-list.component';
import { DefensiveTeamsListComponent } from './components/teams/defensive-teams-list/defensive-teams-list.component';
import { MatchResultsListComponent } from './components/matchResults/match-results-list/match-results-list.component';
import { HighlightMatchResultComponent } from './components/matchResults/highlight-match-result/highlight-match-result.component';

const routes: Routes = [
  {
    path: 'teams',
    component: TeamsListComponent,
  },
  {
    path: 'bestOffensiveTeams',
    component: OffensiveTeamsListComponent,
  },
  {
    path: 'bestDefensiveTeams',
    component: DefensiveTeamsListComponent,
  },
  {
    path: 'matchResults',
    component: MatchResultsListComponent,
  },
  {
    path: 'highlightMatch',
    component: HighlightMatchResultComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
