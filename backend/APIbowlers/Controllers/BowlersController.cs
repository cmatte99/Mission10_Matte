//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using APIbowlers.Data;
//using System.Collections.Generic;

//namespace APIbowlers.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BowlersController : ControllerBase
//    {
//        private readonly IBowlersRepository _bowlersRepository;

//        public BowlersController(IBowlersRepository bowlersRepository)
//        {
//            _bowlersRepository = bowlersRepository;
//        }

//        // GET: api/Bowlers/bowlers
//        [HttpGet("bowlers")]
//        public IEnumerable<Bowlers> GetBowlers()
//        {
//            return _bowlersRepository.GetBowlers();
//        }

//        // GET: api/Bowlers/teams
//        [HttpGet("teams")]
//        public IEnumerable<Teams> GetTeams()
//        {
//            return _bowlersRepository.GetTeamssdss();
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using APIbowlers.Data;

namespace APIbowlers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlersRepository _bowlersRepository;

        public BowlersController(IBowlersRepository bowlersRepository)
        {
            _bowlersRepository = bowlersRepository;
        }

        [HttpGet("bowlers")]
        public IActionResult GetBowlers()
        {
            var bowlers = _bowlersRepository.GetBowlers();
            return Ok(bowlers);
        }

        [HttpGet("teams")]
        public IActionResult GetTeams()
        {
            var teams = _bowlersRepository.GetTeams();
            return Ok(teams);
        }

        [HttpGet("bowlers-with-teams")]
        public IActionResult GetBowlersWithTeamNames()
        {
            var bowlersWithTeamNames = _bowlersRepository.GetBowlersWithTeamNames();
            return Ok(bowlersWithTeamNames);
        }
    }
}
