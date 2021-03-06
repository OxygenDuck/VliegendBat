﻿using System;
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
    public partial class ManageTourneyPage : UserControl
    {
        /// <summary>
        /// Create a new Manage Tourney Page
        /// </summary>
        public ManageTourneyPage()
        {
            InitializeComponent();

            //Set the page list items
            UpdateListing();
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }

        /// <summary>
        /// Update the tourney listing
        /// </summary>
        public void UpdateListing()
        {
            //Clear all controls
            pnlTourneyList.Controls.Clear();

            for (int i = 0; i < Program.Tourneys.Count; i++)
            {
                //Add a new list item
                ManageTourneyListing listing = new ManageTourneyListing(Program.Tourneys[i]);
                pnlTourneyList.Controls.Add(listing);
                listing.Location = new Point(0, 0 + (listing.Height * i));

                listing.lblIndex.Text = i.ToString();

                //Apply banded rows
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
}
