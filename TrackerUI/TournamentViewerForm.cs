using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            WireUpLists();
            LoadFormData();
            LoadRounds();
            
        }

        private void LoadFormData()
        {
            tournamentNameLabel.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundComboBox.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }
        
        private void LoadRounds()
        {
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
            
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundComboBox.SelectedItem);
            
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear(); //todo: fix matchups not yet updated after first round finished
                    foreach(MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }
                    
                }
            }
            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneLabel.Visible = isVisible;
            teamOneScoreTextBox.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamTwoLabel.Visible = isVisible;
            teamTwoScoreTextBox.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            vursesLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }
        private void ClearScoreValues()
        {
            teamOneScoreTextBox.Text = "";
            teamOneScoreLabel.Text = "";
            teamOneLabel.Text = "";
            teamTwoScoreTextBox.Text = "";
            teamTwoScoreLabel.Text = "";
            teamTwoLabel.Text = "";
        }
        private void LoadMatchup(MatchupModel m)
        {
            ClearScoreValues();
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamOneScoreTextBox.Text = m.Entries[0].Score.ToString();



                            teamTwoLabel.Text = "<bye>";
                            teamTwoScoreTextBox.Text = "0";
                        }
                        else
                        {
                            teamOneLabel.Text = "Not yet set.";
                            teamOneScoreTextBox.Text = "";
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            teamTwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                            teamTwoScoreTextBox.Text = m.Entries[1].Score.ToString();


                        }
                        else
                        {
                            
                            teamTwoLabel.Text = "Not yet set.";
                            teamTwoScoreTextBox.Text = "";
                        }
                    }
                    
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
            
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundComboBox.SelectedItem);

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        //teamOneLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        bool scoreValid = double.TryParse(teamOneScoreTextBox.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = double.Parse(teamOneScoreTextBox.Text); 
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }

                    }
                    
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreTextBox.Text, out teamTwoScore);
                        
                        
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + ex);
            }
            

            LoadMatchups((int)roundComboBox.SelectedItem);



            //GlobalConfig.Connection.UpdateRounds();
        }


    }
}
