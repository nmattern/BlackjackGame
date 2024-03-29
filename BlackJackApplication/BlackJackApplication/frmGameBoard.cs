﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BlackJackApplication
{
    public partial class frmGameBoard : Form
    {
        private List<Player> playerList;
        internal DatabaseAccess database;
        private LocalTurn localTurn;
        internal LocalGame localGame;
        public List<Label> currentMoneyLabels = new List<Label>();
        public List<Label> currentBetLabels = new List<Label>();
        public List<Label> currentTotalLabels = new List<Label>();
        private Dealer dealer;

        internal frmGameBoard(List<Player> pList, DatabaseAccess db, LocalGame aLocalGame)
        {
            InitializeComponent();
            playerList = pList;
            database = db;
            localGame = aLocalGame;
        }

        private async void frmGameBoard_Load(object sender, EventArgs e)
        {
            // Generate Deck and Dealer for game
            Deck myDeck = new Deck();
            dealer = new Dealer();
            

            // pull current Local game from db into local
            await database.updateLocalGame(playerList[0]);
            playerList[0].ALocalGame = database.LocalGame;

            // locally set the location for each player label
            List<Point> playerLabels = new List<Point>();
            int i;
            playerLabels.Add(this.player1Label.Location);
            playerLabels.Add(this.player2Label.Location);
            playerLabels.Add(this.player3Label.Location);
            for (i = 0; i < playerList[0].ALocalGame.PlayerList.Count; i++)
            {
                playerList[0].ALocalGame.PlayerList[i].Location = playerLabels[i];
            }

            // send player location info to db
            await database.setLocalPlayerLocation(playerLabels, playerList[0]);

            // change button state
            hitButton.Visible = false;
            standButton.Visible = false;
            continueButton.Visible = false;

            // create list of money labels
            switch (playerList[0].ALocalGame.PlayerList.Count)
            {
                case 3:
                    currentMoneyLabels.Add(player1CurrentMoneyLabel);
                    currentMoneyLabels.Add(player2CurrentMoneyLabel);
                    currentMoneyLabels.Add(player3CurrentMoneyLabel);
                    break;
                case 2:
                    currentMoneyLabels.Add(player1CurrentMoneyLabel);
                    currentMoneyLabels.Add(player2CurrentMoneyLabel);
                    break;
                case 1:
                    currentMoneyLabels.Add(player1CurrentMoneyLabel);
                    break;
            }

            // set money labels
            for (i = 0; i < playerList[0].ALocalGame.PlayerList.Count; i++)
            {
                currentMoneyLabels[i].Text = "Current Money: " + Convert.ToString(playerList[0].ALocalGame.PlayerList[i].PlayerAmountOfMoney);
            }

            // create list of bet labels
            switch (playerList[0].ALocalGame.PlayerList.Count)
            {
                case 3:
                    currentBetLabels.Add(player1BetLabel);
                    currentBetLabels.Add(player2BetLabel);
                    currentBetLabels.Add(player3BetLabel);
                    break;
                case 2:
                    currentBetLabels.Add(player1BetLabel);
                    currentBetLabels.Add(player2BetLabel);
                    break;
                case 1:
                    currentBetLabels.Add(player1BetLabel);
                    break;
            }

            // set bet labels
            for (i = 0; i < playerList[0].ALocalGame.PlayerList.Count; i++)
            {
                currentBetLabels[i].Text = "Current Bet: " + Convert.ToString(playerList[0].ALocalGame.PlayerList[i].PlayerBet);
            }

            // create list of total labels
            switch (playerList[0].ALocalGame.PlayerList.Count)
            {
                case 3:
                    currentTotalLabels.Add(player1CurrentTotal);
                    currentTotalLabels.Add(player2CurrentTotal);
                    currentTotalLabels.Add(player3CurrentTotal);
                    break;
                case 2:
                    currentTotalLabels.Add(player1CurrentTotal);
                    currentTotalLabels.Add(player2CurrentTotal);
                    break;
                case 1:
                    currentTotalLabels.Add(player1CurrentTotal);
                    break;
            }

            // set total labels
            for (i = 0; i < playerList[0].ALocalGame.PlayerList.Count; i++)
            {
                currentTotalLabels[i].Text = "Current Total: " + Convert.ToString(playerList[0].ALocalGame.PlayerList[i].PlayerHandValue);
            }

            // generate turn instance
            localTurn = new LocalTurn(playerList[0], dealer, myDeck, this, database);

            // set focus to the bet text box
            betTextBox.SelectionStart = 1;
            betTextBox.Select();

            // Display turn counter
            turnLabel.Text = localTurn.turnCounter.ToString();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            // run turn class button press
            localTurn.hitButtonClick();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            // run turn class button press
            localTurn.standButtonClick();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // check end game condition all players out of money
            if (player1CurrentMoneyLabel.Text == "0"
                && player2CurrentMoneyLabel.Text == "0"
                && player3CurrentMoneyLabel.Text == "0")
            {
                endGame();
            }

            foreach(Player player in playerList)
            {
                foreach(PictureBox picture in player.PictureBoxes)
                {
                    Controls.Remove(picture);
                }
            }
            foreach(PictureBox picture in dealer.PictureBoxes)
            {
                Controls.Remove(picture);
            }

            // change button state
            this.continueButton.Visible = false;
            this.standButton.Visible = true;
            this.hitButton.Visible = true;

            // run turn class button press
            localTurn.continueButtonClick();
        }


        private void betButton_EnabledChanged(object sender, EventArgs e)
        {
            // enforce stylized color changes
            if (betButton.BackColor == Color.Gray)
            {
                betButton.BackColor = Color.FromArgb(6, 67, 157); //blue color
            }
            else
            {
                betButton.BackColor = Color.Gray;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            localTurn.betButtonClick();
        }

        private void betTextBox_TextChanged(object sender, EventArgs e)
        {
            // make sure bet is valid
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.betTextBox.Text, out number);

            // store bet in correct label
            
                if (betContainsOnlyDigits || this.betTextBox.Text == "")
                {
                    currentBetLabels[localTurn.turnCounter].Text = "Current Bet: " + betTextBox.Text;
                }
                else
                {
                    currentBetLabels[localTurn.turnCounter].Text = "Not Valid";
                }
            
        }

        private void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            localTurn.adjustMoneyClick();
        }

        public void endGame()
        {
            var gameOverFormInstance = new GameOverForm();
            gameOverFormInstance.Show();
            gameOverFormInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            gameOverFormInstance.FormClosed += (s, args) => this.Close();
        }

        private void adjustMoneyTextBox_Click(object sender, EventArgs e)
        {
            if (adjustMoneyTextBox.Text != "")
            {
                adjustMoneyTextBox.Text = "";
            }
        }

        private void betTextBox_Click(object sender, EventArgs e)
        {
            betTextBox.Text = "$";
            betTextBox.SelectionStart = 1;
        }

        private void betTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void splitButton_Click(object sender, EventArgs e)
        {
            localTurn.splitButtonClick();
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            if (insuranceButton.Text == "Insurance")
            {
                insuranceButton.Text = "Bet";
                insuranceBetTextBox.Visible = true;
            } else
            {
                insuranceButton.Text = "Insurance";
                localTurn.insuranceBet(int.Parse(insuranceBetTextBox.Text.Remove(0, 10)));
            }
        }
    }
}
