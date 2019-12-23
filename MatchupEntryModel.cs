using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   /// <summary>
    /// Represents one team in matchup.
    //// </summary>
    public class MatchupEntryModel
    {   /// <summary>
        /// Represents one team in matchup.
        //// </summary>
        public TeamModel Team { get; set; }
        /// <summary>
        /// Represents the score for this pirticular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
