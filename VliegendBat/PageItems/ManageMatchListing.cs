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
    public partial class ManageMatchListing : UserControl
    {
        //Variables
        bool expanded = false;

        //Associated Match for this controller
        public Match match = null;

        //Functionpointer for resizing the list in the container
        public Delegate ListFunctionPointer;

        /// <summary>
        /// Make a new match listing for the Manage Match page
        /// </summary>
        /// <param name="match">The match to associate with this controller</param>
        public ManageMatchListing(Match match)
        {
            InitializeComponent();
            this.match = match;
            Height = 75;

            UpdateListing();
        }

        //Update the listing item with current information from the match
        public void UpdateListing()
        {
            //TODO: Manage anything at all in here

            if (match.players[0] != null)
            {
                lblPlayerName1.Text = match.players[0].name;
            }
            else
            {
                lblPlayerName1.Text = "-";
            }

            if (match.players[1] != null)
            {
                lblPlayerName2.Text = match.players[1].name;
            }
            else
            {
                lblPlayerName2.Text = "-";
            }

            lblPlayers.Text = lblPlayerName1.Text + ", " + lblPlayerName2.Text;
            lblStatus.Text = match.matchState.ToString();
            if (match.winner != null)
            {
                lblWinner.Text = match.winner.name;
            }
            else
            {
                lblWinner.Text = "-";
            }
        }

        //Button click to expand the item
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                Height = 75;
                expanded = false;
            }
            else
            {
                Height = 150;
                expanded = true;
            }

            //Rescale the list in the container
            ListFunctionPointer.DynamicInvoke();
        }

        //TODO: All the match functionality
    }
}
