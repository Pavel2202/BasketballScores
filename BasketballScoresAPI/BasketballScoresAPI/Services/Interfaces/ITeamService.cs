namespace BasketballScoresAPI.Services.Interfaces
{
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Dtos.Response;

    public interface ITeamService
    {
        Task<IEnumerable<TeamDto>> GetAllTeams(TeamSearchCriteria search, TeamSortingCriteria sorting);

        Task<IEnumerable<TeamDto>> GetTheBestOffensiveTeams();

        Task<IEnumerable<TeamDto>> GetTheBestDefensiveTeams();

        Task<TeamDto> CreateTeam(CreateTeamDto teamDto);
    }
}
