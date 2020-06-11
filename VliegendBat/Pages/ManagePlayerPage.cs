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
    public partial class ManagePlayerPage : UserControl
    {
        /// <summary>
        /// Create a new Manage Player Page
        /// </summary>
        public ManagePlayerPage()
        {
            InitializeComponent();

            //Update the page elements
            UpdateListing();
            Program.fromPlayerManager = true; //Let the program detect from a Player Statistics page that it came from a Manage Player page
        }

        /// <summary>
        /// Update Listing on the page
        /// </summary>
        public void UpdateListing()
        {
            //Clear all controls
            pnlPlayerList.Controls.Clear();

            for (int i = 0; i < Program.Players.Count; i++)
            {
                //Add a new list item
                ManagePlayerListing newListing = new ManagePlayerListing(Program.Players[i]);
                pnlPlayerList.Controls.Add(newListing);
                newListing.Location = new Point(0, (newListing.Height * i));

                newListing.lblIndex.Text = i.ToString();

                //Apply banded rows
                if (i % 2 == 0)
                {
                    newListing.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    newListing.BackColor = Color.FromArgb(200, 200, 200);
                }
            }
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Program.fromPlayerManager = false;
            MainWindow.SetPage(Pages.Dashboard);
        }

        //Button click to open create player screen
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            pnlPlayerList.Controls.Clear();
            pnlPlayerList.Controls.Add(new CreatePlayerScreen());
        }
    }
}
