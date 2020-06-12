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
    public partial class EnterTourneyPage : UserControl
    {
        /// <summary>
        /// Creates a new Enter Tourney page
        /// </summary>
        public EnterTourneyPage()
        {
            InitializeComponent();

            //Update page elements
            UpdateListing();
        }

        /// <summary>
        /// Updates the listing of the page
        /// </summary>
        public void UpdateListing()
        {
            //Get all unstarted tourneys
            List<Tourney> unstartedTourneys = new List<Tourney>();
            foreach (Tourney tourney in Program.Tourneys)
            {
                if (tourney.state == TourneyState.NotStarted) unstartedTourneys.Add(tourney);
            }

            //Clear all controls
            pnlTourneyList.Controls.Clear();

            for (int i = 0; i < unstartedTourneys.Count; i++)
            {
                //Create a new list item
                SignupTourneyListing listing = new SignupTourneyListing(unstartedTourneys[i]);
                pnlTourneyList.Controls.Add(listing);
                listing.Location = new Point(0, 0 + (listing.Height * i));

                //Apply banded rows
                listing.lblIndex.Text = i.ToString();
                if (i % 2 == 0)
                {
                    listing.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    listing.BackColor = Color.FromArgb(200, 200, 200);
                }
            }
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
