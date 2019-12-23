using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   /// <summary>
    /// Represent the Tournament info.
    /// </summary>
    public class TournamentModel
    {   /// <summary>
        /// Represent the name of the Tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represent the team entering the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represent the rounds played by team in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
