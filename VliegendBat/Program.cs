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
    /// Last update 5th of June 2020
    /// Version 0.1.2
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
            using (StreamWriter streamWriter = new StreamWriter("storage/Players.json", false))
            {
                streamWriter.Write(JsonConvert.SerializeObject(Players));
                //foreach (Player player in Players)
                //{
                //    string json = JsonConvert.SerializeObject(player);
                //    streamWriter.WriteLine(json);
                //}
            }
        }
        
        /// <summary>
        /// Load all players fro local storage
        /// </summary>
        public static void LoadPlayers()
        {
            using (StreamReader streamReader = new StreamReader("storage/Players.json"))
            {
                Players = JsonConvert.DeserializeObject<List<Player>>(streamReader.ReadToEnd());
            }
        }
    }
}
