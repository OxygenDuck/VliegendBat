using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    public class Player
    {
        //Player variables
        public string name = null;
        public string password = null;
        public bool isAdmin = false;

        /// <summary>
        /// Creates a new player object
        /// </summary>
        /// <param name="Name">The username of the player</param>
        /// <param name="Password">The password of the player, this should be an enctypted string</param>
        public Player(string Name, string Password)
        {
            name = Name;
            password = Password;
        }
    }
}
