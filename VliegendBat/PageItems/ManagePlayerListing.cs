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

            this.player = player;
            UpdateListing();
        }

        public void UpdateListing()
        {
            lblPlayerName.Text = player.name;
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
            //TODO: change settings
            //TODO: Save changes to storage
            Program.SavePlayers();
        }

        //Button click to show user statistics
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(player);
        }
    }
}
