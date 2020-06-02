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
    public partial class ManageMatchScreen : UserControl
    {
        //TODO: link to tourney instead of name string
        private string tourney = "";

        //TODO: link to tourney instead of name string
        /// <summary>
        /// Create a new instance of the Manage Match Screen
        /// </summary>
        /// <param name="tourney"></param>
        public ManageMatchScreen(string tourney)
        {
            InitializeComponent();
            this.tourney = tourney;
        }

        //Button Click to return to Tourney List
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.ManageTourney);
        }
    }
}
