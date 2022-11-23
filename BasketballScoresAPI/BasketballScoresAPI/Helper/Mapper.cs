namespace BasketballScoresAPI.Helper
{
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Dtos.Response;
    using BasketballScoresAPI.Models;

    public static class Mapper
    {
        public static TeamDto ToTeamDto(this Team team)
        {
            var dto = new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                PointsFor = team.PointsFor,
                PointsAganist = team.PointsAganist
            };
            return dto;
        }

        public static Team ToTeamEntity(this CreateTeamDto teamDto)
        {
            var team = new Team
            {
                Name = teamDto.Name,
                PointsFor = 0,
                PointsAganist = 0
            };
            return team;
        }

        public static MatchResultDto ToMatchResultDto(this MatchResult matchResult)
        {
            var dto = new MatchResultDto
            {
                HomeTeam = matchResult.HomeTeam.Name,
                AwayTeam = matchResult.AwayTeam.Name,
                Result = $"{matchResult.HomeTeamScore}:{matchResult.AwayTeamScore}"
            };
            return dto;
        }

        public static MatchResult ToMatchResultEntity(this CreateMatchResultDto matchResultDto, 
            Team homeTeam, 
            int homeTeamPoints, 
            Team awayTeam,
            int awayTeamPoints)
        {
            var matchResult = new MatchResult
            {
                HomeTeam = homeTeam,
                HomeTeamScore = homeTeamPoints,
                AwayTeam = awayTeam,
                AwayTeamScore = awayTeamPoints,
                TotalScore = homeTeamPoints + awayTeamPoints
            };
            return matchResult;
        }
    }
}
