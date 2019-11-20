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
            turn = new Turn(this, myDeck, player1, dealer);

            hitButton.Visible = false;
            standButton.Visible = false;
            continueButton.Visible = false;
            player1.CurrentAmountOfMoney = Int32.Parse(currentMoneyLabel.Text);
        }
        private void hitButton_Click(object sender, EventArgs e)
        { 
            turn.hitButtonClick();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            turn.standButtonClick();
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            if ( currentMoneyLabel.Text == "0" )
            {
                endGame();
            }
            this.continueButton.Visible = false;
            this.standButton.Visible = true;
            this.hitButton.Visible = true;
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
            if (betContainsOnlyDigits || this.betTextBox.Text == "")
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
            this.adjustMoneyTextBox.Text = "";
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
            if (adjustMoneyContainsOnlyDigits)
            {
                adjustMoneyStatusLabel.Text = "Valid";
            }
            else if(this.adjustMoneyTextBox.Text == "")
            {
                adjustMoneyStatusLabel.Text = "";
            }
            else
            {
                adjustMoneyStatusLabel.Text = "Not Valid";
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
