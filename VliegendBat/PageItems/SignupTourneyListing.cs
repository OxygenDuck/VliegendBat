using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VliegendBat
{
    public partial class SignupTourneyListing : UserControl
    {
        Tourney tourney = null;

        /// <summary>
        /// Creates a new listing for the tourney signup page
        /// </summary>
        /// <param name="tourney">The tourney to associate with this listing</param>
        public SignupTourneyListing(Tourney tourney)
        {
            InitializeComponent();

            //Link the tourney given and update the elements
            this.tourney = tourney;
            UpdateListing();
        }

        /// <summary>
        /// Update List item
        /// </summary>
        public void UpdateListing()
        {
            //Set labels with current information
            lblTourneyName.Text = tourney.name;
            lblStatus.Text = tourney.state.ToString();
            lblMatchesPlayed.Text = "0/" + tourney.matches.Count.ToString();

            //Disable the button if the player is already signed up
            btnSignUp.Enabled = !tourney.players.Contains(Program.CurrentPlayer);
            
        }

        //Button Click to sign up for tourney
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Enter the player into the tourney
            tourney.EnterPlayer(Program.CurrentPlayer);
            //Update the page items
            UpdateListing();
            //Save all tourneys
            Program.SaveTourneys();
        }
    }
}
