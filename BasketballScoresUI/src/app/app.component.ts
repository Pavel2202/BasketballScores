import { Component } from '@angular/core';
import { Team } from './models/team';
import { TeamService } from './services/team.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'BasketballScoresUI';
  teams: Team[] = [];
  teamToCreate?: Team;

  constructor() {}
}
