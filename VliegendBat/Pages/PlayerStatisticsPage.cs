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
        /// Create an instance of the UserStatistics page
        /// </summary>
        /// <param name="player">The player of which you want to see the statistics</param>
        public PlayerStatisticsPage(Player player)
        {
            InitializeComponent();

            this.player = player;
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }

        //TODO: Literally everything for player statistics
    }
}
