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
    public partial class ManageMatchListing : UserControl
    {
        //Variables
        bool expanded = false;

        //Associated Match for this controller
        public Match match = null;

        //Functionpointer for resizing the list in the container
        public Delegate ListFunctionPointer;

        /// <summary>
        /// Make a new match listing for the Manage Match page
        /// </summary>
        /// <param name="match">The match to associate with this controller</param>
        public ManageMatchListing(Match match)
        {
            InitializeComponent();
            this.match = match;
            Height = 75;

            UpdateListing();
        }

        //Update the listing item with current information from the match
        public void UpdateListing()
        {
            //Set the player names
            if (match.players[0] != null)
            {
                lblPlayerName1.Text = match.players[0].name;
            }
            else
            {
                lblPlayerName1.Text = "-";
            }

            if (match.players[1] != null)
            {
                lblPlayerName2.Text = match.players[1].name;
            }
            else
            {
                lblPlayerName2.Text = "-";
            }

            lblPlayers.Text = lblPlayerName1.Text + ", " + lblPlayerName2.Text;

            //Set the match state, and show the winner if there is one
            lblStatus.Text = match.matchState.ToString();
            if (match.winner != null)
            {
                lblWinner.Text = match.winner.name;
            }
            else
            {
                lblWinner.Text = "-";
            }

            //Disable elements if match has been played already
            if (match.matchState != MatchState.NotStarted)
            {
                btnDisqualifyPlayer1.Enabled = false;
                btnDisqualifyPlayer2.Enabled = false;
                btnFinish.Enabled = false;
            }
            else
            {
                btnDisqualifyPlayer1.Enabled = true;
                btnDisqualifyPlayer2.Enabled = true;
                btnFinish.Enabled = true;
            }
        }

        //Button click to expand the item
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                Height = 75;
                expanded = false;
            }
            else
            {
                Height = 150;
                expanded = true;
            }

            //Rescale the list in the container
            ListFunctionPointer.DynamicInvoke();
        }

        //Button click to determine the winner and save the result
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (CheckMatchWinner() == null)
            {
                MessageBox.Show("Er is geen winnaar gevonden, weet zeker dat één speler beste 3 uit 5 gewonnen heeft", "Waarschuwing");
                return;
            }

            MessageBox.Show(match.winner.name + " heeft de wedstrijd gewonnen!", "Informatie");
            match.matchState = MatchState.Finished;

            //Determine next round in tourney
            foreach (Tourney tourney in Program.Tourneys)
            {
                if (tourney.name == lblTourneyName.Text)
                {
                    tourney.state = TourneyState.Active;
                    tourney.DetermineNextRound();
                    break;
                }
            }

            //Update list in page
            ListFunctionPointer.DynamicInvoke();
        }

        /// <summary>
        /// Compare the results given and determine if there is a winner
        /// </summary>
        /// <returns>The player who won the game, returns null if no winner is found</returns>
        private Player CheckMatchWinner()
        {
            short scorePlayer1 = 0;
            short scorePlayer2 = 0;

            //Check all points for player 1
            if (rbtGame1P1.Checked)
            {
                scorePlayer1++;
                match.gamesPlayer1[0] = true;
            }
            if (rbtGame2P1.Checked)
            {
                scorePlayer1++;
                match.gamesPlayer1[1] = true;
            }
            if (rbtGame3P1.Checked)
            {
                scorePlayer1++;
                match.gamesPlayer1[2] = true;
            }
            if (rbtGame4P1.Checked)
            {
                scorePlayer1++;
                match.gamesPlayer1[3] = true;
            }
            if (rbtGame5P1.Checked)
            {
                scorePlayer1++;
                match.gamesPlayer1[4] = true;
            }

            //Check all points for player 1
            if (rbtGame1P2.Checked)
            {
                scorePlayer2++;
                match.gamesPlayer2[0] = true;
            }
            if (rbtGame2P2.Checked)
            {
                scorePlayer2++;
                match.gamesPlayer2[1] = true;
            }
            if (rbtGame3P2.Checked)
            {
                scorePlayer2++;
                match.gamesPlayer2[2] = true;
            }
            if (rbtGame4P2.Checked)
            {
                scorePlayer2++;
                match.gamesPlayer2[3] = true;
            }
            if (rbtGame5P2.Checked)
            {
                scorePlayer2++;
                match.gamesPlayer2[4] = true;
            }

            //Compare the scores
            //if there is no player with 3 points, no winner is found
            if (scorePlayer1 < 3 && scorePlayer2 < 3)
            {
                //reset the points in the match
                for (int i = 0; i < match.gamesPlayer1.Length; i++)
                {
                    match.gamesPlayer1[i] = false;
                    match.gamesPlayer2[i] = false;
                }
                return null;
            }

            //If player 1 has a higher score, player 1 wins
            if (scorePlayer1 > scorePlayer2)
            {
                match.winner = match.players[0];
                return match.players[0];
            }
            else //Otherwise player 2 wins
            {
                match.winner = match.players[1];
                return match.players[1];
            }
        }

        //Button click to Disqualify a player and make the other automatically win
        private void btnDisqualifyPlayer1_Click(object sender, EventArgs e)
        {
            //Check which player to disqualify
            Player playerToDisqualify = null;
            if (sender == btnDisqualifyPlayer1) playerToDisqualify = match.players[0];
            else playerToDisqualify = match.players[1];

            //Send a warning and ask for confirmation
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je " + playerToDisqualify.name + " wilt diskwalificeren?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Depending on who got disqualified, set the score
                if (playerToDisqualify == match.players[0])
                {
                    //Set the winning player's score -> first 3 games won
                    rbtGame1P2.Checked = true;
                    rbtGame2P2.Checked = true;
                    rbtGame3P2.Checked = true;
                    rbtGame2P2.Checked = false;
                    rbtGame3P2.Checked = false;

                    //Set the disqualified player's score to 0
                    rbtGame1P1.Checked = false;
                    rbtGame2P1.Checked = false;
                    rbtGame3P1.Checked = false;
                    rbtGame4P1.Checked = false;
                    rbtGame5P1.Checked = false;
                }
                else
                {
                    //Set the winning player's score -> first 3 games won
                    rbtGame1P1.Checked = true;
                    rbtGame2P1.Checked = true;
                    rbtGame3P1.Checked = true;
                    rbtGame4P1.Checked = false;
                    rbtGame5P1.Checked = false;

                    //Set the disqualified player's score to 0
                    rbtGame1P2.Checked = false;
                    rbtGame2P2.Checked = false;
                    rbtGame3P2.Checked = false;
                    rbtGame4P2.Checked = false;
                    rbtGame5P2.Checked = false;
                }

                //Have the match be decided and saved
                btnFinish_Click(null, null);
            }
        }
    }
}
