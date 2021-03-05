﻿using System;
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
        private ITeamRequester callingForm;
        //go to "Select Team Member" dropdown
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        //go to "teamMemberListBox"
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            
            callingForm = caller;

            //  CreateSampleData();

            WireUpLists();

        }


        //private void CreateSampleData()
        //{
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Nancy", LastName = "Wu" });
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Mark", LastName = "Long" });
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Sophie", LastName = "Chen" });
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Tom", LastName = "Corey" });

        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Jerry", LastName = "He" });
        //}

        private void WireUpLists()
        {
            // Refresh
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListbox.DataSource = null;

            teamMembersListbox.DataSource = selectedTeamMembers;
            teamMembersListbox.DisplayMember = "FullName";
        }



        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();


                //clear out
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListbox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                WireUpLists(); 
            }

        }


        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists(); 
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
