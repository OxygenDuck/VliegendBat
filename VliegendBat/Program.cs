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
    /// Last update 9th of June 2020
    /// Version 0.1.6
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
            bool createNewAdmin = true;
            foreach (Player player in Players)
            {
                if (player.isAdmin)
                {
                    createNewAdmin = false;
                    break;
                }
            }
            if (createNewAdmin)
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

            //Save all the players
            using (StreamWriter streamWriter = new StreamWriter("Storage/Players.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Players));
            }
        }

        /// <summary>
        /// Loads all players fro local storage
        /// </summary>
        public static void LoadPlayers()
        {
            using (StreamReader streamReader = new StreamReader("Storage/Players.json"))
            {
                Players = JsonConvert.DeserializeObject<List<Player>>(streamReader.ReadToEnd());
            }

            if (Players == null)
            {
                Players = new List<Player>();
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
