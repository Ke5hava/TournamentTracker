using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   /// <summary>
    /// Represent the Team formation.
    /// </summary>
    public class TeamModel
    {   /// <summary>
        /// Represent the List of Person in a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represent the Name of the team.
        /// </summary>
        public String TeamName { get; set; }
    }
}
