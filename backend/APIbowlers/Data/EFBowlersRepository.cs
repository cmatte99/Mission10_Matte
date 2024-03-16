using System.Collections.Generic;
using System.Linq;

namespace APIbowlers.Data
{
    // Repository implementation using Entity Framework for accessing bowlers data
    public class EFBowlersRepository : IBowlersRepository
    {
        private readonly BowlerContext _bowlerContext;

        // Constructor to initialize the repository with the database context
        public EFBowlersRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        // Get all bowlers from the database
        public IEnumerable<Bowlers> GetBowlers()
        {
            return _bowlerContext.Bowlers.ToList();
        }

        // Get all teams from the database
        public IEnumerable<Teams> GetTeams()
        {
            return _bowlerContext.Teams.ToList();
        }

        // Get bowlers with their associated team names from the database
        public IEnumerable<BowlerWithTeamName> GetBowlersWithTeamNames()
        {
            return _bowlerContext.Bowlers
                .Join(_bowlerContext.Teams,
                      bowler => bowler.TeamID,
                      team => team.TeamID,
                      // Combine bowler and team information into a BowlerWithTeamName object
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
