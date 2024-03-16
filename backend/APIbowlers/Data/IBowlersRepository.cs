//namespace APIbowlers.Data
//{
//    public interface IBowlersRepository
//    {
//        IEnumerable<Bowlers> bowlers { get; }
//        IEnumerable<Teams> teams { get; }

//        IEnumerable<Bowlers> GetBowlers();
//        IEnumerable<Teams> GetTeams();
//    }
//}
using System.Collections.Generic;

namespace APIbowlers.Data
{
    public interface IBowlersRepository
    {
        IEnumerable<Bowlers> GetBowlers();
        IEnumerable<Teams> GetTeams();
        IEnumerable<BowlerWithTeamName> GetBowlersWithTeamNames();
    }
}
