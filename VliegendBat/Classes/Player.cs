using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    public class Player
    {
        public string name = null;
        public bool isAdmin = false;

        public Player(string Name)
        {
            name = Name;
        }
    }
}
