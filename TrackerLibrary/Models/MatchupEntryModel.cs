using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Unique id of MatchupEntry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// id for team
        /// </summary>
        public int TeamCompetingId{ get; set; }

        
        
        /// <summary>
        /// one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// score for this partucular team
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId { get; set; }
        /// <summary>
        /// matchup that this team came
        /// from ass the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}