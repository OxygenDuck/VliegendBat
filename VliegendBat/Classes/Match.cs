using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    public enum MatchState
    {
        Undecided,
        NotStarted,
        Finished
    }

    public class Match
    {
        public bool[] games = { false, false, false, false, false };
        public MatchState matchState = MatchState.Undecided;
        public Player[] players = { null, null };
    }
}
