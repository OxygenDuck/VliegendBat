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
    public partial class ManageMatchPage : UserControl
    {
        //The tourney to reference
        private Tourney tourney = null;
        
        /// <summary>
        /// Create a new Manage Match Page
        /// </summary>
        /// <param name="tourney">The tourney for which to see all of the matches</param>
        public ManageMatchPage(Tourney tourney)
        {
            InitializeComponent();

            //Reference the tourney and update the page elements
            this.tourney = tourney;
            pageFunctionPointer += new UpdateList(ResizeAndUpdateList); //Link a delegate in list items
            UpdateListing();
        }

        //Delegate to call a function from list items
        public delegate void UpdateList();
        private event UpdateList pageFunctionPointer;

        /// <summary>
        /// Update Match listing
        /// </summary>
        public void UpdateListing()
        {
            //clear all the controls before adding them all
            pnlMatchList.Controls.Clear();

            //creating controls
            for (int i = 0; i < tourney.matches.Count; i++)
            {
                //create a new control
                ManageMatchListing listing = new ManageMatchListing(tourney.matches[i]);
                pnlMatchList.Controls.Add(listing);
                
                listing.lblIndex.Text = i.ToString();
                listing.lblTourneyName.Text = tourney.name;

                //Apply banded rows
                if (i % 2 == 0)
                {
                    listing.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    listing.BackColor = Color.FromArgb(200, 200, 200);
                }
                
                //link resize function in control
                listing.ListFunctionPointer = pageFunctionPointer;
            }

            //Resize list
            ResizeAndUpdateList();
        }

        /// <summary>
        /// Resizes the match list
        /// </summary>
        public void ResizeAndUpdateList()
        {
            //Reset the height for the list items, make them position correctly
            int height = 0;
            for (int i = 0; i < tourney.matches.Count; i++)
            {
                Control listing = pnlMatchList.Controls[i];
                listing.Location = new Point(0, height);
                height += listing.Height;
            }

            //Update the list items
            foreach (ManageMatchListing listItem in pnlMatchList.Controls) listItem.UpdateListing();
        }

        //Button Click to return to Tourney List
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.ManageTourney);
        }
    }
}
