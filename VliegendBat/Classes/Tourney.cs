using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VliegendBat
{
    /// <summary>
    /// States that a tourney can have
    /// </summary>
    public enum TourneyState
    {
        NotStarted,
        Active,
        Cancelled,
        Finished
    }

    public class Tourney
    {
        //Variables
        public string name = "";
        public TourneyState state = TourneyState.NotStarted;
        public List<Player> players = new List<Player>();
        public List<Match> matches = new List<Match>();

        /// <summary>
        /// Create a new tourney
        /// </summary>
        /// <param name="Name">The name of the tourney</param>
        /// <param name="State">The state of the tourney (mostly needed for loading from storage)</param>
        public Tourney(string Name, TourneyState State = TourneyState.NotStarted)
        {
            name = Name;
            state = State;
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
            if (players.Count > 1)
            {
                CalculateMatches();
            }
        }
        
        //Calculate the amount of matches
        private void CalculateMatches()
        {
            List<Match> matchList = new List<Match>();
            float winners = players.Count;
            Random rng = new Random();
            Player[] playersInTourney = players.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0; winners != 0; i++)
            {
                //If uneven, create full amount of matches and skip one
                if (winners % 2 != 0)
                {
                    //Create match to skip
                    Match skipMatch = new Match()
                    {
                        matchState = MatchState.Skip
                    };

                    //If this is the first itteration, assign player to skip one match
                    if (i == 0)
                    {
                        skipMatch.players[0] = playersInTourney[0];
                    }

                    //Add the skipped match
                    matchList.Add(skipMatch);

                    //Create normal matches
                    for (int j = 0; j < winners; j += 2)
                    {
                        if (j == 0) j++;

                        Match newMatch = new Match();

                        //Set players if this is the first itteration
                        if (i == 0)
                        {
                            newMatch.players[0] = playersInTourney[j];
                            newMatch.players[1] = playersInTourney[j + 1];
                            newMatch.matchState = MatchState.NotStarted;
                        }

                        matchList.Add(newMatch);
                    }
                }
                else
                {
                    //Create full amount of matches
                    for (int j = 0; j < winners; j += 2)
                    {
                        Match newMatch = new Match();

                        //Set players if this is the first itteration
                        if (i == 0)
                        {
                            newMatch.players[0] = playersInTourney[j];
                            newMatch.players[1] = playersInTourney[j + 1];
                            newMatch.matchState = MatchState.NotStarted;
                        }

                        matchList.Add(newMatch);
                    }
                }

                //Divide the winners
                winners /= 2;
                //Round winners down to a full number
                winners = (float)Math.Floor(winners);
            }
            matches = matchList;
        }

        //Determine next round's matches
        public void DetermineNextRound()
        {
            List<Player> matchWinners = new List<Player>();
            List<Match> matchesUnplayed = new List<Match>();

            //Check which matches are played
            foreach (Match match in matches)
            {
                switch (match.matchState)
                {
                    //Undecided matches are Unplayed
                    case MatchState.Undecided:
                        matchesUnplayed.Add(match);
                        break;

                    //If matches aren't finished yet, skip this function
                    case MatchState.NotStarted: return;

                    //Skipped matches get checked if the match has been decided already before adding to any list 
                    case MatchState.Skip:

                        if (match.players[0] != null)
                        {
                            matchWinners.Add(match.players[0]);
                            match.matchState = MatchState.RoundFinished;
                        }
                        else matchesUnplayed.Add(match);
                        break;

                    //Finished matches get added to played matches
                    case MatchState.Finished:
                        matchWinners.Add(match.winner);
                        match.matchState = MatchState.RoundFinished;
                        break;

                    //Matches whose round is finished are skipped
                    case MatchState.RoundFinished: break;
                } 
            }

            //Determine next round with the previous round's winners
            Random rng = new Random();
            Player[] nextRoundPlayers = matchWinners.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0, j = 0; i < matchesUnplayed.Count; i++, j += 2)
            {
                //If the match is to be skipped, add player to it
                if (matchesUnplayed[i].matchState == MatchState.Skip)
                {
                    matchesUnplayed[i].players[0] = matchWinners[j];
                    j--; //revert j one back because only one winner is used
                }
                else
                {
                    matchesUnplayed[i].players[0] = matchWinners[j];
                    matchesUnplayed[i].players[1] = matchWinners[j + 1];
                    matchesUnplayed[i].matchState = MatchState.NotStarted;
                }
            }
        }
    }
}
