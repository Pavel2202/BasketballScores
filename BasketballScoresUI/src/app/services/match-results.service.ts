import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { MatchResult } from '../models/matchResult';

@Injectable({
  providedIn: 'root',
})
export class MatchResultsService {
  private url = 'MatchResults';
  constructor(private http: HttpClient) {}

  public getMatchResults(): Observable<MatchResult[]> {
    return this.http.get<MatchResult[]>(`${environment.apiUrl}/${this.url}`);
  }

  public getHighlightMatchResult(): Observable<MatchResult> {
    return this.http.get<MatchResult>(
      `${environment.apiUrl}/${this.url}/highlightMatchResult`
    );
  }
}
