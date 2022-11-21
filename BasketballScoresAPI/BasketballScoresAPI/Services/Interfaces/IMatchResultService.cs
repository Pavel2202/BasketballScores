namespace BasketballScoresAPI.Services.Interfaces
{
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Dtos.Response;

    public interface IMatchResultService
    {
        Task<IEnumerable<MatchResultDto>> GetAllMatchResults();

        Task<MatchResultDto> GetHighlightMatchResult();

        Task<MatchResultDto> CreateMatchResult(CreateMatchResultDto matchResultDto);
    }
}
