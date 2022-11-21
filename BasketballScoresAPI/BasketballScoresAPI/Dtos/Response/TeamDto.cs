namespace BasketballScoresAPI.Dtos.Response
{
    public class TeamDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int PointsFor { get; set; }

        public int PointsAganist { get; set; }
    }
}
