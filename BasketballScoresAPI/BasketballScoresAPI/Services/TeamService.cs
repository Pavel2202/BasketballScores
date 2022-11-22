namespace BasketballScoresAPI.Services
{
    using BasketballScoresAPI.Data;
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Dtos.Response;
    using BasketballScoresAPI.Helper;
    using BasketballScoresAPI.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class TeamService : ITeamService
    {
        private readonly DataContext _context;

        public TeamService(DataContext context)
        {
            _context = context;
        }

        public async Task<TeamDto> CreateTeam(CreateTeamDto teamDto)
        {
            if (_context.Teams.Any(t => t.Name == teamDto.Name))
            {
                throw new Exception("Team with that name already exists.");
            }

            var team = teamDto.ToTeamEntity();
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            return team.ToTeamDto();
        }

        public async Task<IEnumerable<TeamDto>> GetAllTeams(TeamSearchCriteria search, TeamSortingCriteria sorting)
        {
            var entities = _context.Teams.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name))
            {
                entities = entities.Where(t => t.Name.ToLower().Contains(search.Name.ToLower()));
            }

            entities = sorting switch
            {
                TeamSortingCriteria.NameDesc => entities.OrderByDescending(t => t.Name),
                TeamSortingCriteria.PointsForAsc => entities.OrderBy(t => t.PointsFor),
                TeamSortingCriteria.PointsForDesc => entities.OrderByDescending(t => t.PointsFor),
                TeamSortingCriteria.PointsAganistAsc => entities.OrderBy(t => t.PointsAganist),
                TeamSortingCriteria.PointsAganistDesc => entities.OrderByDescending(t => t.PointsAganist),
                TeamSortingCriteria.NameAsc or _ => entities.OrderBy(t => t.Name),
            };

            var teams = await entities.ToListAsync();
            var result = new List<TeamDto>();

            foreach (var team in teams)
            {
                result.Add(team.ToTeamDto());
            }

            return result;
        }

        public async Task<IEnumerable<TeamDto>> GetTheBestDefensiveTeams()
        {
            var entities = await _context.Teams
                .OrderBy(t => t.PointsAganist)
                .Take(5)
                .ToListAsync();
            var result = new List<TeamDto>();

            foreach (var team in entities)
            {
                result.Add(team.ToTeamDto());
            }

            return result;
        }

        public async Task<IEnumerable<TeamDto>> GetTheBestOffensiveTeams()
        {
            var entities = await _context.Teams
                .OrderByDescending(t => t.PointsFor)
                .Take(5)
                .ToListAsync();
            var result = new List<TeamDto>();

            foreach (var team in entities)
            {
                result.Add(team.ToTeamDto());
            }

            return result;
        }
    }
}
