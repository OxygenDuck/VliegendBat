using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    /// <summary>
    /// Enumerator for the state of a match
    /// </summary>
    public enum MatchState
    {
        Undecided,
        NotStarted,
        Skip,
        Finished,
        RoundFinished
    }

    /// <summary>
    /// Create a new match
    /// </summary>
    public class Match
    {
        //Game outcomes
        public bool[] gamesPlayer1 = { false, false, false, false, false };
        public bool[] gamesPlayer2 = { false, false, false, false, false };

        //The match state of this match
        public MatchState matchState = MatchState.Undecided;

        //The players
        public Player[] players = { null, null };
        public Player winner = null;
    }
}
