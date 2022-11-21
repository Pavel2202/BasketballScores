namespace BasketballScoresAPI.Controllers
{
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : Controller
    {
        private readonly ITeamService _service;

        public TeamsController(ITeamService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams([FromQuery] TeamSearchCriteria search, TeamSortingCriteria sorting)
        {
            var teams = await _service.GetAllTeams(search, sorting);

            return Ok(teams);
        }

        [HttpGet("offensiveTeams")]
        public async Task<IActionResult> GetTheBestOffensiveTeams()
        {
            var teams = await _service.GetTheBestOffensiveTeams();

            return Ok(teams);
        }

        [HttpGet("defensiveTeams")]
        public async Task<IActionResult> GetTheBestDefensiveTeams()
        {
            var teams = await _service.GetTheBestDefensiveTeams();

            return Ok(teams);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDto teamDto)
        {
            var team = await _service.CreateTeam(teamDto);

            return Ok(team);
        }
    }
}
