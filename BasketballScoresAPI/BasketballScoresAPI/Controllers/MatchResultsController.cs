namespace BasketballScoresAPI.Controllers
{
    using BasketballScoresAPI.Dtos.Request;
    using BasketballScoresAPI.Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class MatchResultsController : Controller
    {
        private readonly IMatchResultService _service;

        public MatchResultsController(IMatchResultService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMatchResult()
        {
            var matchResults = await _service.GetAllMatchResults();

            return Ok(matchResults);
        }

        [HttpGet("highlightMatchResult")]
        public async Task<IActionResult> GetHighlightResult()
        {
            var matchResult = await _service.GetHighlightMatchResult();

            return Ok(matchResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatchResult(CreateMatchResultDto matchResultDto)
        {
            try
            {
                var matchResult = await _service.CreateMatchResult(matchResultDto);
                return Ok(matchResult);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
