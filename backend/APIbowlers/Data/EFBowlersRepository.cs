//using System.Collections.Generic;
//using System.Linq;

//namespace APIbowlers.Data
//{
//    public class EFBowlersRepository : IBowlersRepository
//    {
//        private readonly BowlerContext _bowlerContext;

//        public EFBowlersRepository(BowlerContext temp)
//        {
//            _bowlerContext = temp;
//        }

//        // Implementing properties
//        public IEnumerable<Bowlers> bowlers => _bowlerContext.Bowlers.ToList();
//        public IEnumerable<Teams> teams => _bowlerContext.Teams.ToList();

//        // Implementing methods
//        public IEnumerable<Bowlers> GetBowlers()
//        {
//            return _bowlerContext.Bowlers.ToList();
//        }

//        public IEnumerable<Teams> GetTeams()
//        {
//            return _bowlerContext.Teams.ToList();
//        }
//    }
//}
using System.Collections.Generic;
using System.Linq;

namespace APIbowlers.Data
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private readonly BowlerContext _bowlerContext;

        public EFBowlersRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowlers> GetBowlers()
        {
            return _bowlerContext.Bowlers.ToList();
        }

        public IEnumerable<Teams> GetTeams()
        {
            return _bowlerContext.Teams.ToList();
        }

        public IEnumerable<BowlerWithTeamName> GetBowlersWithTeamNames()
        {
            return _bowlerContext.Bowlers
                .Join(_bowlerContext.Teams,
                      bowler => bowler.TeamID,
                      team => team.TeamID,
                      (bowler, team) => new BowlerWithTeamName
                      {
                          BowlerId = bowler.BowlerId,
                          BowlerFirstName = bowler.BowlerFirstName,
                          BowlerMiddleName = bowler.BowlerMiddleInit,
                          BowlerLastName = bowler.BowlerLastName,
                          BowlerAddress = bowler.BowlerAddress,
                          BowlerCity = bowler.BowlerCity,
                          BowlerState = bowler.BowlerState,
                          BowlerZip = bowler.BowlerZip,
                          BowlerPhone = bowler.BowlerPhoneNumber,
                          TeamName = team.TeamName
                      })
                .ToList();
        }
    }
}
