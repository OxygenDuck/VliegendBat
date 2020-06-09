using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VliegendBat
{
    public partial class StatisticsTourneyListing : UserControl
    {
        //The player associated with this listing
        Player player = null;
        //The tourney associated with this listing
        Tourney tourney = null;

        /// <summary>
        /// Create a new tourey listing for the statistics page
        /// </summary>
        /// <param name="tourney">The tourney to associate with this listing</param>
        /// <param name="user">The user to associate with this listing</param>
        public StatisticsTourneyListing(Tourney tourney, Player player)
        {
            InitializeComponent();
            this.player = player;
            this.tourney = tourney;

            UpdateListing();
        }

        /// <summary>
        /// Update the listing elements
        /// </summary>
        private void UpdateListing()
        {
            lblTourneyName.Text = tourney.name;

            //Look how much games have been played already
            int matchesPlayed = 0;
            foreach (Match match in tourney.matches)
            {
                if (match.matchState == MatchState.Finished || match.matchState == MatchState.RoundFinished || match.matchState == MatchState.Skip)
                {
                    matchesPlayed++;
                }
            }
            lblGamesPlayed.Text = matchesPlayed.ToString() + "/" + tourney.matches.Count.ToString();

            //Check what the player's state is the player 
            switch (tourney.state)
            {
                //If the tourney hasn't started yet, say it has not started
                case TourneyState.NotStarted:
                    lblState.Text = "Nog niet begonnen";
                    break;

                //If the tourney is still active, see what the player's current situation is
                case TourneyState.Active:
                    foreach (Match match in tourney.matches)
                    {
                        //Check if the player has lost a match
                        if (match.players.Contains(player) && match.winner != player && match.winner != null)
                        {
                            lblState.Text = "Verloren";
                        }
                        else //Otherwise show as active
                        {
                            lblState.Text = "Actief";
                        }
                    }
                    break;

                //If the tourney is finished, see if the player won
                case TourneyState.Finished:
                    //Check if the player won the last round
                    if (tourney.matches[tourney.matches.Count - 1].winner == player) lblState.Text = "Gewonnen";
                    else lblState.Text = "Verloren";
                    break;
            }
        }
    }
}
