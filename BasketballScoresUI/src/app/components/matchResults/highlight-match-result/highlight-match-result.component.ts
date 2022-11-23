import { Component, OnInit } from '@angular/core';
import { MatchResult } from 'src/app/models/matchResult';
import { MatchResultsService } from 'src/app/services/match-results.service';

@Component({
  selector: 'app-highlight-match-result',
  templateUrl: './highlight-match-result.component.html',
  styleUrls: ['./highlight-match-result.component.css'],
})
export class HighlightMatchResultComponent implements OnInit {
  highlightMatchResult: MatchResult = new MatchResult();
  constructor(private matchResultsService: MatchResultsService) {}

  ngOnInit(): void {
    this.matchResultsService.getHighlightMatchResult().subscribe({
      next: (highlightMatchResult) => {
        this.highlightMatchResult = highlightMatchResult;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
