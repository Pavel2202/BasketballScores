import { Component, OnInit } from '@angular/core';
import { Team } from 'src/app/models/team';
import { TeamService } from 'src/app/services/team.service';

@Component({
  selector: 'app-offensive-teams-list',
  templateUrl: './offensive-teams-list.component.html',
  styleUrls: ['./offensive-teams-list.component.css'],
})
export class OffensiveTeamsListComponent implements OnInit {
  teams: Team[] = [];
  constructor(private teamsService: TeamService) {}

  ngOnInit(): void {
    this.teamsService.getBestOffensiveTeams().subscribe({
      next: (teams) => {
        this.teams = teams;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
