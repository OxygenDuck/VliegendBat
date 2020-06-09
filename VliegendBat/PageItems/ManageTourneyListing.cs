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
    public partial class ManageTourneyListing : UserControl
    {
        Tourney tourney = null;

        /// <summary>
        /// Create a new List item for the Tounrey Management page
        /// </summary>
        /// <param name="tourney">The tourney to associate with this list item</param>
        public ManageTourneyListing(Tourney tourney)
        {
            InitializeComponent();
            this.tourney = tourney;
            UpdateListing();
        }

        /// <summary>
        /// Update the list item with the current information
        /// </summary>
        public void UpdateListing()
        {
            lblStatus.Text = tourney.state.ToString();
            lblTourneyName.Text = tourney.name;
            lblParticipants.Text = tourney.players.Count.ToString();

            //Determine the amount of matches played
            int matchesPlayed = 0;
            foreach (Match match in tourney.matches)
            {
                if (match.matchState == MatchState.Finished || match.matchState == MatchState.RoundFinished || match.matchState == MatchState.Skip)
                {
                    matchesPlayed++;
                }
            }
            lblMatchesPlayed.Text = matchesPlayed.ToString() + "/" + tourney.matches.Count.ToString();        }

        //Button click to manage the matches for this tourney
        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(tourney);
        }
    }
}
