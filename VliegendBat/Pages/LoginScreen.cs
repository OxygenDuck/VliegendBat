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
    public partial class LoginScreen : UserControl
    {
        /// <summary>
        /// Create a new instance of the login screen
        /// </summary>
        public LoginScreen()
        {
            InitializeComponent();
        }

        // Button click to log in
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check account before granting access
            foreach (Player player in Program.Players)
            {
                if (player.name == tbxUsername.Text)
                {
                    if (Login(player))
                    {
                        MainWindow.SetPage(Pages.Dashboard);
                    }
                    return;
                }
            }

            MessageBox.Show("Er bestaat geen speler genaamd " + tbxUsername.Text, "Waarschuwing");
        }

        /// <summary>
        /// Log in the given player
        /// </summary>
        /// <param name="player">The player to log in</param>
        /// <returns>true if the player has been logged in</returns>
        private bool Login(Player player)
        {
            if (tbxPassword.Text != StringCipher.Decrypt(player.password, player.name))
            {
                MessageBox.Show("De gebruikersnaam en wachtwoord komen niet overeen", "Waarschuwing");
                return false;
            }

            Program.CurrentPlayer = player;
            return true;
        }
    }
}
