using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    public enum TourneyState
    {
        NotStarted,
        Active,
        Cancelled,
        Finished
    }

    public class Tourney
    {
        public string name = "";
        public TourneyState state = TourneyState.NotStarted;
        public List<Player> players = new List<Player>();
        public List<Match> matches = new List<Match>();

        public Tourney(string Name, string State)
        {
            name = Name;

            switch (State)
            {
                case "Active": state = TourneyState.Active; break;
                case "Cancelled": state = TourneyState.Cancelled; break;
                case "Finished": state = TourneyState.Finished; break;
                default: state = TourneyState.NotStarted; break;
            }
        }

        //Enter a player into the tourney
        public void EnterPlayer(Player player)
        {
            if (players.Contains(player))
            {
                System.Windows.Forms.MessageBox.Show("Deze speler heeft zich al aangemeld", "Waarschuwing");
                return;
            }

            players.Add(player);

            //randomise player order
            Random rng = new Random();
            Player[] randomOrder = players.OrderBy(x => rng.Next()).ToArray();

            //Determine amount of matches

            matches.Clear();
            for (int i = 0; i < players.Count; i+=2)
            {
                //Create new match and set its player based on the random order
                Match newMatch = new Match();
                newMatch.players[0] = randomOrder[i];
                if (i + 1 < players.Count)
                {
                    newMatch.players[1] = randomOrder[i + 1];
                    newMatch.matchState = MatchState.NotStarted;
                }
                else
                {
                    newMatch.players[1] = null;
                    newMatch.matchState = MatchState.Undecided;
                }
                
                matches.Add(newMatch);
            }
        }
    }
}
