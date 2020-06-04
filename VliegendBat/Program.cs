using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VliegendBat
{
    /// <summary>
    /// Program created by Peter Janssen, IC17ao.e
    /// Last update 2nd of June 2020
    /// Version 0.1.1
    /// </summary>
    static class Program
    {
        //Reference to the main form
        static public MainWindow window = null;

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
            Application.Run(new MainWindow());
        }
    }
}
