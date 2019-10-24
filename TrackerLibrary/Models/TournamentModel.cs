using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Unique identifier for tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the name given to this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The amount of money each team needs to put up to enter
        /// </summary>
        public decimal  EntryFee { get; set; }
        /// <summary>
        /// The set of teams that have ebeen entered
        /// </summary>
        public List<TrackerLibrary.Models.TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// the list of prizes for the various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// the matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
