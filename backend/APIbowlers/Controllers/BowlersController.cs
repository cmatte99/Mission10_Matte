using Microsoft.AspNetCore.Mvc;
using APIbowlers.Data;

namespace APIbowlers.Controllers
{
    // Controller for handling requests related to bowlers
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlersRepository _bowlersRepository;

        // Constructor to inject the repository dependency
        public BowlersController(IBowlersRepository bowlersRepository)
        {
            _bowlersRepository = bowlersRepository;
        }

        // Endpoint to retrieve all bowlers
        [HttpGet("bowlers")]
        public IActionResult GetBowlers()
        {
            var bowlers = _bowlersRepository.GetBowlers();
            return Ok(bowlers);
        }

        // Endpoint to retrieve all teams
        [HttpGet("teams")]
        public IActionResult GetTeams()
        {
            var teams = _bowlersRepository.GetTeams();
            return Ok(teams);
        }

        // Endpoint to retrieve bowlers with their associated team names
        [HttpGet("bowlers-with-teams")]
        public IActionResult GetBowlersWithTeamNames()
        {
            var bowlersWithTeamNames = _bowlersRepository.GetBowlersWithTeamNames();
            return Ok(bowlersWithTeamNames);
        }
    }
}
