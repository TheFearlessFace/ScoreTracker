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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        TournamentStatus tournamentStatus = new TournamentStatus(false);
        public CreateTournamentForm(TournamentStatus status)
        {
            tournamentStatus = status;
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectedTeamComboBox.DataSource = null;
            selectedTeamComboBox.DataSource = availableTeams;
            selectedTeamComboBox.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
 
            TeamModel t = (TeamModel)selectedTeamComboBox.SelectedItem;

            if (t!=null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {

            // Take the Prize Model and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();

        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if(t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeTextBox.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("you need to enter a valid entry fee.", "Invalid fee", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            //create our tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameTextBox.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // setup our matchups
            TournamentLogic.CreateRounds(tm);

            //create Tournament entry
            //create all of the prizes entries
            //create all of team entries
            //todo: save entry doesn;t work
            GlobalConfig.Connection.CreateTournament(tm);
            tournamentStatus.Created(true);
            MessageBox.Show("The tournament: "+ tm.TournamentName + " has been created successfully!");
            
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();

        }
    }
}
