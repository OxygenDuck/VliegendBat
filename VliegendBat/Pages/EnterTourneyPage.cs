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
        /// Creates a new listing of the enter tourney page
        /// </summary>
        public EnterTourneyPage()
        {
            InitializeComponent();
            UpdateListing();
        }

        /// <summary>
        /// Updates the listing of the page
        /// </summary>
        public void UpdateListing()
        {
            pnlTourneyList.Controls.Clear();

            for (int i = 0; i < Program.Tourneys.Count; i++)
            {
                if (Program.Tourneys[i].state == TourneyState.NotStarted)
                {
                    SignupTourneyListing listing = new SignupTourneyListing(Program.Tourneys[i]);
                    pnlTourneyList.Controls.Add(listing);
                    listing.Location = new Point(0, 0 + (listing.Height * i));
                    listing.UpdateListing();

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
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
