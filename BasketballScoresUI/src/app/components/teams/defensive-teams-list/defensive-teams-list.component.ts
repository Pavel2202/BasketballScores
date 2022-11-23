import { Component, OnInit } from '@angular/core';
import { Team } from 'src/app/models/team';
import { TeamService } from 'src/app/services/team.service';

@Component({
  selector: 'app-defensive-teams-list',
  templateUrl: './defensive-teams-list.component.html',
  styleUrls: ['./defensive-teams-list.component.css']
})
export class DefensiveTeamsListComponent implements OnInit {
  teams: Team[] = [];
  constructor(private teamsService: TeamService) {}

  ngOnInit(): void {
    this.teamsService.getBestDefensiveTeams().subscribe({
      next: (teams) => {
        this.teams = teams;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
