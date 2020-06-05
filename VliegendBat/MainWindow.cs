using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VliegendBat
{
    public enum Pages
    {
        Login,
        Dashboard,
        CreateTourney,
        ManageTourney,
        ManagePlayers,
        Signup
    }

    public partial class MainWindow : Form
    {
        //TODO: Set description for each page
        public MainWindow()
        {
            InitializeComponent();
            //Set global reference to this form
            Program.Window = this;

            //Show the Login page first
            SetPage(Pages.Login);
        }

        /// <summary>
        /// Set the shown page on the main window
        /// </summary>
        /// <param name="page">the page enum associated with the page you wish to open</param>
        static public void SetPage(Pages page)
        {
            //Get the correct usercontrol
            UserControl control = null;
            switch (page)
            {
                case Pages.Login: control = new LoginScreen(); break;
                case Pages.Dashboard: control = new Dashboard(); break;
                case Pages.CreateTourney: control = new CreateTourneyPage(); break;
                case Pages.ManageTourney: control = new ManageTourneyPage(); break;
                case Pages.ManagePlayers: control = new ManagePlayerPage(); break;
                case Pages.Signup: control = new EnterTourneyPage(); break;
            }

            //Set page to panel
            Program.Window.pnlContent.Controls.Clear();
            Program.Window.pnlContent.Controls.Add(control);
        }

        /// <summary>
        /// Set the shown page on the main window
        /// </summary>
        /// <param name="tourney">The tourney for use in a Manage Match Screen</param>
        static public void SetPage(Tourney tourney)
        {
            //Get the correct usercontrol
            UserControl control = new ManageMatchPage(tourney);

            //Set page to panel
            Program.Window.pnlContent.Controls.Clear();
            Program.Window.pnlContent.Controls.Add(control);
        }

        /// <summary>
        /// Set the shown page on the main window
        /// </summary>
        /// <param name="player">The player for use in a Player Statistics Page</param>
        static public void SetPage(Player player)
        {
            //Get the correct usercontrol
            UserControl control = new PlayerStatisticsPage(player);

            //Set page to panel
            Program.Window.pnlContent.Controls.Clear();
            Program.Window.pnlContent.Controls.Add(control);
        }
    }
}
