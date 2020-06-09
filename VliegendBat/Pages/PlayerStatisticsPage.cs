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
    public partial class PlayerStatisticsPage : UserControl
    {
        //Player object to reference
        private Player player = null;
        
        /// <summary>
        /// Create a new UserStatistics page
        /// </summary>
        /// <param name="player">The player of which you want to see the statistics</param>
        public PlayerStatisticsPage(Player player)
        {
            InitializeComponent();

            this.player = player;
            UpdateStatistics();
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Program.fromPlayerManager)
            {
                MainWindow.SetPage(Pages.ManagePlayers);
                return;
            }
            MainWindow.SetPage(Pages.Dashboard);
        }
//TODO: Literally everything for player statistics
        /// <summary>
        /// Update the statistics shown on screen with current information about the player referenced
        /// </summary>
        public void UpdateStatistics()
        {
            lblPlayerName.Text = player.name;
            //TODO: the other statistics
        }

        
    }
}
