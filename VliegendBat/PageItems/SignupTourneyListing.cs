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
        public SignupTourneyListing(Tourney tourney)
        {
            InitializeComponent();

            //associate this listing with the given Tourney
            this.tourney = tourney;
            UpdateListing();
        }

        //Update List item
        public void UpdateListing()
        {
            lblTourneyName.Text = tourney.name;
            lblStatus.Text = tourney.state.ToString();
            if (tourney.state == TourneyState.NotStarted)
            {
                lblMatchesPlayed.Text = "0/-";
            }
            if (tourney.players.Contains(Program.CurrentPlayer))
            {
                btnSignUp.Enabled = false;
            }
            else
            {
                btnSignUp.Enabled = true;
            }
        }

        //Button Click to sign up for tourney
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            tourney.EnterPlayer(Program.CurrentPlayer);
            UpdateListing();
            Program.SaveTourneys();
        }
    }
}
