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
            //Link the name and state of the tourney
            name = Name;
            state = State;
        }

        //Enter a player into the tourney
        public void EnterPlayer(Player player)
        {
            //Check if the player has already entered this tourney
            if (players.Contains(player))
            {
                System.Windows.Forms.MessageBox.Show("Deze speler heeft zich al aangemeld", "Waarschuwing");
                return;
            }

            //Add the player
            players.Add(player);

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
            //Some variables to track things
            List<Match> matchList = new List<Match>(); //The new list of matches for the tourney
            int playersLeft = players.Count; //The amount of players that will be left in a round
            double matchesInRound = playersLeft / 2; //The amount of matches in the round
            matchesInRound = Math.Floor(matchesInRound); //Round the matches down

            //Determine a random order of players
            Random rng = new Random();
            Player[] playersInTourney = players.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0; playersLeft != 1; i++)
            {
                //If uneven, create full amount of matches and skip one
                if (playersLeft % 2 != 0)
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
                    for (int j = 1; j < playersLeft; j += 2)
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
                else
                {
                    //Create full amount of matches
                    for (int j = 0; j < playersLeft; j += 2)
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

                //Remove players left behind in current round
                playersLeft -= (int)matchesInRound;
                //Divide the winners
                matchesInRound /= 2;
                //Round winners down to a full number, if the result is 0, make it 1
                matchesInRound = (float)Math.Floor(matchesInRound);
                if (matchesInRound == 0)
                {
                    matchesInRound = 1;
                }
            }
            matches = matchList;
        }

        //Determine next round's matches
        public void DetermineNextRound()
        {
            List<Player> matchWinners = new List<Player>();
            List<Match> matchesUnplayed = new List<Match>();
            List<Match> markAsComplete = new List<Match>();

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
                            markAsComplete.Add(match);
                        }
                        else matchesUnplayed.Add(match);
                        break;

                    //Finished matches get added to played matches
                    case MatchState.Finished:
                        matchWinners.Add(match.winner);
                        markAsComplete.Add(match);
                        break;

                    //Matches whose round is finished are skipped
                    case MatchState.RoundFinished: break;
                } 
            }

            //Mark finished or skipped round as completed
            foreach (Match match in matches) match.matchState = MatchState.RoundFinished;

            //Check if the final match is played
            if (matchWinners.Count == 1)
            {
                //Show a message to the user
                System.Windows.Forms.MessageBox.Show(matchWinners[0].name + " heeft het toernooi gewonnen!", "Informatie");
                //Set state to finished and return
                state = TourneyState.Finished;
                return;
            }

            //Determine next round with the previous round's winners
            Random rng = new Random();
            Player[] nextRoundPlayers = matchWinners.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0, j = 0; j < nextRoundPlayers.Length; i++, j += 2)
            {
                //If the match is to be skipped, add player to it
                if (matchesUnplayed[i].matchState == MatchState.Skip)
                {
                    matchesUnplayed[i].players[0] = nextRoundPlayers[j];
                    j--; //revert j one back because only one winner is used
                }
                else //Else add a normal match
                {
                    matchesUnplayed[i].players[0] = nextRoundPlayers[j];
                    matchesUnplayed[i].players[1] = nextRoundPlayers[j + 1];
                    matchesUnplayed[i].matchState = MatchState.NotStarted;
                }
            }
        }
    }
}
