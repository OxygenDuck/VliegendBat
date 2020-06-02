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
        ManageMatches,
        ManagePlayers,
        Signup,
        Statistics
    }

    public partial class MainWindow : Form
    {
        //TODO: Set description for each page
        public MainWindow()
        {
            InitializeComponent();
            //Set global reference to this form
            Program.window = this;

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
                case Pages.CreateTourney: control = new CreateTourneyScreen(); break;
                case Pages.ManageTourney: control = new ManageTourneyScreen(); break;
                //TODO: Set link to given match here
                case Pages.ManageMatches: control = new ManageMatchScreen(""); break;
                case Pages.ManagePlayers: control = new ManagePlayerScreen(); break;
                case Pages.Signup: control = new EnterTourneyPage(); break;
                //TODO: Set link to given player here
                case Pages.Statistics: control = new PlayerStatisticsPage(""); break;
            }

            //Set page to panel
            Program.window.pnlContent.Controls.Clear();
            Program.window.pnlContent.Controls.Add(control);
        }
    }
}
