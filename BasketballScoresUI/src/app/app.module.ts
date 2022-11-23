import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TeamsListComponent } from './components/teams/teams-list/teams-list.component';
import { OffensiveTeamsListComponent } from './components/teams/offensive-teams-list/offensive-teams-list.component';
import { DefensiveTeamsListComponent } from './components/teams/defensive-teams-list/defensive-teams-list.component';
import { MatchResultsListComponent } from './components/matchResults/match-results-list/match-results-list.component';
import { HighlightMatchResultComponent } from './components/matchResults/highlight-match-result/highlight-match-result.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamsListComponent,
    OffensiveTeamsListComponent,
    DefensiveTeamsListComponent,
    MatchResultsListComponent,
    HighlightMatchResultComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
