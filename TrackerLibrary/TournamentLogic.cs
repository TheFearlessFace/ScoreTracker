using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // order randomly list teams
        // check if it is big enough - if not, add byes 2*2*2*2 2^4
        // create our first round matchups
        // creat every matchup round after that 8  4  2  1 

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);

            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);

        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rMatchup in round)
                {
                    if (rMatchup.Winner == null && (rMatchup.Entries.Any(x => x.Score != 0) || rMatchup.Entries.Count == 1))
                    {
                        toScore.Add(rMatchup);
                    }
                }
            }

            MarkWinnersInMatchups(toScore);

            AdvanceWinners(toScore,model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));

        }

        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                int roundCount = 1;
                List<MatchupModel> previousRound = new List<MatchupModel>();

                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rMatchup in round)
                    {

                        foreach (MatchupEntryModel me in rMatchup.Entries)
                        {
                            if (roundCount > 1)
                            //if (me.ParentMatchup != null)//parentmatchup = matchup by id?
                            {
                                if (me.ParentMatchup == null)
                                {

                                    try
                                    {
                                        me.ParentMatchup = previousRound.Where(x => x.Id == me.ParentMatchupId).First();
                                    }
                                    catch (Exception ex)//Todo: do something about exeption
                                    {
                                        string strex = ex.ToString();
                                        try
                                        {
                                            me.ParentMatchup = previousRound.FirstOrDefault();
                                        }
                                        catch (Exception ex2)
                                        {

                                            throw new Exception(ex2.ToString());
                                        }
                                    }
                                }
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rMatchup);
                                }
                            }
                        }
                    }
                    previousRound = round;
                    roundCount++; 
                }
            }
            
        }
        private static void MarkWinnersInMatchups(List<MatchupModel> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                //Checks for bye week entry
                if(m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                //0 means false, or low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if(m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application as yet.");
                    }
                }
                else
                {
                    //1 mean true, or high score wins
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application as yet.");
                    }
                    
                } 
            }
            //if (teamOneScore > teamTwoScore)
            //{
            //    m.Winner = m.Entries[0].TeamCompeting;
            //}
            //else if (teamOneScore < teamTwoScore)
            //{
            //    m.Winner = m.Entries[1].TeamCompeting;
            //}
            //else
            //{
            //    MessageBox.Show("I do not handle tie games.");
            //}
        }
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });
                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
