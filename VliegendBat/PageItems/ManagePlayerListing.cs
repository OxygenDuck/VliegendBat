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
    public partial class ManagePlayerListing : UserControl
    {
        //The player associated with this control
        public Player player = null;

        /// <summary>
        /// Make a new User listing for the Manage Users page
        /// </summary>
        /// <param name="player">The player to associate with this control</param>
        public ManagePlayerListing(Player player)
        {
            InitializeComponent();

            //Link the player and update item elements
            this.player = player;
            UpdateListing();
        }

        /// <summary>
        /// Update listing
        /// </summary>
        public void UpdateListing()
        {
            //Set name label
            lblPlayerName.Text = player.name;

            //Display the correct rights
            if (player.isAdmin)
            {
                cbxRights.SelectedIndex = 1;
            }
            else
            {
                cbxRights.SelectedIndex = 0;
            }
        }

        //Button click to save changes
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //change settings
            player.isAdmin = Convert.ToBoolean(cbxRights.SelectedIndex);

            //Save changes to storage
            Program.SavePlayers();

            //TODO: Update list on main page without resetting the scroll
        }

        //Button click to show user statistics
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(player);
        }
        
        //Button click to remove player
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            //Ask for approval
            DialogResult result = MessageBox.Show("Weet je zeker dat je deze speler wil verwijderen?", "Waarschuwing", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Remove player
                Program.Players.Remove(player);
                MessageBox.Show("De speler is verwijderd", "Informatie");

                //Save players
                Program.SavePlayers();

                //TODO: CAN BE IGNORED: check all tourneys and matches to see if the player was registered anywhere
                //TODO: Update list on main page without resetting the scroll
            }
        }
    }
}
