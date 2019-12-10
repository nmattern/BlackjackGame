using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BlackJackApplication
{
    class LocalTurn
    {
        private Player player;
        private Dealer dealer;
        private Deck deck;
        private frmGameBoard gameBoard;
        const int IMAGE_DISTANCE_Y = 20;
        const int IMAGE_DISTANCE_X = 20;
        public Point dealerLocation = new Point(16, 54);
        public int turnCounter = 0;
        public DatabaseAccess database;
        public bool roundFinished = false;
        public bool[] bustedArray = new bool[] {false, false, false};
        public bool[] blackjackArray = new bool[] {false, false, false };
        public int hand = 0;
        public int valueOfFirstHand = 0;
        public int valueOfSecondHand = 0;
        Card secondHand;

        public LocalTurn(Player aPlayer, Dealer deal, Deck deckarg, frmGameBoard game, DatabaseAccess data)
        {
            player = aPlayer;
            dealer = deal;
            deck = deckarg;
            gameBoard = game;
            database = data;
        }

        public void addImage(Image image, string player)
        {

        }

        public void addPlayerCard(Card card, GamePlayer aplayer)
        {
            int number;
            string cardImageString;
            bool cardIsDigit = Int32.TryParse(card.Value, out number);
            if (cardIsDigit)
            {
                cardImageString = ("_" + card.Value + "_of_" + card.Suit);
            }
            else
            {
                cardImageString = (card.Value + "_of_" + card.Suit);
            }
            Image cardImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(cardImageString);
            // add picture box
            for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
            {
                // Specific locations need to be calculated
                Point newPosition = new Point(aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                if (aplayer.PlayerHand[cardNum].Value == card.Value)
                {
                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = cardImage,
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(120, 150),
                        Location = newPosition
                    };
                    gameBoard.Controls.Add(pictureBox);
                    player.PictureBoxes.Add(pictureBox);
                    pictureBox.BringToFront();
                }
            }
        }

        public void addPlayerCard(Card card, GamePlayer aplayer, int numHand)
        {
            if (numHand == 0)
            {
                for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
                {
                    Point newPosition = new Point(aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                    if (aplayer.PlayerHand[cardNum].CardImage == card.CardImage)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = card.CardImage,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = newPosition
                        };
                        gameBoard.Controls.Add(pictureBox);
                        player.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            } else
            {
                for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
                {
                    Point newPosition = new Point(30 + aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                    if (aplayer.PlayerHand[cardNum].CardImage == card.CardImage)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = card.CardImage,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = newPosition
                        };
                        gameBoard.Controls.Add(pictureBox);
                        player.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
        }

        public void addDealerCard(Card card, Dealer deal)
        {
            int number;
            string cardImageString;
            bool cardIsDigit = Int32.TryParse(card.Value, out number);
            if (cardIsDigit)
            {
                cardImageString = ("_" + card.Value + "_of_" + card.Suit);
            }
            else
            {
                cardImageString = (card.Value + "_of_" + card.Suit);
            }
            Image cardImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(cardImageString);
            dealer = deal;
            for (int cardNum = 0; cardNum < dealer.CurrentPlayerHand.Count; cardNum++)
            {
                // Specific location needs calculation
                Point newPosition = new Point(dealerLocation.X + IMAGE_DISTANCE_X * cardNum, dealerLocation.Y + IMAGE_DISTANCE_Y * cardNum);
                if (dealer.CurrentPlayerHand[cardNum].Value == card.Value)
                {
                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = cardImage,
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(120, 150),
                        Location = newPosition
                    };
                    gameBoard.Controls.Add(pictureBox);
                    dealer.PictureBoxes.Add(pictureBox);
                    pictureBox.BringToFront();
                }
            }
        }

        public async void betButtonClick()
        {
            int betNumber = Convert.ToInt32(Regex.Replace(gameBoard.betTextBox.Text, "[$]", ""));

            // Validate if the user bet greater than 0 and less than what they have
            if (betNumber > 0)
            {
                // save players bet into gamePlayer instance
                player.ALocalGame.PlayerList[turnCounter].PlayerBet = betNumber;
                
                if (player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney - player.ALocalGame.PlayerList[turnCounter].PlayerBet >= 0)
                {
                    // take bet amount away from player
                    player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney -= betNumber;
                    // update the game players current money label
                    gameBoard.currentMoneyLabels[turnCounter].Text = "Current Money: " + (player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney).ToString();
                    // enable and disable buttons for end of betting
                    gameBoard.betButton.Enabled = false;
                    gameBoard.betTextBox.ReadOnly = true;
                    gameBoard.hitButton.Visible = true;
                    gameBoard.standButton.Visible = true;
                    // update db with new player bet info
                    await database.createLocalGamePlayer(player.Username, turnCounter, player.ALocalGame.PlayerList[turnCounter]);
                    beginPlayerTurn();
                }
                else
                {
                    gameBoard.currentBetLabels[turnCounter].Text = "Current Bet: Bet must be less than you have";
                }
            }
            else 
            {
                gameBoard.currentBetLabels[turnCounter].Text = "Current Bet: Bet must be greater than 0";
            }
        }

        public void adjustMoneyButtonClick()
        {
            player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney = Convert.ToInt32(gameBoard.adjustMoneyTextBox.Text);
            gameBoard.currentMoneyLabels[turnCounter].Text = gameBoard.adjustMoneyTextBox.Text;
        }

        //------------------------------------------------------------------------------------
        public async void beginPlayerTurn()
        {
            //deal cards to this player
            dealer.dealCard(player.ALocalGame.PlayerList[turnCounter], deck, 2);
            await database.updatePlayerHand(player.ALocalGame.PlayerList[0].Username, turnCounter, player.ALocalGame.PlayerList[turnCounter].PlayerHand);

            // If it is the first player's turn, deal to the dealer and display dealer cards
            if (turnCounter == 0)
            {
                dealer.dealSelf(dealer, deck, 2);
                dealer.CurrentPlayerHand[0].Hidden = true;

                foreach (Card card in dealer.CurrentPlayerHand)
                {
                    addDealerCard(card, dealer);
                }
            }

            // Generate players cards onto game board
            foreach (Card card in player.ALocalGame.PlayerList[turnCounter].PlayerHand)
            {
                addPlayerCard(card, player.ALocalGame.PlayerList[turnCounter]);
            }

            // if first player's turn, calculate dealers hand value
            int valueOfFirstCard = 0;
            if (turnCounter == 0)
            {
                // Set the intial values of the player and dealer total labels
                // First we have to validate the value of the hidden card in case it is a string
                

                // set value of dealers first card
                string firstCardValue = (dealer.CurrentPlayerHand[0].Value);
                if (firstCardValue == "king" || firstCardValue == "queen" || firstCardValue == "jack")
                {
                    valueOfFirstCard = 10;
                }
                else if (dealer.CurrentPlayerHand[0].Value == "ace")
                {
                    valueOfFirstCard = 11;
                }
                else
                {
                    valueOfFirstCard = Convert.ToInt32(firstCardValue);
                }

                // set inital value of dealers hand
                if (dealer.CurrentPlayerHand[1].Value == "king" || dealer.CurrentPlayerHand[1].Value == "queen" || dealer.CurrentPlayerHand[1].Value == "jack")
                {
                    dealer.CurrentValueOfHand = valueOfFirstCard + 10;
                }
                else if (dealer.CurrentPlayerHand[1].Value == "ace")
                {
                    dealer.CurrentValueOfHand = valueOfFirstCard + 11;
                }
                else
                {
                    dealer.CurrentValueOfHand = valueOfFirstCard + Convert.ToInt32(dealer.CurrentPlayerHand[1].Value);
                }
            }

            // calculate players hand value

            // first card
            string pFirstCard = player.ALocalGame.PlayerList[turnCounter].PlayerHand[0].Value;
            string pSecondCard = player.ALocalGame.PlayerList[turnCounter].PlayerHand[1].Value;
            if (pFirstCard == "king" || pFirstCard == "queen" || pFirstCard == "jack")
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 10;
            }
            else if (pFirstCard == "ace")
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 11;
            }
            else
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = Convert.ToInt32(pFirstCard);
            }

            // second card
            if (pSecondCard == "king" || pSecondCard == "queen" || pSecondCard == "jack")
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue += 10;
            }
            else if (pSecondCard == "ace")
            {
                // if two aces, switch one to a one
                if (pFirstCard == "ace")
                {
                    player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 12;
                }
                else
                {
                    player.ALocalGame.PlayerList[turnCounter].PlayerHandValue += 11;
                }

            }
            else
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue += Convert.ToInt32(pSecondCard);
            }

            // if first player's turn, display dealers new visual total
            if (turnCounter == 0)
            {
                gameBoard.dealerVisableTotalLabel.Text = "Current Visable Total: " + (dealer.CurrentValueOfHand - valueOfFirstCard).ToString();
            }

            // update player hand value on game board
            gameBoard.currentTotalLabels[turnCounter].Text = "Current Total: " + player.ALocalGame.PlayerList[turnCounter].PlayerHandValue.ToString();

            // handle cases of instant win
            if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
            {
                if (dealer.CurrentValueOfHand != 21)
                {
                    playerBlackjack(player.ALocalGame.PlayerList[turnCounter]);
                }
            }
        }
        //------------------------------------------------------------------------------------
        /*
        // Handles initialization of table state
        public async void beginTurn()
        {
            int j;

            // deal players cards
            for(j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                dealer.dealCard(player.ALocalGame.PlayerList[j], deck, 2);
                await database.updatePlayerHand(player.ALocalGame.PlayerList[0].Username, j, player.ALocalGame.PlayerList[j].PlayerHand);
            }

            // dealer deals to self
            dealer.dealSelf(dealer, deck, 2);
            dealer.CurrentPlayerHand[0].Hidden = true;

            // Generates the hand for the players visually
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                foreach(Card card in player.ALocalGame.PlayerList[j].PlayerHand)
                {
                    addPlayerCard(card, player.ALocalGame.PlayerList[j]);
                }
            }

            // Generates the hand for the dealer visually
            foreach (Card card in dealer.CurrentPlayerHand)
            {
                addDealerCard(card, dealer);
            }

            // Set the intial values of the player and dealer total labels
            // First we have to validate the value of the hidden card in case it is a string
            int valueOfFirstCard = 0;

            // set value of dealers first card
            string firstCardValue = (dealer.CurrentPlayerHand[0].Value);
            if (firstCardValue == "king" || firstCardValue == "queen" || firstCardValue == "jack")
            {
                valueOfFirstCard = 10;
            }
            else if (dealer.CurrentPlayerHand[0].Value == "ace")
            {
                valueOfFirstCard = 11;
            }
            else
            {
                valueOfFirstCard = Convert.ToInt32(firstCardValue);
            }

            // set inital value of dealers hand
            if (dealer.CurrentPlayerHand[1].Value == "king" || dealer.CurrentPlayerHand[1].Value == "queen" || dealer.CurrentPlayerHand[1].Value == "jack")
            {
                dealer.CurrentValueOfHand = valueOfFirstCard + 10;
            }
            else if (dealer.CurrentPlayerHand[1].Value == "ace")
            {
                dealer.CurrentValueOfHand = valueOfFirstCard + 11;
            }
            else
            {
                dealer.CurrentValueOfHand = valueOfFirstCard + Convert.ToInt32(dealer.CurrentPlayerHand[1].Value);
            }

            // calculate players hand values
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                string pFirstCard = player.ALocalGame.PlayerList[j].PlayerHand[0].Value;
                string pSecondCard = player.ALocalGame.PlayerList[j].PlayerHand[1].Value;
                if (pFirstCard == "king" || pFirstCard == "queen" || pFirstCard == "jack")
                {
                    player.ALocalGame.PlayerList[j].PlayerHandValue = 10;
                }
                else if (pFirstCard == "ace")
                {
                    player.ALocalGame.PlayerList[j].PlayerHandValue = 11;
                }
                else
                {
                    player.ALocalGame.PlayerList[j].PlayerHandValue = Convert.ToInt32(pFirstCard);
                }

                if (pSecondCard == "king" || pSecondCard == "queen" || pSecondCard == "jack")
                {
                    player.ALocalGame.PlayerList[j].PlayerHandValue += 10;
                }
                else if (pSecondCard == "ace")
                {
                    // if two aces, switch one to a one
                    if (pFirstCard == "ace")
                    {
                        player.ALocalGame.PlayerList[j].PlayerHandValue = 12;
                    }
                    else
                    {
                        player.ALocalGame.PlayerList[j].PlayerHandValue += 11;
                    }
                    
                }
                else
                {
                    player.ALocalGame.PlayerList[j].PlayerHandValue += Convert.ToInt32(pSecondCard);
                }
            }
            
            // set the new labels for the dealer and each player
            gameBoard.dealerVisableTotalLabel.Text = "Current Visable Total: " + (dealer.CurrentValueOfHand - valueOfFirstCard).ToString();

            // update player hand value to screen
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                gameBoard.currentTotalLabels[j].Text = "Current Total: " + player.ALocalGame.PlayerList[j].PlayerHandValue.ToString();
            }

            // Handle cases where the player or dealer immeditately wins the game
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                if (player.ALocalGame.PlayerList[j].PlayerHandValue == 21)
                {
                    if (dealer.CurrentValueOfHand != 21)
                    {
                        playerBlackjack(player.ALocalGame.PlayerList[j]);
                    }
                }
            }
            if (dealer.CurrentValueOfHand == 21)
            {
                for (int u = 0; u < player.ALocalGame.PlayerList.Count; u++)
                {
                    if (player.ALocalGame.PlayerList[j].PlayerHandValue != 21)
                    {
                        dealerWins();
                    }
                } else if (player.ALocalGame.PlayerList[j].PlayerHand[0].Value == player.ALocalGame.PlayerList[j].PlayerHand[1].Value)
                {
                    gameBoard.controlsGroupBox.Size = new Size(197, 460);
                    gameBoard.splitButton.Visible = true;
                } else if (dealer.VisibleValueOfHand == 11)
                {
                    gameBoard.insuranceButton.Visible = true;
                    gameBoard.controlsGroupBox.Size = new Size(197, 550);
                }
            }
        }
        */

        public void hitButtonClick()
        {
            // Deal new card to player
            dealer.dealCard(player.ALocalGame.PlayerList[turnCounter], deck);

            // add card to player
            Card card = player.ALocalGame.PlayerList[turnCounter].PlayerHand[player.ALocalGame.PlayerList[turnCounter].PlayerHand.Count - 1];
            if (player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                addPlayerCard(card, player.ALocalGame.PlayerList[turnCounter], hand);
            }
            else
            {
                addPlayerCard(card, player.ALocalGame.PlayerList[turnCounter]);
            }
            if (player.ALocalGame.PlayerList[turnCounter].PlayerHand[player.ALocalGame.PlayerList[turnCounter].PlayerHand.Count - 1].Value == "ace")
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                {
                    player.ALocalGame.PlayerList[turnCounter].PlayerHandValue -= 10;
                }
            }

            // display total card hand value for player
            gameBoard.currentTotalLabels[turnCounter].Text = "Current Total: " + (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue).ToString();
            if (!player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                {
                    playerBusts(player.ALocalGame.PlayerList[turnCounter]);
                }
                else if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                {
                    standButtonClick();
                }
            } else
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21 || player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                {
                    standButtonClick();
                }
            }
            
        }

        public void standButtonClick()
        {
            int j;
            GamePlayer winner = null;
            if (turnCounter == 3)
            {
                while (dealer.CurrentValueOfHand < 17)
                {
                    dealer.dealSelf(dealer, deck);
                    Card card = dealer.CurrentPlayerHand[dealer.CurrentPlayerHand.Count - 1];
                    addDealerCard(card, dealer);
                    gameBoard.dealerVisableTotalLabel.Text = (dealer.CurrentValueOfHand).ToString();
                }

                int currTop = 0;
                int loses = 0;
                for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
                {
                    if (player.ALocalGame.PlayerList[j].PlayerHandValue == 21)
                    {
                        winner = player.ALocalGame.PlayerList[j];
                        break;
                    }
                    else if (player.ALocalGame.PlayerList[j].PlayerHandValue < 21 && player.ALocalGame.PlayerList[j].PlayerHandValue > currTop)
                    {
                        currTop = player.ALocalGame.PlayerList[j].PlayerHandValue;
                        winner = player.ALocalGame.PlayerList[j];
                    }
                    else
                    {
                        loses++;
                        if (loses > 2)
                        {
                            dealerWins();
                        }
                    }
                }
                if (loses < 3)
                {
                    playerWins(winner);
                }
            }
            else if (player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                if (hand == 0)
                {
                    if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                    {
                        // Blackjack!
                    }
                    else if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                    {
                        // Bust!
                    }
                    valueOfFirstHand = player.ALocalGame.PlayerList[turnCounter].PlayerHandValue;
                    player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 0;
                    player.ALocalGame.PlayerList[turnCounter].PlayerHand.Clear();
                    player.ALocalGame.PlayerList[turnCounter].PlayerHand.Add(secondHand);
                    hand = 1;
                }
                else
                {
                    valueOfSecondHand = player.ALocalGame.PlayerList[turnCounter].PlayerHandValue;
                    while (dealer.CurrentValueOfHand < 17)
                    {
                        dealer.dealSelf(dealer, deck);
                        Card card = dealer.CurrentPlayerHand[dealer.CurrentPlayerHand.Count - 1];
                        addDealerCard(card, dealer);
                        gameBoard.dealerVisableTotalLabel.Text = (dealer.CurrentValueOfHand).ToString();
                    }
                    turnCounter++;
                }
            }
            else
            {
                turnCounter = (turnCounter + 1) % player.ALocalGame.PlayerList.Count;
            }
        }

        public void continueButtonClick()
        {
            if (roundFinished == true)
            {
                resetTableTurn();
            }
            else
            {
                turnCounter = (turnCounter + 1) % player.ALocalGame.PlayerList.Count;
                gameBoard.betButton.Enabled = true;
            }
            
        }

        public void splitButtonClick()
        {
            player.ALocalGame.PlayerList[turnCounter].hasSplit = true;
            foreach (PictureBox picture in gameBoard.Controls)
            {
                gameBoard.Controls.Remove(picture);
            }

            for (int j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (player.ALocalGame.PlayerList[j].hasSplit)
                    {
                        addPlayerCard(player.ALocalGame.PlayerList[j].PlayerHand[i], player.ALocalGame.PlayerList[j], i);
                    }
                    else
                    {
                        addPlayerCard(player.ALocalGame.PlayerList[j].PlayerHand[i], player.ALocalGame.PlayerList[j]);
                    }
                }
            }

            // Generates the hand for the dealer
            foreach (Card card in dealer.CurrentPlayerHand)
            {
                addDealerCard(card, dealer);
            }

            if (player.ALocalGame.PlayerList[turnCounter].PlayerHand[0].Value == "ace")
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 11;
            }
            else
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue /= 2;
            }

            secondHand = player.ALocalGame.PlayerList[turnCounter].PlayerHand[1];

            hand = 0;
        }

        public void insuranceBet(int bet)
        {
            if (bet <= player.ALocalGame.PlayerList[turnCounter].PlayerBet / 2)
            {
                player.ALocalGame.PlayerList[turnCounter].insuranceBet = bet;
                if (dealer.CurrentValueOfHand == 21)
                {
                    //insuranceWin();
                }
                else
                {
                    //insuranceLoss();
                }
            }
            else
            {
                //turnForm.insuranceBetValueLabel.Text = "Invalid";
            }
        }

        public void resetTableTurn()
        {
            int j;
            for(j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                player.ALocalGame.PlayerList[j].PlayerHand.Clear();
                player.ALocalGame.PlayerList[j].PlayerHandValue = 0;
                gameBoard.currentBetLabels[j].Text = "Current Bet: ";
                gameBoard.currentTotalLabels[j].Text = "Current Total: ";
                player.ALocalGame.PlayerList[j].hasSplit = false;
            }
            dealer.CurrentPlayerHand.Clear();
            dealer.CurrentValueOfHand = 0;
            gameBoard.resultLabel.Text = "";
            gameBoard.dealerVisableTotalLabel.Text = "Dealer Visable Total: ";
            deck = new Deck();
            gameBoard.hitButton.Visible = false;
            gameBoard.standButton.Visible = false;
            gameBoard.betButton.Enabled = true;
            gameBoard.betTextBox.ReadOnly = false;
            gameBoard.insuranceButton.Visible = false;
            gameBoard.insuranceBetTextBox.Visible = false;
            gameBoard.controlsGroupBox.Size = new Size(197, 402);
            gameBoard.splitButton.Visible = false;
            hand = 0;
        }
        

        public void playerWins(GamePlayer winner)
        {
            winner.PlayerAmountOfMoney += winner.PlayerBet*2;
            gameBoard.resultLabel.Text = winner.Username + " Wins";
            roundFinished = true;
        }

        public void playerBlackjack(GamePlayer winner)
        {
            //winner.PlayerAmountOfMoney += winner.PlayerBet * 2;
            gameBoard.resultLabel.Text = "Blackjack! " + winner.Username;
            gameBoard.continueButton.Visible = true;
            gameBoard.continueButton.Enabled = true;
            gameBoard.hitButton.Enabled = false;
            gameBoard.standButton.Enabled = false;
            gameBoard.betButton.Enabled = false;
            roundFinished = true;
            blackjackArray[turnCounter] = true;
        }

        public void dealerWins()
        {
            gameBoard.resultLabel.Text = "Dealer Wins";
            gameBoard.continueButton.Visible = true;
            gameBoard.continueButton.Enabled = true;
            gameBoard.hitButton.Enabled = false;
            gameBoard.standButton.Enabled = false;
            gameBoard.betButton.Enabled = false;
            roundFinished = true;
        }

        public void playerBusts(GamePlayer play)
        {
            gameBoard.resultLabel.Text = play.Username + " Busted";
            gameBoard.continueButton.Visible = true;
            gameBoard.continueButton.Enabled = true;
            gameBoard.hitButton.Enabled = false;
            gameBoard.standButton.Enabled = false;
            gameBoard.betButton.Enabled = false;
            bustedArray[turnCounter] = true;
        }

        

        

    }
}
