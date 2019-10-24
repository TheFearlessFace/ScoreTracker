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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers  = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Theuns", LastName = "Zeeman" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Nel" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jan", LastName = "Rap" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Koos", LastName = "Janse" });
        }

        private void WireUpLists()
        {
            selectTeamMemberComboBox.DataSource = null;
           selectTeamMemberComboBox.DataSource = availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = "FullName";
            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }
        private void createMemeberButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameTextBox.Text;
                p.LastName = lastNameTextBox.Text;
                p.EmailAddress = emailAddressTextBox.Text;
                p.CellphoneNumber = cellphoneTextBox.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailAddressTextBox.Text = "";
                cellphoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            

            if (firstNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (emailAddressTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (cellphoneTextBox.Text.Length == 0)
            {
                output = false;
            }
            

            return output;
        }

        private void addMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberComboBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);

                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }

           
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();

            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
