using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; //Json library

namespace VliegendBat
{
    /// <summary>
    /// Program created by Peter Janssen, IC17ao.e
    /// Last update 12th of June 2020
    /// Version 0.2.2
    /// </summary>
    static class Program
    {
        //Global Variables
        static public MainWindow Window = null; //Reference to the main form
        static public bool fromPlayerManager = false; //Detect whether the user came from the Player Manager screen

        //List of Players
        static public List<Player> Players = new List<Player>();
        static public Player CurrentPlayer = null; //Player currently logged in

        //List of Tourneys
        static public List<Tourney> Tourneys = new List<Tourney>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadPlayers();
            LoadTourneys();
            Application.Run(new MainWindow());
        }

        /// <summary>
        /// Save all the players locally
        /// </summary>
        public static void SavePlayers()
        {
            //Failsafe to make sure the program is never left without an admin
            //Check if there is no player with administrator rights
            bool createNewAdmin = true;
            Player existingAdmin = null;
            foreach (Player player in Players)
            {
                if (player.isAdmin)
                {
                    createNewAdmin = false;
                }
                //search for a user named 'admin'
                if (player.name == "admin")
                {
                    existingAdmin = player;
                }
            }

            //If there is no-one with adminrights, make the account
            if (createNewAdmin)
            {
                //If the account already exists, give it the rights
                if (existingAdmin != null)
                {
                    existingAdmin.isAdmin = true;
                    MessageBox.Show("De laatste administrator is verwijderd, het bestaande account (gebruikersnaam: 'admin', wachtwoord: 'admin') heeft zijn rechten teruggekregen", "Informatie");
                }
                else //Else create the new account
                {
                    //Create new admin: both username and password are "admin"
                    string password = StringCipher.Encrypt("admin", "admin");
                    Player admin = new Player("admin", password)
                    {
                        isAdmin = true
                    };
                    Players.Add(admin);

                    //Show message to user about the new admin account
                    MessageBox.Show("De laatste administrator is verwijderd, er is een nieuw administrator account gemaakt onder de gebruikersnaam: 'admin', wachtwoord: 'admin'", "Informatie");
                }
            }

            //Save all the players
            using (StreamWriter streamWriter = new StreamWriter("Storage/Players.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Players));
            }
        }

        /// <summary>
        /// Loads all players from local storage
        /// </summary>
        public static void LoadPlayers()
        {
            //Load all the players
            using (StreamReader streamReader = new StreamReader("Storage/Players.json"))
            {
                Players = JsonConvert.DeserializeObject<List<Player>>(streamReader.ReadToEnd());
            }

            //If there are no players, make a new list and save
            if (Players == null)
            {
                Players = new List<Player>();
                SavePlayers(); //Saving creates a new admin account
            }
        }

        /// <summary>
        /// Saves all the tourneys and its contents to storage
        /// </summary>
        public static void SaveTourneys()
        {
            //Save all the tourneys
            using (StreamWriter streamWriter = new StreamWriter("Storage/Tourneys.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Tourneys));
            }
        }

        /// <summary>
        /// Loads all tourneys and their contents from storage
        /// </summary>
        public static void LoadTourneys()
        {
            //Load all tourneys
            List<Tourney> loadedTourneys = null;
            using (StreamReader streamReader = new StreamReader("Storage/Tourneys.json"))
            {
                loadedTourneys = JsonConvert.DeserializeObject<List<Tourney>>(streamReader.ReadToEnd());
            }

            //Due to json creating new items for the existing players, we will have to replace them with existing items
            //The following is a tedious loop to replace all the items
            foreach (Player player in Players)
            {
                for (int i = 0; i < loadedTourneys.Count; i++)
                {
                    //Replace player in tourney reference
                    for (int j = 0; j < loadedTourneys[i].players.Count; j++)
                    {
                        if (player.name == loadedTourneys[i].players[j].name) loadedTourneys[i].players[j] = player;
                    }
                    //Replace player in match reference
                    for (int j = 0; j < loadedTourneys[i].matches.Count; j++)
                    {
                        //quick reference to match
                        Match match = loadedTourneys[i].matches[j];
                        if (match.players[0] != null)
                        {
                            if (player.name == match.players[0].name) match.players[0] = player;
                        }
                        if (match.players[1] != null)
                        {
                            if (player.name == match.players[1].name) match.players[1] = player;
                        }
                    }
                }
            }

            //Finally, use the loaded tourneys in the program
            Tourneys = loadedTourneys;
        }
    }
}
