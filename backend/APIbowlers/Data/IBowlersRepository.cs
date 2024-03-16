using System.Collections.Generic;

namespace APIbowlers.Data
{
    // Interface for accessing bowlers data
    public interface IBowlersRepository
    {
        // Method to get all bowlers
        IEnumerable<Bowlers> GetBowlers();

        // Method to get all teams
        IEnumerable<Teams> GetTeams();

        // Method to get bowlers with their associated team names
        IEnumerable<BowlerWithTeamName> GetBowlersWithTeamNames();
    }
}
