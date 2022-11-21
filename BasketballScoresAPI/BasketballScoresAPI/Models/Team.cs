namespace BasketballScoresAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public Team()
        {
            Results = new List<MatchResult>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int PointsFor { get; set; }

        public int PointsAganist { get; set; }

        public ICollection<MatchResult> Results { get; set; }
    }
}
