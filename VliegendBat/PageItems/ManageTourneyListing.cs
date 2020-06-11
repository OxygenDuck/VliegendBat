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
        //The tourney pointer
        Tourney tourney = null;

        /// <summary>
        /// Create a new List item for the Tounrey Management page
        /// </summary>
        /// <param name="tourney">The tourney to associate with this list item</param>
        public ManageTourneyListing(Tourney tourney)
        {
            InitializeComponent();

            //Link the tourney to this item and update the elements
            this.tourney = tourney;
            UpdateListing();
        }

        /// <summary>
        /// Update the list item with the current information
        /// </summary>
        public void UpdateListing()
        {
            //Set labels
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

            //Display the amount of matches played
            lblMatchesPlayed.Text = matchesPlayed.ToString() + "/" + tourney.matches.Count.ToString();        }

        //Button click to manage the matches for this tourney
        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(tourney);
        }

        //Button click to remove tourney
        private void btnRemoveTourney_Click(object sender, EventArgs e)
        {
            //Remove a tourney from the list and update the item
            Program.Tourneys.Remove(tourney);
            UpdateListing(); //TODO: update the Manage Tourney page instead

            //Save changes to storage
            Program.SaveTourneys();
        }
    }
}
