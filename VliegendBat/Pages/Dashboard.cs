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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            //Enable admin pages if the user is an admin
            grbAdmin.Enabled = Program.CurrentPlayer.isAdmin;
        }

        //Button Click to go to Create tourney Page
        private void btnCreateTourney_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.CreateTourney);
        }

        //Button Click to log out and go back to login screen
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //log out
            Program.CurrentPlayer = null;

            MainWindow.SetPage(Pages.Login);
        }

        //Button Click to go to Manage Tourney screen
        private void btnManageTourney_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.ManageTourney);
        }

        //Button Click to go to Manage Player screen
        private void btnManagePlayers_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.ManagePlayers);
        }

        //Button Click to go to Signup screen
        private void btnTourneySignup_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Signup);
        }

        //Button Click to go to Show Statistics screen
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Program.CurrentPlayer);
        }
    }
}
