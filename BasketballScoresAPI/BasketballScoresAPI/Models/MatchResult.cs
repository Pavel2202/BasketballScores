namespace BasketballScoresAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MatchResult
    {
        public Guid Id { get; set; }

        [Required]
        public Guid HomeTeamId { get; set; }

        [Required]
        public Team HomeTeam { get; set; }

        public int HomeTeamScore { get; set; }

        [Required]
        public Guid AwayTeamId { get; set; }

        [Required]
        public Team AwayTeam { get; set; }

        public int AwayTeamScore { get; set; }

        public int TotalScore { get; set; }
    }
}
