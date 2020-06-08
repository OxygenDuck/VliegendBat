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
    /// Last update 8th of June 2020
    /// Version 0.1.3
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
                Player admin = new Player("admin", password);
                admin.isAdmin = true;
                Players.Add(admin);
            }

            //Save all the players
            using (StreamWriter streamWriter = new StreamWriter("Storage/Players.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Players));
            }
        }
        
        /// <summary>
        /// Load all players fro local storage
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
    }
}
