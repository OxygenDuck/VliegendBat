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
    public partial class CreateTourneyScreen : UserControl
    {
        public CreateTourneyScreen()
        {
            InitializeComponent();
        }
        
        //Button Click to save tourney
        private void btnSaveTourney_Click(object sender, EventArgs e)
        {
            //TODO: Save Tourney to storage
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
