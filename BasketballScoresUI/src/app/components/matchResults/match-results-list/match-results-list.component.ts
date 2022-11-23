import { Component, OnInit } from '@angular/core';
import { MatchResult } from 'src/app/models/matchResult';
import { MatchResultsService } from 'src/app/services/match-results.service';

@Component({
  selector: 'app-match-results-list',
  templateUrl: './match-results-list.component.html',
  styleUrls: ['./match-results-list.component.css']
})
export class MatchResultsListComponent implements OnInit {
  matchResults: MatchResult[] = [];
  constructor(private matchResultsService: MatchResultsService) {}

  ngOnInit(): void {
    this.matchResultsService.getMatchResults().subscribe({
      next: (matchResults) => {
        this.matchResults = matchResults;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
