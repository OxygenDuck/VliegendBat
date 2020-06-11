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
    public partial class CreatePlayerScreen : UserControl
    {
        /// <summary>
        /// Create a new instance of the Create Player Screen
        /// </summary>
        public CreatePlayerScreen()
        {
            InitializeComponent();
        }

        //Button click to create player
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Check to see the given name is already taken
            foreach (Player player in Program.Players)
            {
                if (player.name == tbxUsername.Text)
                {
                    MessageBox.Show("Er bestaat al een speler met die gebruikersnaam", "Waarschuwing");
                    return;
                }
            }

            //Check if the username or password are left empty
            if (tbxUsername.Text == "")
            {
                MessageBox.Show("De gebruikersnaam is niet ingevuld", "Waarschuwing");
                return;
            }
            if (tbxPassword.Text == "")
            {
                MessageBox.Show("Het wachtwoord is nog niet ingevuld", "Waarschuwing");
                return;
            }
            
            //Create the new player
            string password = StringCipher.Encrypt(tbxPassword.Text, tbxUsername.Text);
            Program.Players.Add(new Player(tbxUsername.Text, password));
            MessageBox.Show("De nieuwe speler '" + tbxUsername.Text + "' is aangemaakt", "Informatie");

            //Save players
            Program.SavePlayers();

            //Return to Manage Players Page
            MainWindow.SetPage(Pages.ManagePlayers);
        }

        //Button click to return to manage players page
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.SetPage(Pages.ManagePlayers);
        }
    }
}
