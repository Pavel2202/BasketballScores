import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Team } from '../models/team';

@Injectable({
  providedIn: 'root',
})
export class TeamService {
  private url = 'Teams';
  constructor(private http: HttpClient) {}

  public getTeams(): Observable<Team[]> {
    return this.http.get<Team[]>(`${environment.apiUrl}/${this.url}`);
  }

  public getBestOffensiveTeams(): Observable<Team[]> {
    return this.http.get<Team[]>(
      `${environment.apiUrl}/${this.url}/offensiveTeams`
    );
  }

  public getBestDefensiveTeams(): Observable<Team[]> {
    return this.http.get<Team[]>(
      `${environment.apiUrl}/${this.url}/defensiveTeams`
    );
  }
}
