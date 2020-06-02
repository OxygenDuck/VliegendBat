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
        //TODO: Link player instead of name string
        private string player = "";

        //TODO: Link player instead of name string
        /// <summary>
        /// Create an instance of the UserStatistics page
        /// </summary>
        /// <param name="playerName"></param>
        public PlayerStatisticsPage(string playerName)
        {
            InitializeComponent();

            player = playerName;
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
