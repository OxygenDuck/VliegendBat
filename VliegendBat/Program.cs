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
    /// Version 0.1.0
    /// </summary>
    static class Program
    {
        //Reference to the main form
        static public MainWindow window = null;

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
