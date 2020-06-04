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
    public partial class ManagePlayerScreen : UserControl
    {
        public ManagePlayerScreen()
        {
            InitializeComponent();

            UpdateListing();
        }

        public void UpdateListing()
        {
            pnlPlayerList.Controls.Clear();

            for (int i = 0; i < Program.Players.Count; i++)
            {
                ManageUserListing newListing = new ManageUserListing(Program.Players[i]);
                pnlPlayerList.Controls.Add(newListing);
                newListing.Location = new Point(0, (newListing.Height * i));

                newListing.lblIndex.Text = i.ToString();
                if (i % 2 == 0)
                {
                    newListing.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    newListing.BackColor = Color.FromArgb(200, 200, 200);
                }
            }
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.Dashboard);
        }
    }
}
