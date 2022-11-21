namespace BasketballScoresAPI.Dtos.Request
{
    using System.ComponentModel.DataAnnotations;

    public class CreateTeamDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
