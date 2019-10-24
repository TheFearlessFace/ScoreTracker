﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);

        void UpdateMatchup(MatchupModel model);

        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
    }
}
