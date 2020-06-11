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

    public partial class PlayerStatisticsPage : UserControl
    {
        //Player object to reference
        private Player player = null;

        /// <summary>
        /// Create a new UserStatistics page
        /// </summary>
        /// <param name="player">The player of which you want to see the statistics</param>
        public PlayerStatisticsPage(Player player)
        {
            InitializeComponent();

            //Reference the given player and update the page
            this.player = player;
            UpdateStatistics();
            UpdateListing();
        }

        //Button Click to return to dashboard
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Program.fromPlayerManager)
            {
                MainWindow.SetPage(Pages.ManagePlayers);
                return;
            }
            MainWindow.SetPage(Pages.Dashboard);
        }

        /// <summary>
        /// Update the statistics shown on screen with current information about the player referenced
        /// </summary>
        public void UpdateStatistics()
        {
            //First generate statistics for every player (all players are calculated to determine the rank
            List<PlayerStatistics> allStatistics = new List<PlayerStatistics>();
            foreach (Player existingPlayer in Program.Players)
            {
                PlayerStatistics newStatistics = new PlayerStatistics(existingPlayer);
                allStatistics.Add(newStatistics);
            }

            //Show all the values for this player
            lblPlayerName.Text = player.name;

            foreach (PlayerStatistics statistics in allStatistics)
            {
                //Get this player's statistics
                if (statistics.player == player)
                {
                    lblMatchesPlayed.Text = Convert.ToString(statistics.matchesWon + statistics.matchesLost);
                    lblMatchesWon.Text = statistics.matchesWon.ToString();
                    lblMatchesLost.Text = statistics.matchesLost.ToString();
                    lblGamesPlayed.Text = Convert.ToString(statistics.gamesWon + statistics.gamesLost);
                    lblGamesWon.Text = statistics.gamesWon.ToString();
                    lblGamesLost.Text = statistics.gamesLost.ToString();
                    break;
                }
            }

            //Determine rank
            lblRank.Text = DetermineRank(allStatistics).ToString() + "/" + Program.Players.Count;
        }

        /// <summary>
        /// Determine the rank of this player
        /// </summary>
        private int DetermineRank(List<PlayerStatistics> StatisticsList)
        {
            StatisticsList = StatisticsList.OrderBy(statistics => statistics.rankScore).ToList();
            List<int> Rank = new List<int>();
            for (int i = 0; i < StatisticsList.Count; i++)
            {
                Rank.Add(i + 1); //Rank is its position in the list

                //Excluding the first in the list, check if the score is the same as the previous in the list, if so, make the rank the same
                if (i > 0 && StatisticsList[i].rankScore == StatisticsList[i - 1].rankScore) Rank[i] = Rank[i - 1];

                //If the current player is reached, send his rank number
                if (StatisticsList[i].player == player)
                {
                    return Rank[i];
                }
            }
            return 1;
        }

        /// <summary>
        /// Update the tourney listing
        /// </summary>
        private void UpdateListing()
        {
            //Clear all controls
            pnlTourneyListing.Controls.Clear();
            int tourneysFound = 0;
            foreach (Tourney tourney in Program.Tourneys)
            {
                if (tourney.players.Contains(player))
                {
                    //Create a new list item
                    StatisticsTourneyListing newListing = new StatisticsTourneyListing(tourney, player);
                    pnlTourneyListing.Controls.Add(newListing);

                    //Set the correct position
                    newListing.Location = new Point(0, newListing.Height * tourneysFound);

                    //Apply banded rows
                    if (tourneysFound % 2 == 0)
                    {
                        newListing.BackColor = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        newListing.BackColor = Color.FromArgb(200, 200, 200);
                    }
                    tourneysFound++;
                }
            }
        }
    }

    public class PlayerStatistics
    {
        //The player associated with the object
        public Player player = null;

        //The individual statistics
        public int matchesWon = 0;
        public int matchesLost = 0;
        public int gamesWon = 0;
        public int gamesLost = 0;

        public int rankScore = 0;

        /// <summary>
        /// Create a new player statistics object
        /// </summary>
        /// <param name="player">The player associated with the statistics</param>
        public PlayerStatistics(Player player)
        {
            this.player = player;
            CalculateStatistics();
        }

        /// <summary>
        /// Calculate the statistics
        /// </summary>
        private void CalculateStatistics()
        {
            //search for each match this player is in
            foreach (Tourney tourney in Program.Tourneys)
            {
                if (tourney.players.Contains(player))
                {
                    foreach (Match match in tourney.matches)
                    {
                        if (match.players.Contains(player))
                        {
                            //Look if player won or lost a match statistics
                            if (match.winner == player) matchesWon++;
                            else if (match.winner != null) matchesLost++;

                            for (int i = 0; i < match.gamesPlayer1.Length; i++)
                            {
                                if (match.gamesPlayer1[i] && !match.gamesPlayer2[i]) //Match won by player 1
                                {
                                    if (match.players[0] == player) gamesWon++;
                                    else gamesLost++;
                                }
                                else if (!match.gamesPlayer1[i] && match.gamesPlayer2[i]) //Match won by player 2
                                {
                                    if (match.players[1] == player) gamesWon++;
                                    else gamesLost++;
                                }
                            }
                        }
                    }
                }
            }
            //calculate rankscore
            rankScore = matchesWon;
            rankScore *= 3; //Match score weighs heavier than game score
            rankScore -= gamesLost;
        }
    }

}
