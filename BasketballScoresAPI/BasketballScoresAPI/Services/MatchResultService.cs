namespace BasketballScoresAPI.Services
{
    using BasketballScoresAPI.Data;
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Dtos.Response;
    using BasketballScoresAPI.Helper;
    using BasketballScoresAPI.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MatchResultService : IMatchResultService
    {
        private readonly DataContext _context;

        public MatchResultService(DataContext context)
        {
            _context = context;
        }

        public async Task<MatchResultDto> CreateMatchResult(CreateMatchResultDto matchResultDto)
        {
            var homeTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Name == matchResultDto.HomeTeam);
            var awayTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Name == matchResultDto.AwayTeam);

            if (homeTeam is null)
            {
                throw new Exception("Home team not found.");
            }

            if (awayTeam is null)
            {
                throw new Exception("Away team not found.");
            }

            if (homeTeam.Name.Equals(awayTeam.Name))
            {
                throw new Exception("Teams cannot be the same.");
            }

            if (!int.TryParse(matchResultDto.HomeTeamPoints, out int homeTeamPoints))
            {
                throw new Exception("Home team points are not valid.");
            }

            if (!int.TryParse(matchResultDto.AwayTeamPoints, out int awayTeamPoints))
            {
                throw new Exception("Away team points are not valid.");
            }

            homeTeam.PointsFor += homeTeamPoints;
            homeTeam.PointsAganist += awayTeamPoints;

            awayTeam.PointsFor += awayTeamPoints;
            awayTeam.PointsAganist += homeTeamPoints;

            var matchResult = matchResultDto.ToMatchResultEntity(homeTeam, homeTeamPoints, awayTeam, awayTeamPoints);
            await _context.MatchResults.AddAsync(matchResult);
            await _context.SaveChangesAsync();

            return matchResult.ToMatchResultDto();
        }

        public async Task<IEnumerable<MatchResultDto>> GetAllMatchResults()
        {
            var entities = await _context.MatchResults.ToListAsync();
            var result = new List<MatchResultDto>();

            foreach (var matchResult in entities)
            {
                var homeTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Id == matchResult.HomeTeamId);
                var awayTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Id == matchResult.AwayTeamId);
                matchResult.HomeTeam = homeTeam;
                matchResult.AwayTeam = awayTeam;

                result.Add(matchResult.ToMatchResultDto());
            }

            return result;
        }

        public async Task<MatchResultDto> GetHighlightMatchResult()
        {
            var matchResult = await _context.MatchResults
                .OrderByDescending(t => t.HomeTeamScore + t.AwayTeamScore)
                .Take(1)
                .FirstOrDefaultAsync();

            var homeTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Id == matchResult.HomeTeamId);
            var awayTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Id == matchResult.AwayTeamId);
            matchResult.HomeTeam = homeTeam;
            matchResult.AwayTeam = awayTeam;

            return matchResult.ToMatchResultDto();
        }
    }
}
