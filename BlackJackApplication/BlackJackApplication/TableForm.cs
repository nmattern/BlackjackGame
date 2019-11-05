using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApplication
{
    public partial class tableForm : Form
    {
        private Turn turn;

        public tableForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        { 
            Deck myDeck = new Deck();
            Dealer dealer = new Dealer();
            Player player1 = new Player();
            Table table = new Table();
            turn = new Turn(this, myDeck, table, player1, dealer);

            hitButton.Enabled = false;
            standButton.Enabled = false;
            continueButton.Enabled = false;
            player1.AmountOfMoney = Int32.Parse(currentMoneyLabel.Text);
        }

        private void hitButton_EnabledChanged(object sender, EventArgs e)
        {
            if (hitButton.BackColor == Color.Gray)
            {
                hitButton.BackColor = Color.Crimson;
            }
            else
            {
                hitButton.BackColor = Color.Gray;
            }
        }
        private void hitButton_Click(object sender, EventArgs e)
        { 
            turn.hitButtonClick();
        }

        private void standButton_EnabledChanged(object sender, EventArgs e)
        {
            if (standButton.BackColor == Color.Gray)
            {
                standButton.BackColor = Color.FromArgb(6,67,157); //blue color
            }
            else
            {
                standButton.BackColor = Color.Gray;
            }
        }
        private void standButton_Click(object sender, EventArgs e)
        {
            turn.standButtonClick();
        }

        private void continueButton_EnabledChanged(object sender, EventArgs e)
        {
            if (continueButton.BackColor == Color.Gray)
            {
                continueButton.BackColor = Color.FromArgb(6, 67, 157); //blue color
            }
            else
            {
                continueButton.BackColor = Color.Gray;
            }
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            if ( currentMoneyLabel.Text == "0" )
            {
                endGame();
            }
            this.continueButton.Enabled = false;
            this.standButton.Enabled = true;
            this.hitButton.Enabled = true;
            turn.continueButtonClick();
        }

        private void betTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.betTextBox.Text, out number);
            if (!betContainsOnlyDigits)
            {
                this.betTextBox.Text = "";
            }
        }
        private void lockBetButton_EnabledChanged(object sender, EventArgs e)
        {
            if (lockBetButton.BackColor == Color.Gray)
            {
                lockBetButton.BackColor = Color.FromArgb(6, 67, 157); //blue color
            }
            else
            {
                lockBetButton.BackColor = Color.Gray;
            }
        }
        private void lockBetButton_Click(object sender, EventArgs e)
        {
            turn.betButtonClick();
        }

        private void betTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.betTextBox.Text, out number);
            if (betContainsOnlyDigits)
            {
                betLabel.Text = betTextBox.Text;
            } else
            {
                betLabel.Text = "Not Valid";
            }
        }

        private void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            int number;
            bool adjustMoneyContainsOnlyDigits = Int32.TryParse(this.adjustMoneyTextBox.Text, out number);
            if (adjustMoneyContainsOnlyDigits)
            {
                turn.adjustMoneyButtonClick();
            }
        }

        private void adjustMoneyTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            int number;
            bool adjustMoneyContainsOnlyDigits = Int32.TryParse(this.adjustMoneyTextBox.Text, out number);
            if (!adjustMoneyContainsOnlyDigits)
            {
                this.adjustMoneyTextBox.Text = "";
            }
        }

        private void adjustMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool adjustMoneyContainsOnlyDigits = Int32.TryParse(this.adjustMoneyTextBox.Text, out number);
            if (!adjustMoneyContainsOnlyDigits)
            {
                adjustMoneyStatusLabel.Text = "Not Valid";
            }
            else
            {
                adjustMoneyStatusLabel.Text = "Valid";
            }
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
    }
}
