using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   /// <summary>
    /// Represents the Prize Distribution/Declaration.
    /// </summary>
     public class PrizeModel
    {   /// <summary>
        /// Represent the Place held by team/player in numbers.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represent the Place held by team/player in Words.
        /// </summary>
        public string PlaceName { get; set; }
    } 
}
