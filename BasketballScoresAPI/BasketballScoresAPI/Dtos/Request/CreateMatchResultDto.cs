namespace BasketballScoresAPI.Dtos.Request
{
    public class CreateMatchResultDto
    {
        public string HomeTeam { get; set; } = string.Empty;

        public string HomeTeamPoints { get; set; } = string.Empty;

        public string AwayTeam { get; set; } = string.Empty;

        public string AwayTeamPoints { get; set; } = string.Empty;
    }
}
