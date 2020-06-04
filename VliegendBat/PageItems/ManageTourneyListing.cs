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
            //TODO: Print the amount of matches to lblMatches
        }

        //Button click to manage the matches for this tourney
        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(tourney);
        }
    }
}
