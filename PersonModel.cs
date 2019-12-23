using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   /// <summary>
    /// Represent the player entry info.
    /// </summary>
    public class PersonModel
    {   /// <summary>
        /// Represent the First Name of the Player. 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represent the Last Name of the Player. 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represent the Email Address of the Player. 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represent the Contact Number of the Player.
        /// </summary>
        public string ContactNumber { get; set; }
    }
}
