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
            //Check if a tourney already exists under the given name
            foreach (Tourney tourney in Program.Tourneys)
            {
                if (tourney.name == tbxName.Text)
                {
                    MessageBox.Show("Er bestaat al een toernooi onder deze naam", "Waarschuwing");
                    return;
                }
            }

            //TODO: Save Tourney to storage
            Program.Tourneys.Add(new Tourney(tbxName.Text, "NotStarted"));
            MainWindow.SetPage(Pages.Dashboard);
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
