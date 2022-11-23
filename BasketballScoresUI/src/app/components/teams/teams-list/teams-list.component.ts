import { Component, OnInit } from '@angular/core';
import { Team } from 'src/app/models/team';
import { TeamService } from 'src/app/services/team.service';

@Component({
  selector: 'app-teams-list',
  templateUrl: './teams-list.component.html',
  styleUrls: ['./teams-list.component.css'],
})
export class TeamsListComponent implements OnInit {
  teams: Team[] = [];
  constructor(private teamsService: TeamService) {}

  ngOnInit(): void {
    this.teamsService.getTeams().subscribe({
      next: (teams) => {
        this.teams = teams;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
